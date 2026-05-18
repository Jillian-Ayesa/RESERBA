namespace RESERBA_Proj.Models
{
    public class ValetSession : ParkingSession
    {
        public decimal FlatRate { get; private set; }
        public decimal DaySurcharge { get; private set; }
        private const int HOURS_PER_DAY = 24;

        public ValetSession(string plate, string gate, string slot)
            : base(plate, gate, slot)
        {
            FlatRate = 200.00m;  // base valet rate
            DaySurcharge = 800.00m;  // per day after first 24hrs
        }

        public override decimal CalculateTotalDue(DateTime exitTime)
        {
            double totalHours = (exitTime - EntryTime).TotalHours;
            decimal total = FlatRate;

            // PHP 800 surcharge for every additional 24hr period
            if (totalHours > HOURS_PER_DAY)
            {
                int extraDays = (int)Math.Ceiling(
                    (totalHours - HOURS_PER_DAY) / HOURS_PER_DAY);
                total += extraDays * DaySurcharge;
            }

            return total;
        }

        public override void ProcessCheckOut(DateTime exitTime)
        {
            decimal finalAmount = CalculateTotalDue(exitTime);
            IsPaid = true;
        }
    }
}