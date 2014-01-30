using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program that encodes and decodes a string using given encryption key (cipher).
//The key consists of a sequence of characters. The encoding/decoding is done by performing 
//XOR (exclusive or) operation over the first letter of the string with the first of the key,
//the second – with the second, etc. When the last key character is reached, the next is 
//the first.


    class Encode
    {
        static void Main(string[] args)
        {
            string message, cypher;
            do
            {
                Console.WriteLine("Please enter message:");
                 message = Console.ReadLine();
                Console.WriteLine("Please enter cypher:");
                 cypher = Console.ReadLine();
                
            } while (message.Length < cypher.Length);

            ProcessEncrypt(message, cypher);
        }

        private static void ProcessEncrypt(string message, string cypher)
        {
            StringBuilder encryptedMessage = new StringBuilder();
            int newCharIntValue; //this is the int value of every new char generated
            int index = 0;
            while (encryptedMessage.Length != message.Length)
            {
                if (index > cypher.Length - 1) //7
                {
                    newCharIntValue = (int)message[index] - 65 ^ (int)cypher[index % cypher.Length] - 65;
                    encryptedMessage.Append((char)(newCharIntValue + 65));
                }
                else
                {
                    newCharIntValue = (int)message[index] - 65 ^ (int)cypher[index] - 65;
                    encryptedMessage.Append((char)(newCharIntValue + 65));

                }
                index++;
            }
            Console.WriteLine(encryptedMessage);
        }
    }

