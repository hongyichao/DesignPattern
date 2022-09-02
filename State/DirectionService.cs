using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
