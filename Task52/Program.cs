﻿// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

namespace SHomework7
{
    class Task52
    {
        static void Main(string[] args)
        {
            int m = new Random().Next(1, 11);
            int n = new Random().Next(1, 11);
            Console.WriteLine($"m -число строк = {m}, n - число столбцов = {n}");
            int[,] array = new int[m, n];
            Fill2dArray(array);
            Print2dArray(array);
            Console.WriteLine("Среднее арифметическое столбцов");
            SumColumnAverege(array);
        }

        static void Fill2dArray(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = new Random().Next(1, 10);
                }
            }
        }

        static void Print2dArray(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j] + "   ");
                }
                Console.WriteLine();
            }
        }
        static void SumColumnAverege(int[,] array)
        {
            double sum = 0;
            double count = array.GetLength(0);

            for (int i = 0; i < array.GetLength(1); i++)
            {
                for (int j = 0; j < array.GetLength(0); j++)
                {
                    sum = sum +array[j, i];

                }
                sum = Math.Round(sum/count, 1);
                Console.Write($"{sum} ");
            }
        }

    }
}