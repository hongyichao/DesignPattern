using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    public class Button: UIControl
    {
        private bool isEnabled;

        public bool IsEnabled()
        {
            return isEnabled;
        }

        public void SetEnabled(bool enabled)
        {
            isEnabled = enabled;
            NotifyEventHandlers();
        }
    }
}
