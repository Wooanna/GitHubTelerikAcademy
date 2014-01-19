using System;

namespace CreateAClassMatrix
{
    public class Matrix
    {
        //field
        private int[,] matrix;
        //constructor
        public Matrix(int rows, int cols)
        {
            this.matrix = new int[rows, cols];
        }

        public int Rows
        {
            get
            {
                return this.matrix.GetLength(0);
            }
        }

        public int Cols
        {
            get
            {
                return this.matrix.GetLength(1);
            }
        }

        public int this[int i, int j]
        {
            get
            {
                return this.matrix[i, j];
            }

            set
            {
                this.matrix[i, j] = value;
            }
        }

        //adding
        public static Matrix operator +(Matrix matrix1, Matrix matrix2)
        {
            if (matrix1.Rows != matrix2.Rows || matrix1.Cols != matrix2.Cols)
            {
                throw new ArgumentException("Error: The dimensions of the two matrices must be equal!");
            }

            Matrix result = new Matrix(matrix1.Rows, matrix1.Cols);
            for (int i = 0; i < matrix1.Rows; i++)
            {
                for (int j = 0; j < matrix1.Cols; j++)
                {
                    result[i, j] = matrix1[i, j] + matrix2[i, j];
                }
            }
            return result;
        }

        //multiplying
        public static Matrix operator *(Matrix matrix1, Matrix matrix2)
        {
            if (matrix1.Rows != matrix2.Rows || matrix1.Cols != matrix2.Cols)
            {
                throw new ArgumentException("Error: The dimensions of the two matrices must be equal!");
            }

            Matrix result = new Matrix(matrix1.Rows, matrix1.Cols);
            for (int i = 0; i < matrix1.Rows; i++)
            {
                for (int j = 0; j < matrix1.Cols; j++)
                {
                    result[i, j] = matrix1[i, j] * matrix2[i, j];
                }
            }
            return result;
        }

        //substracting
        public static Matrix operator -(Matrix matrix1, Matrix matrix2)
        {
            if (matrix1.Rows != matrix2.Rows || matrix1.Cols != matrix2.Cols)
            {
                throw new ArgumentException("Error: The dimensions of the two matrices must be equal!");
            }

            Matrix result = new Matrix(matrix1.Rows, matrix1.Cols);
            for (int i = 0; i < matrix1.Rows; i++)
            {
                for (int j = 0; j < matrix1.Cols; j++)
                {
                    result[i, j] = matrix1[i, j] - matrix2[i, j];
                }
            }
            return result;
        }

        public override string ToString()
        {
            string result = null;

            for (int rows = 0; rows < this.Rows; rows++)
            {
                for (int cols = 0; cols < this.Cols; cols++)
                {
                    result += matrix[rows, cols] + " ";
                }

                result += Environment.NewLine;
            }
            return result;
        }
    }
}
