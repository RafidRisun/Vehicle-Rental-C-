namespace Vehicles
{
    internal class Vehicle
    {
        private String vehicleName;
        private String vehicleId;
        public static int vehicleCount;

        public String VehicleName
        {
            get { return vehicleName; }
            set { vehicleName = value; }
        }
        public String VehicleId
        {
            get { return vehicleId; }
            set { vehicleId = value; }
        }

        public Vehicle()
        {
            vehicleName = "";
            vehicleId = "";
            vehicleCount++;
            Console.WriteLine("Default Constructor Called");
        }
        /*
        public Vehicle(string vehicleName, string vehicleId)
        {
            this.vehicleName = vehicleName;
            this.vehicleId = vehicleId;
            vehicleCount++;
        }*/

        public virtual void status()
        {
            Console.WriteLine("Vehicle Status: ???");
        }

        public void showInfo()
        {
            Console.WriteLine("Vehicle Name: "+ vehicleName);
            Console.WriteLine("Vehicle Id: "+ vehicleId);
        }
    }
}