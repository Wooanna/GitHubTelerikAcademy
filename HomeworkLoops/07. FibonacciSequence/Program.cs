using System;
using System.Numerics;
//Write a program that reads a number N and calculates the sum of the first N members of the sequence of Fibonacci:
//0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, …
//Each member of the Fibonacci sequence (except the first two) is a sum of the previous two members.

class FibonacciSequence
    {
        static void Main()
        {

            BigInteger N = int.Parse(Console.ReadLine());
            BigInteger FibonacciMember = 0;
            BigInteger FibonacciMemberTwo = 1;
            BigInteger sum = 0;

            for (int i = 1; i < N; i++)
            {
                FibonacciMember += FibonacciMemberTwo;
                FibonacciMemberTwo += FibonacciMember;
                Console.WriteLine(FibonacciMember);
                Console.WriteLine(FibonacciMemberTwo);
                sum = sum + FibonacciMember + FibonacciMemberTwo;

            }
            Console.WriteLine("The sum is: {0}", sum);
        }
    }

