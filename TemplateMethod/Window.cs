using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    public abstract class Window
    {
        public void close()
        {
            //TODO: custom windows may need to execute some code before the window
            // is closed.

            BeforeCloseAct();

            Console.WriteLine("Removing the window from the screen");

            //TODO: custom windows may need to execute some code after the window
            // is closed.

            AfterCloseAct();
        }

        protected abstract void AfterCloseAct();

        public void BeforeCloseAct() 
        {
            Console.WriteLine("Release memory");
        }
    }
}
