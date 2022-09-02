using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    public class UndoCommand
    {
        History history;

        public UndoCommand(History history) 
        {
            this.history = history;
        }

        public void Undo() 
        {
            this.history.Pop().Undo();
        }
    }
}
