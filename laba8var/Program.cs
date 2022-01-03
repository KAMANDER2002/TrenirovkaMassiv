using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace laba8var
{
    class Program
    {
        static void Main(string[] args)
        {
            var matrix = new int[9, 9];
            var rnd = new Random();
            Console.WriteLine("Исходные значения" + Environment.NewLine);
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = rnd.Next(12, 45);
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine(Environment.NewLine + "Значения по убыванию" + Environment.NewLine);

            var arr = matrix.Cast<int>().OrderByDescending(a => a).ToArray();

            int c = 0;
            for (int j = 0; j < matrix.GetLength(0); j++)
            {
                for (int k = 0; k < matrix.GetLength(1); k++)
                {
                    matrix[j, k] = arr[c];
                    Console.Write(matrix[j, k] + " ");
                    c++;
                }
                Console.WriteLine();
            }
            Console.WriteLine(Environment.NewLine + "Значения по возрастанию" + Environment.NewLine);
            var arrayPlus = matrix.Cast<int>().OrderBy(a => a).ToArray();

            int d = 0;
            for (int j = 0; j < matrix.GetLength(0); j++)
            {
                for (int k = 0; k < matrix.GetLength(1); k++)
                {
                    matrix[j, k] = arrayPlus[d];
                    Console.Write(matrix[j, k] + " ");
                    d++;
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
