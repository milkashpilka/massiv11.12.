using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Massiv3.v
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите значение n:");
            int n = int.Parse(Console.ReadLine());
            int[,] arrayC = new int[n, n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i % 2 == 0)
                    {
                        arrayC[i, j] = j + 1;
                    }
                    else
                    {
                        arrayC[i, j] = n - j;
                    }
                }
            }
            PrintArray(arrayC);
            Console.ReadKey();
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
            Console.ReadKey();
        }
    }
}

