using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    public abstract class UIControl
    {
        private List<IEventHandler> eventHandlers = new List<IEventHandler>();

        public void AddEventHandler(IEventHandler eventHandler) 
        { 
            eventHandlers.Add(eventHandler);
        }

        public void NotifyEventHandlers() 
        {
            foreach (var e in eventHandlers) 
            {
                e.handler();
            }
        }
    }
}
