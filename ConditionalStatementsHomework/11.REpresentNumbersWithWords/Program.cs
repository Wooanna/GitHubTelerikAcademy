using System;
//Write a program that converts a number in the range [0...999]
//to a text corresponding to its English pronunciation. Examples:
//	0  "Zero"
//	400  "Four hundred"
//	501  "Five hundred and one"
//	711  "Seven hundred and eleven"

class REpresentNumbersWithWords
{
    static void Main()

    {
        Console.WriteLine("Enter a number [99 ... 999] \nEnter each digit on a different row \nAs you start from Hundreds, next Tens, next Ones:");
        Console.WriteLine("Enter Hundreds:");
        int firstDigitInput = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter Tens:");
        int secondDigitInput =int.Parse( Console.ReadLine());
        Console.WriteLine("Enter Ones:");
        int thirdDigitInput = int.Parse(Console.ReadLine());

        string[] firstDigit = new string[9] { "One Hundred ", "Two Hundred ", "Three Hundred ", "Four Hundred ", "Five Hundred ", "Six hundred ", "Seven Hundred ", "Eight Hundred ", "Nine Hundred " };
        string[] secondDigitOne = new string[9] {  "Eleven ", "Twelve ", "Thirteen ", "Fourteen ", "Fifteen ", "Sixteen ", "Seventeen ", "Eighteen ", "Nineteen " };
        string[] secondDigit = new string[9] { "Ten ", "Twenty ", "Thirty ", "Fourty ", "Fifty ", "Sixty ", "Seventy ", "Eighty ", "Ninety " };
        string[] thirdDigit = new string[9] { "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", };

        string firstDigitOutput = null;
        string secondDigitOutput =null;
        string thirdDigitOutput = null;
        

        for (int g= 0; g < firstDigitInput; g++)
			{
			  firstDigitOutput =  firstDigit[g];
             
			}
                Console.Write(firstDigitOutput);

                if (thirdDigitInput == 0)
                {
                    for (int i = 0; i < secondDigitInput; i++)
                    {
                           secondDigitOutput   = secondDigit[i] ;
                    }
                }



       
			 if (secondDigitInput == 1)
             {
                 for (int j = 0; j < thirdDigitInput; j++)
			            {
			                secondDigitOutput = secondDigitOne[j];
                
			            }
                 Console.Write(secondDigitOutput);
             }

             else             
	         {
                 for (int y = 0; y < secondDigitInput; y++)
			            {
			            secondDigitOutput = secondDigit[y];
           
			            }
                    Console.Write(secondDigitOutput);
           	}

             if (secondDigitInput != 1)
             {
                 for (int k = 0; k < thirdDigitInput; k++)
                 {
                     thirdDigitOutput = thirdDigit[k];
                 }
                 Console.Write(thirdDigitOutput);
             }
             else
             {
                 Console.Write("");
             }
            }
        }




    


