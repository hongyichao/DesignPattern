using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    public class TextCommand : IUndoableCommand
    {
        private string previousText = string.Empty;

        VideoEditor videoEditor;
        History history;

        public TextCommand(VideoEditor videoEditor, History history) 
        { 
            this.videoEditor = videoEditor;
            this.history = history;
        }

        public void Execute(object newValue)
        {
            var newText = (string)newValue;
            previousText = videoEditor.getText();
            videoEditor.setText(newText);
            history.Push(this);
        }

        public void Undo()
        {
            videoEditor.setText(previousText);
        }
    }
}
