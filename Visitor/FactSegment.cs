using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    public class FactSegment : Segment
    {
        public override void Execute(IOperation operation)
        {
            operation.Apply(this);
        }
    }
}
