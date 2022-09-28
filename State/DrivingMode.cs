
namespace State
{
    public class DrivingMode : ITravelMode
    {
        public object GetDirection()
        {
            Console.WriteLine("Calculating Direction (driving)");
            return 1;
        }

        public object GetEta()
        {
            Console.WriteLine("Calculating ETA (driving)");
            return 1;
            
        }
    }
}
