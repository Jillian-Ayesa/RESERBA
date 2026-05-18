using RESERBA_Proj.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace RESERBA_Proj.Database.GuardRepository
{
    public interface IGuardRepository
    {
        bool UsernameExists(string username);
        void Register(string username, string password);
        bool ValidateGuard(string username, string password, out int guardId);
        List<ParkingSlot> GetSlots(string gateId);
        bool FetchRate(string vehicleType, string passengerType, string paymentType,
                       out ParkingSession session, out decimal amountDue);
        bool MapStatus(string filter, string searchText, out List<ParkingSession> sessions);

    }
}