using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Massiv4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] array =
            {
            {1, 2, 3, 4},
            {5, 6, 7, 8},
            {9, 10, 11, 12},
            {13, 14, 15, 16}
            };
            int totalSum = CalculateTotalSum(array);
            Console.WriteLine($"1) Сумма всех элементов массива: {totalSum}");
            Console.WriteLine("2) Сумма в каждой строке:");
            CalculateRowSums(array);
            Console.WriteLine("3) Сумма в каждом столбце:");
            CalculateColumnSums(array);
            int diagonalSum1 = CalculateDiagonalSum1(array);
            int diagonalSum2 = CalculateDiagonalSum2(array);
            Console.WriteLine($"4) Сумма элементов в первой главной диагонали: {diagonalSum1}");
            Console.WriteLine($"   Сумма элементов во второй главной диагонали: {diagonalSum2}");
            Console.ReadKey();
        }

        static int CalculateTotalSum(int[,] array)
        {
            int sum = 0;
            foreach (int element in array)
            {
                sum += element;
            }
            return sum;
        }

        static void CalculateRowSums(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                int rowSum = 0;
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    rowSum += array[i, j];
                }
                Console.WriteLine($"   Сумма в строке {i + 1}: {rowSum}");
            }
        }

        static void CalculateColumnSums(int[,] array)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                int columnSum = 0;
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    columnSum += array[i, j];
                }
                Console.WriteLine($"   Сумма в столбце {j + 1}: {columnSum}");
            }
        }

        static int CalculateDiagonalSum1(int[,] array)
        {
            int sum = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                sum += array[i, i];
            }
            return sum;
        }

        static int CalculateDiagonalSum2(int[,] array)
        {
            int sum = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                sum += array[i, array.GetLength(0) - 1 - i];
            }
            return sum;
        }
    }
}
