using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Massiv2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] array =
            {
            {1, 2, 3, 4},
            {5, 6, 7, 8},
            {9, 10, 11, 12}
            };
            Console.WriteLine("Введите номер строки для вывода (от 0 до " + (array.GetLength(0) - 1) + "):");
            int selectedRow = int.Parse(Console.ReadLine());

            if (selectedRow >= 0 && selectedRow < array.GetLength(0))
            {
                PrintRow(array, selectedRow);
            }
            else
            {
                Console.WriteLine("Некорректный номер строки.");
            }

            // Вывод любого указанного столбца
            Console.WriteLine("Введите номер столбца для вывода (от 0 до " + (array.GetLength(1) - 1) + "):");
            int selectedColumn = int.Parse(Console.ReadLine());

            if (selectedColumn >= 0 && selectedColumn < array.GetLength(1))
            {
                PrintColumn(array, selectedColumn);
            }
            else
            {
                Console.WriteLine("Некорректный номер столбца.");
            }

            Console.ReadLine(); // Чтобы консольное окно не закрылось сразу
        }

        static void PrintRow(int[,] array, int row)
        {
            Console.WriteLine($"Строка {row}:");
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write(array[row, j] + "\t");
            }
            Console.WriteLine();
        }

        static void PrintColumn(int[,] array, int column)
        {
            Console.WriteLine($"Столбец {column}:");
            for (int i = 0; i < array.GetLength(0); i++)
            {
                Console.WriteLine(array[i, column]);
            }
        }
    }
}

