using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;

namespace MessageInABottle
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();
            string cipher = Console.ReadLine();

            int counter = 0;

            List<char> letter = new List<char>();
            List<string> numbers = new List<string>();


            string temp = string.Empty;

            while (counter < cipher.Length)
            {
                if (char.IsLetter(cipher[counter]) )
                {
                    letter.Add(cipher[counter]);
                    
                }
                else
                {
                    temp += cipher[counter ];
                    while (counter < cipher.Length - 1 && char.IsDigit(cipher[counter + 1] ))
                    {
                        temp += cipher[counter + 1];
                        counter++;
                        
                    }

                    numbers.Add(temp);
                    temp = string.Empty;
                }
                counter++;
            }


            for (int i = 0; i <letter.Count; i++)
            {
                Console.WriteLine(letter[i]  +  " " + numbers[i]);
            }



        }
    }
}
