using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Massiv5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите значение n:");
            if (!int.TryParse(Console.ReadLine(), out int n) || n <= 0)
            {
                Console.WriteLine("Некорректное значение для n. Пожалуйста, введите положительное целое число.");
                Console.ReadLine();
                return;
            }
            int[,] square = new int[n, n];
            Console.WriteLine("Введите элементы массива:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write($"Элемент [{i + 1},{j + 1}]: ");
                    if (!int.TryParse(Console.ReadLine(), out square[i, j]))
                    {
                        Console.WriteLine("Некорректный ввод. Пожалуйста, введите целое число.");
                        Console.ReadLine();
                        return;
                    }
                }
            }
            if (IsMagicSquare(square))
            {
                Console.WriteLine("Данный массив является магическим квадратом.");
            }
            else
            {
                Console.WriteLine("Данный массив не является магическим квадратом.");
            }
            Console.ReadLine(); 
        }

        static bool IsMagicSquare(int[,] square)
        {
            int n = square.GetLength(0);
            int rowSum = 0;
            for (int i = 0; i < n; i++)
            {
                int currentRowSum = 0;
                for (int j = 0; j < n; j++)
                {
                    currentRowSum += square[i, j];
                }

                if (i == 0)
                {
                    rowSum = currentRowSum;
                }
                else if (currentRowSum != rowSum)
                {
                    return false;
                }
            }
            for (int j = 0; j < n; j++)
            {
                int columnSum = 0;
                for (int i = 0; i < n; i++)
                {
                    columnSum += square[i, j];
                }

                if (columnSum != rowSum)
                {
                    return false;
                }
            }
            int mainDiagonalSum = 0;
            int antiDiagonalSum = 0;
            for (int i = 0; i < n; i++)
            {
                mainDiagonalSum += square[i, i];
                antiDiagonalSum += square[i, n - 1 - i];
            }
            return mainDiagonalSum == rowSum && antiDiagonalSum == rowSum;
        }
    }
}
