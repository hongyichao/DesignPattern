using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    public class DiamondWindow : Window
    {
        protected override void AfterCloseAct()
        {
            Console.WriteLine("Remove window from the diamond window");
        }
    }
}
