namespace Vehicles
{
    internal class Motorbike : Vehicle
    {
        public Motorbike()
        {
            Console.WriteLine("Motorbike Default Constructor");
        }

        public override void status()
        {
            Console.WriteLine("Status: Motorbike");
        }
    }
}