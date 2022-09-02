using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class DesEncryptionAlgorithm : IEncryptionAlgorithm
    {
        public void EncryptMessage(string message)
        {
            Console.WriteLine("Encrypting message using DES");
        }
    }
}
