using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    public class UnsupportedFormatHandler : Handler
    {
        public UnsupportedFormatHandler(Handler next) : base(next)
        {

        }

        protected override bool DoHandle(string fileName)
        {
            Console.WriteLine("File format not supported.");
            return true;
        }
    }
}
