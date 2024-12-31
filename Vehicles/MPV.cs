namespace Vehicles
{
    internal class MPV : Car
    { 
        public MPV()
        {
            Console.WriteLine("MPV Default Constructor");
        }

        public override void status()
        {
            Console.WriteLine("Status: Car (MPV)");
        }
    
    }
        
    
}