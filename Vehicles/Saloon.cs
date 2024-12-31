namespace Vehicles
{
    internal class Saloon : Car
    {
        public Saloon()
        {
            Console.WriteLine("Saloon Default Constructor");
        }

        public override void status()
        {
            Console.WriteLine("Status: Car (Saloon)");
        }
    }
}