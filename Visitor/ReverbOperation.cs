using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    public class ReverbOperation : IOperation
    {
        public void Apply(FormatSegment formatSegment)
        {
            Console.WriteLine("Reverb for format segment");
        }

        public void Apply(FactSegment factSegment)
        {
            Console.WriteLine("Reverb for fact segment");
        }
    }
}
