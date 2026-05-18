using System;
using System.Collections.Generic;
using System.Text;

namespace RESERBA_Proj.Database.GuardRepository
{
    public class AdminGuard
        {
            public int GuardId { get; set; }
            public string Username { get; set; }
            public string AssignedGate { get; set; }

            public bool Login(string username, string password) { return false; } // handled by repo
            public string ViewRecord() { return ""; } // future use
    }
}
