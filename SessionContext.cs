using System;
using System.Collections.Generic;
using System.Text;

namespace RESERBA_Proj
{
    public static class SessionContext
    {
        public static string GuardUsername { get; set; }
        public static string GateId { get; set; }
        public static int GuardId { get; set; }
        public static string SelectedSlotId { get; set; }
        public static string PlateNumber { get; set; }
        public static string VehicleType { get; set; }
        public static int WheelCount { get; set; } = 0;
        public static string PassengerType { get; set; }
        public static string ActiveSessionId { get; set; }
        public static int EstimatedDuration { get; set; } = 0;
        public static DateTime EstimatedTimeOut { get; set; }

        public static void ClearSession()
        {
            SelectedSlotId = null;
            PlateNumber = null;
            VehicleType = null;
            WheelCount = 0;
            PassengerType = null;
            ActiveSessionId = null;
            EstimatedDuration = 0;
        }
    }
}