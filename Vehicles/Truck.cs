namespace Vehicles
{
    internal class Truck : Vehicle 
    {
        public Truck()
        {
            Console.WriteLine("Truck Default Constructor");
        }

        public override void status()
        {
            Console.WriteLine("Status: Truck");
        }
    }
}