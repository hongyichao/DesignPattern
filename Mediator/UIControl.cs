using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    public abstract class UIControl
    {
        private List<Delegate> eventHandlers = new List<Delegate>();

        public void AddEventHandler(Delegate eventHandler) 
        { 
            eventHandlers.Add(eventHandler);
        }

        public void NotifyEventHandlers() 
        {
            foreach (var e in eventHandlers) 
            {
                e.DynamicInvoke();
            }
        }
    }
}
