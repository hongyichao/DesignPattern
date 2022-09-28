
namespace State
{
    public class OtherMode : ITravelMode
    {
        public object GetDirection()
        {
            Console.WriteLine("Calculating Direction (walking)");
            return 4;
        }

        public object GetEta()
        {
            Console.WriteLine("Calculating ETA (walking)");
            return 4;
        }
    }
}
