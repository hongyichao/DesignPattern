using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    public class TransitMode : ITravelMode
    {
        public object GetDirection()
        {
            Console.WriteLine("Calculating Direction (transit)");
            return 3;
        }

        public object GetEta()
        {
            Console.WriteLine("Calculating ETA (transit)");
            return 3;
        }
    }
}
