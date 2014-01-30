using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AAADOGE
{

    class Program
    {
        static int exits = 0;
        static void Main(string[] args)
        {
            int row, col;
            string[] rowCol = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            row = int.Parse(rowCol[0]);
            col = int.Parse(rowCol[1]);
            int[,] field = new int[row, col];
            bool[,] isChecked = new bool[field.GetLength(0), field.GetLength(1)];

            string[] food = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int foodRow = int.Parse(food[0]);
            int foodCol = int.Parse(food[1]);
            field[foodRow, foodCol] = 3;
            //something else
            int numberOfEnemies = int.Parse(Console.ReadLine());
            for (int i = 0; i < numberOfEnemies; i++)
            {
                string[] enemyPlace = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                int enemyRow = int.Parse(enemyPlace[0]);
                int enemyCol = int.Parse(enemyPlace[1]);
                field[enemyRow, enemyCol] = 1;
            }


            FindFood(0, 0, field);

            Console.WriteLine(exits);
            


        }

        static void FindFood(int row, int col, int[,] field)
        {
            if (row < 0 || row >= field.GetLength(0) || col < 0 || col >= field.GetLength(1) || field[row, col] == 1)
            {
                return;
            }


            if (field[row, col] == 3)
            {
                exits++;

            }

            FindFood(row + 1, col, field);
            FindFood(row, col + 1, field);

          
        }

       
    }
}
