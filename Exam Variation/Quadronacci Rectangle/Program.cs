using System;
using System.Numerics;
//нещо не успях да донатамъня печатането.. та тази задача не ми е много вървежна откъм печат. Иначе сметките работят.

    class QuadronacciRectangle
    {
        static void Main()
        {
            BigInteger firstNumber = int.Parse(Console.ReadLine());
            BigInteger secondNumber = int.Parse(Console.ReadLine());
            BigInteger thirdNumber = int.Parse(Console.ReadLine());
            BigInteger fourthNumber = int.Parse(Console.ReadLine());

            
            int rows = int.Parse(Console.ReadLine());
            int cols = int.Parse(Console.ReadLine());
            BigInteger fifthNumber = 0;
            int currentCol = cols;
            int currentRow = rows;

            
                    if (cols == 4)
                    {
                        Console.WriteLine(firstNumber + " " + secondNumber + " " + thirdNumber + " " + fourthNumber);
                    }
                    else
                    {
                        Console.Write(firstNumber + " " + secondNumber + " " + thirdNumber + " " + fourthNumber  + " " );
                    }

                    
                for (int row = 0; row <currentRow; row++)
                {
                    
                    

                    if (cols != 4)
                    {
                        if (row == 0)
                        {
                            currentCol = cols - 4;
                        }

                    }
                    
                    for (int col = 0; col < currentCol; col++)
                    {
                        fifthNumber = firstNumber + secondNumber + thirdNumber + fourthNumber;
                        firstNumber = secondNumber;
                        secondNumber = thirdNumber;
                        thirdNumber = fourthNumber;
                        fourthNumber = fifthNumber;
                        
                        if (col == 0)
                        {
                            Console.Write(fifthNumber);
                        }
                        else
                        {
                            Console.Write(" " + fifthNumber);
                        }
                    }
 currentCol = cols;
                   
                    
                    Console.WriteLine();
                }
            

        }
    }

