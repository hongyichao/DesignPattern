using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    public class ContrastCommand : IUndoableCommand
    {
        VideoEditor editor;
        History history;
        float contrastToUndo;

        public ContrastCommand(VideoEditor videoEditor, History history) 
        {
            this.editor = videoEditor;
            this.history = history;
            contrastToUndo = 0;
        }

        public void Execute(object newValue)
        {
            var newContrast = (float)newValue;

            contrastToUndo = editor.getContrast();
            editor.setContrast(newContrast);
            history.Push(this);
        }

        public void Undo()
        {
            editor.setContrast(contrastToUndo);
        }
    }
}
