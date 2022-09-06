﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    public abstract class Segment
    {
        public abstract void Execute(IOperation operation);
    }
}
