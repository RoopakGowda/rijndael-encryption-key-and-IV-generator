using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// Produces a random key and IV respectively for encryption on console
/// </summary>
namespace CreateEncryptionKey
{
    class Program
    {
        public delegate void BeforePrint();
        static void Main(string[] args)
        {
            using (RijndaelManaged myRijndael = new RijndaelManaged())
            {
                myRijndael.GenerateKey();
                myRijndael.GenerateIV();
                // Encrypt the string to an array of bytes.
                var key = Convert.ToBase64String(myRijndael.Key);
                var Iv = Convert.ToBase64String(myRijndael.IV);
                Console.WriteLine(" Key and IV Generator");
                Console.WriteLine();
                Console.WriteLine(" KEY" + " - " +Convert.ToBase64String(myRijndael.Key));
                Console.WriteLine(" IV" + " - " + Convert.ToBase64String(myRijndael.IV));
                Console.WriteLine();
                Console.WriteLine("-----------Press enter key to close-------------");
            }
            Console.ReadLine();
        }
    }
}
