using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = new int[2, 2];
            matrix[1,1] = 2;
            matrix[0, 0] = 2;
            for (int i = 0; i < matrix.GetLength(1); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    System.Console.Write($"{matrix[i, j]} ");
                }
                System.Console.WriteLine();
            }
        }
    }
}
//Написать программу, выводящую элементы двухмерного массива по диагонали