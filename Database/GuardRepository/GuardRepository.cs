using MySql.Data.MySqlClient;
using RESERBA_Proj.Database;
using RESERBA_Proj.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace RESERBA_Proj.Database.GuardRepository{
    public class GuardRepository : IGuardRepository
    {
        public bool UsernameExists(string username)
        {
            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string query = "SELECT COUNT(*) FROM guards WHERE username=@u";
                var cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@u", username);
                return Convert.ToInt32(cmd.ExecuteScalar()) > 0;
            }
        }

        public void Register(string username, string password)
        {
            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string query = "INSERT INTO guards (username, password) VALUES (@u, @p)";
                var cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@u", username);
                cmd.Parameters.AddWithValue("@p", password);
                cmd.ExecuteNonQuery();
            }
        }
        public bool ValidateGuard(string username, string password, out int guardId)
        {
            guardId = 0;
            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string query = "SELECT guard_id FROM guards WHERE username=@u AND password=@p";
                var cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@u", username);
                cmd.Parameters.AddWithValue("@p", password);

                var reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read();
                    guardId = Convert.ToInt32(reader["guard_id"]);
                    return true;
                }
                return false;
            }
        }
        public List<ParkingSlot> GetSlots(string gateId)
        {
            var slots = new List<ParkingSlot>();

            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();

                string query = "SELECT slot_id, is_occupied, slot_type " +
                               "FROM parking_slots WHERE gate_id=@gate " +
                               "ORDER BY " +
                               "CASE " +
                               "WHEN slot_type LIKE 'VIP%' THEN 1 " +
                               "WHEN slot_type LIKE 'PWD%' THEN 2 " +
                               "WHEN slot_type LIKE 'EV%'  THEN 3 " +
                               "ELSE 4 END, " +
                               "CAST(SUBSTRING_INDEX(slot_id, '-P', -1) AS UNSIGNED)";

                var cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@gate", gateId);
                var reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    slots.Add(new ParkingSlot
                    {
                        SlotId = reader["slot_id"].ToString(),
                        IsOccupied = Convert.ToBoolean(reader["is_occupied"]),
                        SlotType = reader["slot_type"].ToString()
                    });
                }
            }

            return slots;
        }
        public bool FetchRate(string vehicleType, string passengerType, string paymentType,
                      out ParkingSession session, out decimal amountDue)
        {
            session = null;
            amountDue = 0;

            try
            {
                decimal baseRate = 0, hourlyRate = 0, discountPercent = 0;

                using (var conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();

                    // ── 1. Fetch rates ─────────────────────────────────────
                    if (passengerType != "Valet" && passengerType != "VIP")
                    {
                        var cmd = new MySqlCommand(
                            "SELECT base_rate, hourly_rate, discount_percent " +
                            "FROM pricing_rules " +
                            "WHERE vehicle_type=@v AND passenger_type=@p LIMIT 1", conn);
                        cmd.Parameters.AddWithValue("@v", vehicleType);
                        cmd.Parameters.AddWithValue("@p", passengerType);

                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                baseRate = Convert.ToDecimal(reader["base_rate"]);
                                hourlyRate = Convert.ToDecimal(reader["hourly_rate"]);
                                discountPercent = Convert.ToDecimal(reader["discount_percent"]);
                            }
                        }
                    }

                    // ── 2. Build session model ─────────────────────────────
                    string plate = string.IsNullOrWhiteSpace(SessionContext.PlateNumber) ? "TBD" : SessionContext.PlateNumber;
                    string gate = string.IsNullOrWhiteSpace(SessionContext.GateId) ? "" : SessionContext.GateId;
                    string slot = string.IsNullOrWhiteSpace(SessionContext.SelectedSlotId) ? "" : SessionContext.SelectedSlotId;

                    if (passengerType == "Valet")
                        session = new ValetSession(plate, gate, slot);
                    else if (discountPercent > 0)
                        session = new DiscountedSession(plate, gate, slot,
                                      baseRate, hourlyRate, passengerType, discountPercent);
                    else
                        session = new StandardSession(plate, gate, slot, baseRate, hourlyRate);

                    // ── 3. Calculate amount ────────────────────────────────
                    amountDue = session.CalculateTotalDue(DateTime.Now);

                    // ── 4. Insert session into DB ──────────────────────────
                    var insert = new MySqlCommand(@"
                INSERT INTO parking_sessions
                (session_id, plate_number, vehicle_type, wheel_count, passenger_type,
                 slot_id, gate_id, guard_id, entry_time,
                 payment_status, amount_due, session_type)
                VALUES
                (@sid, @plate, @vtype, @wheels, @ptype,
                 @slot, @gate, @guard, NOW(),
                 'Unpaid', @amount, @stype)", conn);

                    insert.Parameters.AddWithValue("@sid", session.SessionId);
                    insert.Parameters.AddWithValue("@plate", session.PlateNumber);
                    insert.Parameters.AddWithValue("@vtype", vehicleType);
                    insert.Parameters.AddWithValue("@wheels", SessionContext.WheelCount > 0 ? SessionContext.WheelCount : 4);
                    insert.Parameters.AddWithValue("@ptype", passengerType);
                    insert.Parameters.AddWithValue("@slot", string.IsNullOrWhiteSpace(session.SlotId) ? (object)DBNull.Value : session.SlotId);
                    insert.Parameters.AddWithValue("@gate", string.IsNullOrWhiteSpace(session.GateId) ? (object)DBNull.Value : session.GateId);
                    insert.Parameters.AddWithValue("@guard", SessionContext.GuardId > 0 ? (object)SessionContext.GuardId : DBNull.Value);
                    insert.Parameters.AddWithValue("@amount", amountDue);
                    insert.Parameters.AddWithValue("@stype", paymentType);
                    insert.ExecuteNonQuery();
                }

                return true;
            }
            catch { return false; }
        }
        public bool MapStatus(string filter, string searchText, out List<ParkingSession> sessions)
        {
            sessions = new List<ParkingSession>();

            try
            {
                using (var conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();

                    string query = "SELECT session_id, slot_id, plate_number FROM parking_sessions " +
                                   "WHERE exit_time IS NULL AND payment_status = @status";

                    if (!string.IsNullOrEmpty(searchText))
                        query += " AND (plate_number LIKE @search OR slot_id LIKE @search)";

                    query += " ORDER BY entry_time DESC";

                    var cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@status", filter);

                    if (!string.IsNullOrEmpty(searchText))
                        cmd.Parameters.AddWithValue("@search", "%" + searchText + "%");

                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            // Reuse ParkingSession properties — no new model needed
                            sessions.Add(new ActiveSession(
                                reader["session_id"].ToString(),
                                reader["slot_id"].ToString(),
                                reader["plate_number"].ToString()
                            ));
                        }
                    }
                }
                return true;
            }
            catch { return false; }
        }
    }
}
