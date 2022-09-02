using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    public class RoundWindow : Window
    {
        protected override void AfterCloseAct()
        {
            Console.WriteLine("Remove components from the Round Window");
        }
    }
}
