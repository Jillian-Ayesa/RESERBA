namespace RESERBA_Proj.Models
{
    public class DiscountedSession : StandardSession
    {
        public string PassengerType { get; private set; }
        public decimal DiscountPercent { get; private set; }

        public DiscountedSession(string plate, string gate, string slot,
                                 decimal baseRate, decimal hourlyRate,
                                 string passengerType, decimal discountPercent)
            : base(plate, gate, slot, baseRate, hourlyRate)
        {
            PassengerType = passengerType;
            DiscountPercent = discountPercent;
        }

        public override decimal CalculateTotalDue(DateTime exitTime)
        {
            decimal fullAmount = base.CalculateTotalDue(exitTime);
            decimal discount = fullAmount * (DiscountPercent / 100);
            return fullAmount - discount;
        }
    }
}