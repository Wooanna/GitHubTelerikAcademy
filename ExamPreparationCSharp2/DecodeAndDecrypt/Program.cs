using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class DecodeAndDecrypt
{
    static void Main()
    {
        string input = Console.ReadLine();
        StringBuilder decodeInput = new StringBuilder();

        string cypherLength = string.Empty;
        int index = 0;
        for (int i = input.Length - 1; i > 0; i--)
        {
            if (!char.IsDigit(input[i]))
            {
                index = i;
                break;
            }

        }
        cypherLength = input.Substring(index + 1);

        int cypherLengthInt = int.Parse(cypherLength);
        input = input.Remove(index + 1);

        input = Decode(input, cypherLength);
        
        string cypher = input.Substring(input.Length - cypherLengthInt);
        input = input.Remove(input.Length - cypher.Length);
        string decryptedMessage = input;

         if (cypher.Length <= decryptedMessage.Length)
        {
            DecryptLongerMessage(decryptedMessage, cypher);
        }
        if (cypher.Length > decryptedMessage.Length)
        {
            DecryptShorterMessage(decryptedMessage, cypher);
        }
    }

    private static void DecryptShorterMessage(string decryptedMessage, string cypher)
    {
        StringBuilder result = new StringBuilder();
        int newCharIntValue;
        int index = 0;
        while (index < cypher.Length - 1)
        {
            if (index < decryptedMessage.Length)
            {
                newCharIntValue = (int)decryptedMessage[index] - 65 ^ (int)cypher[index] - 65;
                result.Append((char)(newCharIntValue + 65));
                index++;
            }
            else
            {
                while (index < cypher.Length)
                {
                    if (index >= cypher.Length)
                    {
                        break;
                    }
                    newCharIntValue = ((int)result[index - (decryptedMessage.Length)] - 65)
                        ^ ((int)cypher[index] - 65);
                    result.Remove(index - (decryptedMessage.Length), 1);
                    result.Insert(index - (decryptedMessage.Length), (char)(newCharIntValue + 65));
                    index++;
                }
            }
        }

        Console.WriteLine(result);

    }

    private static void DecryptLongerMessage(string decryptedMessage, string cypher)
    {
        StringBuilder result = new StringBuilder();
        int newCharIntValue; //this is the int value of every new char generated
        int index = 0;
        while (result.Length != decryptedMessage.Length)
        {
            if (index > cypher.Length - 1) //7
            {
                newCharIntValue = (int)decryptedMessage[index] - 65 ^ (int)cypher[index % cypher.Length] - 65;
                result.Append((char)(newCharIntValue + 65));
            }
            else
            {
                newCharIntValue = (int)decryptedMessage[index] - 65 ^ (int)cypher[index] - 65;
                result.Append((char)(newCharIntValue + 65));

            }
            index++;
        }
        Console.WriteLine(result);

    }

    private static string Decode(string input, string cypherLength)
    {
        StringBuilder inputDecoded = new StringBuilder();
        //int helper = cypherLength.Length; //2
        char encryptedChar;
        for (int i = 0; i < input.Length; i++)
        {
            if (char.IsDigit(input[i]))
            {
                StringBuilder countOfEncryptedChars = new StringBuilder();
                while (char.IsDigit(input[i]))
                {
                    countOfEncryptedChars.Append(input[i]);
                    i++;
                }
                encryptedChar = input[i];
                if (int.Parse(countOfEncryptedChars.ToString()) > 2)
                {
                    inputDecoded.Append(encryptedChar, int.Parse(countOfEncryptedChars.ToString()));

                }
                else
                {
                    inputDecoded.Append(countOfEncryptedChars);

                }

            }
            else
            {
                inputDecoded.Append(input[i]);
            }
        }
        return inputDecoded.ToString();

    }
}

