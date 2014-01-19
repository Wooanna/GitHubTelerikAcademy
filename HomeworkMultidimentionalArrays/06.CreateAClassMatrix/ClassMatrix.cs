using System;
//* Write a class Matrix, to holds a matrix of integers. Overload the operators for adding, 
//subtracting and multiplying of matrices, indexer for accessing the matrix content and ToString().

namespace CreateAClassMatrix
{
    class ClassMatrix
    {
        static void Main()
        {
            Matrix newMatrix = new Matrix(2, 2);
            newMatrix[0, 0] = 2;
            newMatrix[0, 1] = 5;
            newMatrix[1, 0] = 2;
            newMatrix[1, 1] = 5;
            Console.WriteLine("First:");
            Console.WriteLine(newMatrix);

            Matrix myMatrix = new Matrix(2, 2);
            myMatrix[0, 0] = 2;
            myMatrix[0, 1] = 5;
            myMatrix[1, 0] = 2;
            myMatrix[1, 1] = 5;
            Console.WriteLine("Second:");
            Console.WriteLine(myMatrix); //using the overriden ToString()

            Matrix added = myMatrix + newMatrix;
            Console.WriteLine("Addition:");
            Console.WriteLine(added);

            Matrix multiplied = myMatrix * newMatrix;
            Console.WriteLine("Multiplication:");
            Console.WriteLine(multiplied);
        }
    }
}
