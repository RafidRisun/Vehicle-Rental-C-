namespace Vehicles
{
    internal class Car : Vehicle
    {
        public Car()
        {
            Console.WriteLine("Car Default Constructor");
        }

        public override void status()
        {
            Console.WriteLine("Status: Car");
        }
    }
}