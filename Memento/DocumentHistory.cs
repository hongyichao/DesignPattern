using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento
{
    public class DocumentHistory
    {
        List<DocumentState> documentStates;

        public DocumentHistory() 
        {
            documentStates = new List<DocumentState>();
        }

        public void Push(DocumentState state) 
        {
            documentStates.Add(state);
        }

        public DocumentState Pop() 
        {
            var stateToReturn = documentStates[documentStates.Count - 1];

            documentStates.RemoveAt(documentStates.Count - 1);

            return stateToReturn;
        }
    }
}
