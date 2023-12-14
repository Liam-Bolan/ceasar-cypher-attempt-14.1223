using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ceasar_cypher_attempt_14._1223
{
    internal class Program
    {
        
        static void Main(string[] args)
        {

            
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("CAESER CIPHERING\n\n1.ENCRYPT A PHRASE\n\n2.DECRYPT A PHRASE\n\n3.BRUTE FORCE ATTACK\n\n4.EXIT");
            int userchoice = int.Parse(Console.ReadLine());
            
            while(userchoice < 1 || userchoice > 4)
            {
                Console.WriteLine("Invalid user choice enter again: ");
                userchoice = int.Parse(Console.ReadLine());
            }
            if(userchoice == 1)
            {
                encrypt();
            }
            else if(userchoice == 2)
            {
                Decrypt();
            }
            else if(userchoice == 3)
            {
                BruteForce();
            }
            else if(userchoice == 4)
            {
                return;
            }
            
        }
        static void encrypt()
        {
            string Plain;
            string ciphertxt = "";
            int key = 0;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("ENCRYPTION");
            Console.Write("\nPlease enter a Plaintext phrase: ");
            Plain = Console.ReadLine();
            Plain = Plain.ToUpper();
            Console.WriteLine("\nPlease enter a ceaser cipher key: ");
            key = int.Parse(Console.ReadLine());

           

            for(int pos = 0; pos < Plain.Length; pos++)
            {
                if ("ABCDEFGHIJKLMNOPQRSTUVWXYZ".Contains(Plain[pos]))
                {
                    int textASCII = (int)Plain[pos];
                    int TextKey = textASCII + key;
                    if (TextKey > 90)
                    {
                        TextKey = TextKey - 26;
                    }
                    ciphertxt = ciphertxt + (char)TextKey;
                }
                else ciphertxt = ciphertxt + Plain[pos];    
            }
            Console.WriteLine(ciphertxt);
            Console.ReadKey();  
        }
        static void Decrypt()
        {
            int key = 0;
            string Plain;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("DECRYPTION");
            Console.Write("\nPlease enter a Plaintext phrase: ");
            Plain = Console.ReadLine();
            Plain = Plain.ToUpper();
            Console.WriteLine("\nPlease enter a ceaser cipher key: ");
            key = int.Parse(Console.ReadLine());


        }
        static void BruteForce()
        {
            int key;
            string Plain;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("BRUTE FORCE ATTACK");
            Console.Write("\nPlease enter a Plaintext phrase: ");
            Plain = Console.ReadLine();
            Plain = Plain.ToUpper();
            Console.WriteLine("\nPlease enter a ceaser cipher key: ");
            key = int.Parse(Console.ReadLine());



        }
    }
}
