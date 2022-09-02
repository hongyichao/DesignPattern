using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class ChatClient
    {
        public ChatClient()
        {
            
        }

        public void send(String message, IEncryptionAlgorithm encryptionAlgorithm)
        {
            encryptionAlgorithm.EncryptMessage(message);

            Console.WriteLine("Sending the encrypted message...");
        }
    }
}
