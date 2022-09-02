using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    public class History
    {
        public Stack<IUndoableCommand> Commands { get; set; }

        public History() 
        {
            Commands = new Stack<IUndoableCommand>();
        }

        public void Push(IUndoableCommand command) 
        {
            Commands.Push(command);
        }

        public IUndoableCommand Pop() 
        {
            return Commands.Pop();
        }
    }
}
