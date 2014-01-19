using System;
//Write a program that generates and prints to the console 10 random values in the range [100, 200].
class RandomNumbers
{
    static void Main()
    {
        Random myRand = new Random();
        for (int i = 0; i < 10; i++)
        {
            Console.Write(myRand.Next(100, 201));
            Console.Write(' ');
        }
    }
}

