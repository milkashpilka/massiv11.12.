using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Massiv1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество строк:");
            int rows = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите количество столбцов:");
            int columns = int.Parse(Console.ReadLine());
            int[,] array = new int[rows, columns];
            Random random = new Random();
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    array[i, j] = random.Next(1, 101);
                }
            }
            Console.WriteLine("Двумерный массив:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write(array[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.ReadKey(); 
        }
    }
}

