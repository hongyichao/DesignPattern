using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    public class NormalizeOperation : IOperation
    {
        public void Apply(FormatSegment formatSegment)
        {
            Console.WriteLine("Normalize for format segment");
        }

        public void Apply(FactSegment factSegment)
        {
            Console.WriteLine("Normalize for fact segment");
        }
    }
}
