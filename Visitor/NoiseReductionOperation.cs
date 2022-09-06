using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    public class NoiseReductionOperation : IOperation
    {
        public void Apply(FormatSegment formatSegment)
        {
            Console.WriteLine("Noise Reduction for format segment");
        }

        public void Apply(FactSegment factSegment)
        {
            Console.WriteLine("Noise Reduction for fact segment");
        }
    }
}
