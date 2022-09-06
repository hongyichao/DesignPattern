using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    public interface IOperation
    {
        public void Apply(FormatSegment formatSegment);
        public void Apply(FactSegment factSegment);
    }
}
