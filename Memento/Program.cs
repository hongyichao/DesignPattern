using System;

namespace Memento
{
    class Program
    {
        static void Main(string[] args)
        {
            

            DocumentHistory documentHistory = new DocumentHistory();

            Document doc = new Document();

            doc.setContent("Hello Memento Pattern");
            documentHistory.Push(doc.CreateState());

            doc.setFontName("Memento font name");
            documentHistory.Push(doc.CreateState());

            doc.setContent("Test Memento Pattern");
            
            var docStr = doc.ToString();

            Console.WriteLine(docStr);

            doc.RestoreState(documentHistory.Pop());

            Console.WriteLine(doc.ToString());
            doc.RestoreState(documentHistory.Pop());

            Console.WriteLine(doc.ToString());

            Console.ReadKey();
        }
    }
}
