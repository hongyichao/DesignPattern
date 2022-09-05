using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    public class NumbersSheetReader : Handler
    {
        public NumbersSheetReader(Handler next) : base(next)
        {
        }

        protected override bool DoHandle(string fileName)
        {
            if (fileName.EndsWith(".numbers"))
            {
                Console.WriteLine("Reading data from a Numbers spreadsheet.");
                return true;
            }

            return false;
        }
    }
}
