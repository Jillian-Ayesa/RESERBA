namespace RESERBA_Proj.Models
{
    public class Vehicle
    {
        public string PlateNumber { get; private set; }
        public string VehicleType { get; private set; }
        public string PassengerType { get; private set; }
        public int WheelCount { get; private set; }

        public Vehicle(string plate, string vehicleType,
                       string passengerType, int wheelCount)
        {
            PlateNumber = plate;
            VehicleType = vehicleType;
            PassengerType = passengerType;
            WheelCount = wheelCount;
        }

        public string GetDetails()
        {
            return $"Plate: {PlateNumber} | Type: {VehicleType} | " +
                   $"Passenger: {PassengerType} | Wheels: {WheelCount}";
        }
    }
}