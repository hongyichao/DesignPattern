using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    public abstract class Handler
    {
        private Handler next;

        public Handler(Handler next)
        {
            this.next = next;
        }

        public void Handle(string fileName) 
        {
            if (DoHandle(fileName)) 
            {
                return ;
            }

            if (next != null) 
            {
                this.next.Handle(fileName);
            }
        }

        protected abstract bool DoHandle(string fileName);
    }
}
