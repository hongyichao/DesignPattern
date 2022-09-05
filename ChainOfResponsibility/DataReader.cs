using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    public class DataReader
    {
        Handler handler;

        public DataReader(Handler handler) 
        { 
            this.handler = handler;
        }

        public void Read(String fileName)
        {
            handler.Handle(fileName);
        }
    }
}
