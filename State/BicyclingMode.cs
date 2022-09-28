
namespace State
{
    public class BicyclingMode : ITravelMode
    {
        public object GetDirection()
        {
            Console.WriteLine("Calculating Direction (bicycling)");
            return 2;            
        }

        public object GetEta()
        {
            Console.WriteLine("Calculating ETA (bicycling)");
            return 2;
        }
    }
}
