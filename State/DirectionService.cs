
namespace State
{
    public class DirectionService
    {
        public ITravelMode travelMode { get; set; }

        public Object GetEta()
        {
            return travelMode.GetEta();
        }

        public Object GetDirection()
        {
           return travelMode.GetDirection();
        }

    }
}
