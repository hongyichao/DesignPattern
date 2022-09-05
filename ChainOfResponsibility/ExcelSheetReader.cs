using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    public class ExcelSheetReader : Handler
    {
        public ExcelSheetReader(Handler next) : base(next)
        {
        }

        protected override bool DoHandle(string fileName)
        {
            if (fileName.EndsWith(".xls")) 
            {
                Console.WriteLine("Reading data from an Excel spreadsheet.");
                return true;
            }

            return false;
        }
    }
}
