namespace GenomeDecoder
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    class GenomeDecoder
    {
        static int charsPerLine;
        static int charsPerPair;
        static StringBuilder finalResult = new StringBuilder();
        static StringBuilder result = new StringBuilder();

        static void Main()
        {
            ReadInput();
            GenFinalResult(result, charsPerLine, charsPerPair);
        }


        //private static void GenFinalResult(StringBuilder result, int charsPerLine, int charsPerPair)
        //{
        //    StringBuilder finalResult = new StringBuilder();
        //    int countLettersPerLine = 0;
        //    int countLettersPerPair = 0;
        //    int numberOfRows = result.Length / charsPerLine;

        //    int leftLastLine = result.Length % charsPerLine;

        //    if (result.Length % charsPerLine != 0)
        //    {
        //        numberOfRows++;
        //    }

        //    int indexOfRows = 1;
        //    for (int i = 0; i < result.Length; i++)
        //    {
        //        if (i % charsPerLine == 0 && numberOfRows > 99)
        //        {
        //            if (indexOfRows > 99)
        //            {
        //                finalResult.Append(indexOfRows);
        //                finalResult.Append(" ");
        //                indexOfRows++;
        //            }
        //            else if (indexOfRows > 9)
        //            {
        //                finalResult.Append(" ");
        //                finalResult.Append(indexOfRows);
        //                finalResult.Append(" ");
        //                indexOfRows++;
        //            }
        //            else
        //            {
        //                finalResult.Append(" ");
        //                finalResult.Append(" ");
        //                finalResult.Append(indexOfRows);
        //                finalResult.Append(" ");
        //                indexOfRows++;
        //            }
        //        }
        //            else if (i % charsPerLine == 0 && numberOfRows > 9)
        //        {
                    
        //            if (indexOfRows > 9)
        //            {
        //                finalResult.Append(indexOfRows);
        //                finalResult.Append(" ");
        //                indexOfRows++;
        //            }
        //            else
        //            {
        //                finalResult.Append(" ");
        //                finalResult.Append(indexOfRows);
        //                finalResult.Append(" ");
        //                indexOfRows++;
        //            }

        //        }
        //        else if (i % charsPerLine == 0)
        //        {
        //             finalResult.Append(indexOfRows + " ");
        //             indexOfRows++;
        //        }

        //        finalResult.Append(result[i]);
        //        countLettersPerPair++;
        //        countLettersPerLine++;
        //        if (countLettersPerPair == charsPerPair && countLettersPerLine != charsPerLine)
        //        {
        //           finalResult.Append(" ");
        //            countLettersPerPair = 0;
        //        }
        //        if (countLettersPerLine == charsPerLine )
        //        {
        //            Console.WriteLine(finalResult);
        //            finalResult.Clear();
        //            countLettersPerLine = 0;
        //            countLettersPerPair = 0;
        //        }
               
        //    }
        //    Console.WriteLine(finalResult);
        //}

        private static void GenFinalResult(StringBuilder result, int charsPerLine, int charsPerPair)
        {
            int index = 0;
           int indexOfLine = 1;
           int lineLength = ((result.Length / charsPerLine) + 1).ToString().Length; 
           while (index < result.Length)
           {
               StringBuilder currentLine = new StringBuilder();
               currentLine.Append(indexOfLine.ToString().PadLeft(lineLength, ' ') + ' ');
               for (int i = 1; i <= charsPerLine; i++)
               {
                   currentLine.Append(result[index]);
                   index++;
                   if (index + 1 > result.Length || i == charsPerLine)
                   {
                       break;
                   }
                   if (i % charsPerPair == 0)
                   {
                       currentLine.Append(' ');
                   }

               }
               indexOfLine++;
               Console.WriteLine(currentLine);


           }

        }
        private static void ReadInput()
        {
            string numbers = Console.ReadLine();
            string[] numbersArr = numbers.Split(new char[] { ' ' });
            charsPerLine = int.Parse(numbersArr[0]);
            charsPerPair = int.Parse(numbersArr[1]);
            string theGenome = Console.ReadLine();
            Decode(theGenome, charsPerLine, charsPerPair);

        }

        private static void Decode(string theGenome, int charsPerLine, int charsPerPair)
        {
            Dictionary<int, char> dict = new Dictionary<int, char>();
            string countOfCurrentLetter = string.Empty;
            char currentLetter;
            for (int i = 0; i < theGenome.Length; i++)
            {
                if (char.IsDigit(theGenome[i]))
                {
                    countOfCurrentLetter += theGenome[i];
                }
                else
                {
                    currentLetter = theGenome[i];

                    GenDecodedGenome(currentLetter, countOfCurrentLetter);
                    countOfCurrentLetter = string.Empty;


                }
            }
        }

        private static void GenDecodedGenome(char currentLetter, string countOfCurrentLetter)
        {
            int numberOfRepetitions;
            if (countOfCurrentLetter == string.Empty)
            {
                numberOfRepetitions = 1;
            }
            else
            {
                numberOfRepetitions = int.Parse(countOfCurrentLetter);

            }
            for (int i = 0; i < numberOfRepetitions; i++)
            {
                result.Append(currentLetter);
            }

        }
    }
}
