using System;
using System.Collections.Generic;
//* Modify your last program and try to make it work for any number type, not just integer (e.g. decimal, float, byte, etc.). 
//Use generic method (read in Internet about generic methods in C#).

class ModifyExerciseWithGenericMethods
{
    static void Main()
    { 
        Menu();
      
    }

    static void Menu()
    {   
         Console.WriteLine("Enter 'G' to find greater value in sequence. \nEnter 'L' to find lower value in sequence. \nEnter 'P' to find product of a given sequence.\nEnter 'A' to find average value. ");
        string choise = Console.ReadLine();
       
        dynamic[] arrayOfNumbers = {3, 5, 6.66, 5,5, 5, 05, -11,1};
        
        switch (choise)
        {
            case "G": FindGreatest(arrayOfNumbers); 
                break;
            case "L": FindLowest(arrayOfNumbers);
                break;
            case "P": FindProduct(arrayOfNumbers);
                break;
            case "A": FindAverage(arrayOfNumbers);
                break;
            default:
                throw new ArgumentException("Invalid choise.");
        }
    }

    static void FindLowest<T>(params T[] numArray)
    {
        dynamic min = (dynamic)numArray[0];
        for (int i = 0; i < numArray.Length; i++)
        {
            if ((dynamic)numArray[i] < min)
            {
                min = numArray[i];
            }
        }
        Console.WriteLine("Minimum is: {0}", min);
    }

    static void FindGreatest<T>(params T[] numArray)
    {
        dynamic max = numArray[0];
        for (dynamic i = 0; i < numArray.Length; i++)
        {
            if ((dynamic)numArray[i] > max)
            {
                max = numArray[i];
            }
        }
        Console.WriteLine("Maximum is: {0}", max);

    }

    static void FindAverage<T>(params T[] numArray)
    {
        dynamic sum = 0;
        dynamic averageValue = 0;
        int divider = numArray.Length;
        for (int i = 0; i < numArray.Length; i++)
        {
            sum += (dynamic)numArray[i];
        }
        dynamic result = sum / divider;
        Console.WriteLine("Average value is: {0}",result);
    }

    static void FindProduct<T>(params T[] numArray)
    {
        dynamic result = 1;
        for (int i = 0; i < numArray.Length; i++)
        {
            result *= (dynamic)numArray[i];
        }
        Console.WriteLine("The product is: {0}",result);
    }


}

