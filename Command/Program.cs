// See https://aka.ms/new-console-template for more information
using Command;
using System.Runtime.ConstrainedExecution;

Console.WriteLine("Hello, World!");


var videoEditor = new VideoEditor();
var history = new History();
var undoCommand = new UndoCommand(history);

var contrastCommand = new ContrastCommand(videoEditor, history);
contrastCommand.Execute(1.56f);
Console.WriteLine(videoEditor.GetCurrentState());

var textCommand = new TextCommand(videoEditor, history);
textCommand.Execute("this is the new content. Hello Command Pattern");
Console.WriteLine(videoEditor.GetCurrentState());

undoCommand.Undo();
Console.WriteLine(videoEditor.GetCurrentState());

undoCommand.Undo();
Console.WriteLine(videoEditor.GetCurrentState());

