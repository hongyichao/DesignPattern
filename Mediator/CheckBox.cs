using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    public class CheckBox: UIControl
    {
        private bool isChecked;

        public bool IsChecked()
        {
            return isChecked;
        }

        public void SetChecked(bool check)
        {
            isChecked = check;
            NotifyEventHandlers();
        }
    }
}
