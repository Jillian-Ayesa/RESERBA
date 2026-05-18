namespace RESERBA_Proj.Models
{
    public class StandardSession : ParkingSession
    {
        public decimal BaseRate     { get; private set; }
        public decimal HourlyRate   { get; private set; }
        public int EstimatedMinutes { get; private set; }
        private const int BASE_HOURS = 3; // first 3 hours covered by base rate

        public StandardSession(string plate, string gate, string slot,
                               decimal baseRate, decimal hourlyRate)
            : base(plate, gate, slot)
        {
            BaseRate   = baseRate;
            HourlyRate = hourlyRate;
        }

        public void SetEstimatedDuration(int minutes)
        {
            EstimatedMinutes = minutes;
        }

        public override decimal CalculateTotalDue(DateTime exitTime)
        {
            double actualHours = (exitTime - EntryTime).TotalHours;
            decimal total      = BaseRate; // covers first 3 hours

            // Charge hourly only beyond the first 3 hours
            if (actualHours > BASE_HOURS)
            {
                int extraHours = (int)Math.Ceiling(actualHours - BASE_HOURS);
                total += extraHours * HourlyRate;
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