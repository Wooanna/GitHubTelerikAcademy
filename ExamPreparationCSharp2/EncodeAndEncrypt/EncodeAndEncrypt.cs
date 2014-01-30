using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace EncodeAndEncrypt
{
    class EncodeAndEncrypt
    {
        static void Main()
        {
            StringBuilder theMessage = new StringBuilder();
            string message = Console.ReadLine();
            theMessage.Append(message);
            StringBuilder theCypher = new StringBuilder();
            string cypher = Console.ReadLine();
            theCypher.Append(cypher);

            if (theMessage.Length >= cypher.Length)
            {
                EncryptLongerMessage(theMessage, theCypher);

            }
            else if (theCypher.Length > theMessage.Length)
            {
                EncryptShorterMessage(theMessage, theCypher);
            }

        }

        private static string GenerateFinalResult(StringBuilder encryptedMessage, StringBuilder cypher, int cypherDigitsCount)
        {
            StringBuilder finalString = new StringBuilder();
            finalString.Append(encryptedMessage);
            finalString.Append(cypher);
            finalString.Append(cypherDigitsCount);

            Encode(finalString);
            return finalString.ToString();

        }

        private static string Encode(StringBuilder finalString)
        {
            int counterOccurance = 1;
            char ch = ' ';

            for (int i = 0; i < finalString.Length - 1; i++)
            {
                if (finalString[i] == finalString[i + 1])
                {
                    counterOccurance++;
                    ch = finalString[i];
                }

                else if (counterOccurance > 2 && counterOccurance < finalString.Length -1 
                    && finalString[i] != finalString[i + 1])
                {
                    finalString.Remove(i - (counterOccurance - 1), counterOccurance);
                    finalString.Insert(i - counterOccurance + 1, counterOccurance);
                    finalString.Insert(i - (counterOccurance - counterOccurance.ToString().Length - 1), ch);

                }
                if ((i < finalString.Length - 1) && finalString[i] != finalString[i + 1])
                {
                    counterOccurance = 1;
                }

            }
            return finalString.ToString();
        }

        //first case from the task. The case where message is shorter than the cypher
        private static void EncryptShorterMessage(StringBuilder theMassage, StringBuilder theCypher)
        {   //0 1 2 3 4 5 6   
            //A A A B B
            //B B B B B B A
            StringBuilder encryptedMessage = new StringBuilder();
            int newCharIntValue;
            int index = 0;
            while (index < theCypher.Length - 1)
            {
                if (index < theMassage.Length) 
                {
                    newCharIntValue = (int)theMassage[index] - 65 ^ (int)theCypher[index] - 65;
                    encryptedMessage.Append((char)(newCharIntValue + 65));
                    index++;
                }
                else
                 {
                    while (index < theCypher.Length)
                    {
                        if (index >= theCypher.Length)
                        {
                            break;
                        }
                        newCharIntValue = ((int)encryptedMessage[index - (theMassage.Length)] - 65)
                            ^ ((int)theCypher[index] - 65);
                        encryptedMessage.Remove(index - (theMassage.Length), 1);
                        encryptedMessage.Insert(index - (theMassage.Length), (char)(newCharIntValue + 65));
                        index++;
                    }
                }
            }

            Console.WriteLine(GenerateFinalResult(encryptedMessage, theCypher, theCypher.Length));

        }
        //second case from the task. The case where message is longer than the cypher
        private static void EncryptLongerMessage(StringBuilder theMassage, StringBuilder theCypher)
        {
            //0 1 2 3 4 5 6 7 8 9 10 11 12 13
            //T E L E R I K A C A D  E  M  Y
            //S O F T W A R E
            StringBuilder encryptedMessage = new StringBuilder();
            int newCharIntValue; //this is the int value of every new char generated
            int index = 0;
            while (encryptedMessage.Length != theMassage.Length)
            {
                if (index > theCypher.Length - 1) //7
                {
                    newCharIntValue = (int)theMassage[index] - 65 ^ (int)theCypher[index % theCypher.Length] - 65;
                    encryptedMessage.Append((char)(newCharIntValue + 65));
                }
                else
                {
                    newCharIntValue = (int)theMassage[index] - 65 ^ (int)theCypher[index] - 65;
                    encryptedMessage.Append((char)(newCharIntValue + 65));

                }
                index++;
            }

            Console.WriteLine(GenerateFinalResult(encryptedMessage, theCypher, theCypher.Length));


        }
    }
}
