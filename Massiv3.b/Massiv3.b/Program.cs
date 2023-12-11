using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Massiv3.b
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите значение n:");
            int n = int.Parse(Console.ReadLine());
            int[,] arrayB = new int[n, n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    arrayB[i, j] = j + 1;
                }
            }
            PrintArray(arrayB);
            Console.ReadLine();
        }

        static void PrintArray(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
