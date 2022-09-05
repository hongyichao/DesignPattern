using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    internal class QuickBooksReader : Handler
    {
        public QuickBooksReader(Handler next) : base(next)
        {
        }

        protected override bool DoHandle(string fileName)
        {
            if (fileName.EndsWith(".qbw"))
            {
                Console.WriteLine("Reading data from a QuickBooks file.");
                return true;
            }
            return false;
        }
    }
}
