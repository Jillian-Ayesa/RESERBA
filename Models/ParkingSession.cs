namespace RESERBA_Proj.Models
{
    public abstract class ParkingSession
    {
        public string SessionId { get; protected set; }
        public string PlateNumber { get; protected set; }
        public string GateId { get; protected set; }
        public string SlotId { get; protected set; }
        public DateTime EntryTime { get; protected set; }
        public bool IsPaid { get; protected set; }

        public decimal BaseRate { get; protected set; }
        public decimal HourlyRate { get; protected set; }
        public decimal DiscountPercent { get; protected set; }

        protected ParkingSession(string plate, string gate, string slot)
        {
            SessionId = "S" + DateTime.Now.ToString("yyyyMMddHHmmss");
            PlateNumber = plate;
            GateId = gate;
            SlotId = slot;
            EntryTime = DateTime.Now;
            IsPaid = false;
        }


        public abstract decimal CalculateTotalDue(DateTime exitTime);
        public abstract void ProcessCheckOut(DateTime exitTime);
    }

    public class ActiveSession : ParkingSession
    {
        public ActiveSession(string sessionId, string slotId, string plate)
            : base(plate, "", slotId)
        {
            SessionId = sessionId;
        }

        public override decimal CalculateTotalDue(DateTime exitTime) => 0;
        public override void ProcessCheckOut(DateTime exitTime) { }
    }
    public class ParkingSlot
    {
        public string SlotId { get; set; }
        public bool IsOccupied { get; set; }
        public string SlotType { get; set; }
    }
}