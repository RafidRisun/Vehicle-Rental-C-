namespace Vehicles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vehicle obj1 = new Motorbike();

            obj1.VehicleName = "Honda";

            obj1.VehicleId = "123123";

            obj1.showInfo();

            obj1.status();

            Console.WriteLine();

            Vehicle obj2 = new Truck();

            obj2.VehicleName = "MAN";

            obj2.VehicleId = "456";

            obj2.showInfo();

            obj2.status();

            Console.WriteLine();

            Vehicle obj3 = new Car();

            obj3.VehicleName = "Toyota";

            obj3.VehicleId = "45623";

            obj3.showInfo();

            obj3.status();

            Console.WriteLine();

            Vehicle obj4 = new MPV();

            obj4.VehicleName = "Hiace";

            obj4.VehicleId = "123456";

            obj4.showInfo();

            obj4.status();

            Console.WriteLine();

            Vehicle obj5 = new Saloon();

            obj5.VehicleName = "Premio";

            obj5.VehicleId = "898456";

            obj5.showInfo();

            obj5.status();
        }
    }
}