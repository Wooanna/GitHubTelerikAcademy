using System;
//Write a program that finds the maximal increasing sequence in an array. Example: {3, 2, 3, 4, 2, 2, 4}  {2, 3, 4}.

class FindSequence
{
    static void Main()
    {
        Console.WriteLine("How long your array will be?");
        int n = int.Parse(Console.ReadLine());
        string  sequenceNumbers = "";  //here we collect the numbers in increasing sequence
        string maxSequenceNumbers = "";  
        int lenght = 1;    // save current lenght of sequence 
        int maxLenght = 0; //save max lenght of sequence
       
        int[] array = new int[n];        

        for (int i = 0; i < n; i++)
        {
            Console.Write("Cell[{0}] =", i);
            array[i] = int.Parse(Console.ReadLine()); //fill up the array
            Console.WriteLine();
        }

        //solution
        for (int i = 1; i < n; i++)
        {           
            if (array[i-1] < array[i])
            {   
                lenght++;
                sequenceNumbers += array[i - 1] + " " ;
                if (i == array.Length - 1)
                {
                    if (lenght > maxLenght)
                    {
                        maxLenght = lenght;
                        maxSequenceNumbers = sequenceNumbers; //store the sequence in the max
                        maxSequenceNumbers += array[i];
                    }
                }
            }
            else
            {    
                if (maxLenght < lenght) //collect increasing numbers, so we can print 'ém later
                {
                    maxLenght = lenght; 
                    lenght = 1; //get counter back to 1
                    sequenceNumbers += array[i - 1];
                    maxSequenceNumbers = sequenceNumbers; //store the sequence in the max
                    sequenceNumbers = " "; //get string empty
                }
            }
        }

        //print the extracted sequence
        Console.WriteLine("The sequence we are looking for in the current array is {0} cells long: ", maxLenght);

        Console.WriteLine("   {0}  ", maxSequenceNumbers);

    }
}