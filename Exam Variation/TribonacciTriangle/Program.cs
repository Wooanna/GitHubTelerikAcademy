using System;
using System.Numerics;


    class TribonacciTriangle
    {
        static void Main()
        {
            BigInteger inputNumber = int.Parse(Console.ReadLine());
            BigInteger inputNumberTwo = int.Parse(Console.ReadLine());
            BigInteger inputNumberTree = int.Parse(Console.ReadLine());
            
            

            int lines = int.Parse(Console.ReadLine());
            BigInteger nextNumberGenerated = 0;
            
            Console.WriteLine(inputNumber);
            Console.WriteLine(inputNumberTwo + " " + inputNumberTree);
            

            

            


            for (int i = 3; i <= lines ; i++)
            {
                    for (int j = 0 ; j < i ; j++)
                {      
                   nextNumberGenerated = inputNumber + inputNumberTwo + inputNumberTree;
            
                    inputNumber = inputNumberTwo;
                    
                    inputNumberTwo = inputNumberTree;
                   
                    inputNumberTree = nextNumberGenerated;
                    
                    if (j < i-1)
                    {
                        Console.Write("{0} ", nextNumberGenerated);
                    }
                    else
                    {
                        Console.Write("{0}", nextNumberGenerated);
                    }



                        
                }
                    Console.WriteLine();
            }

        }
    }

