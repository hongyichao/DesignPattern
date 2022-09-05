using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    public class TextBox: UIControl
    {
        private String content;

        public String GetContent()
        {
            return content;
        }

        public void SetContent(String content)
        {
            this.content = content;
            NotifyEventHandlers();
        }
    }
}
