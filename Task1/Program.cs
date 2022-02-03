using System;
using System.Linq;
using System.Collections.Generic;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, m;
            Console.WriteLine("Введите число элементов массива n");
            n = Convert.ToInt32(Console.ReadLine());
            int i, j;
            int[] a = new int[n];
            Console.Write("Массив: ", a);
            //заполнение массива по порядку
            for (i = 0; i < n; i++)
            {
                a[i] = i + 1;
                Console.Write(a[i] + " ");
            }
            Console.WriteLine();
            Array.Resize(ref a, 100);
            Console.Write("Круговой массив: ");
            int[] a1 = new int[100];
            for (i = 0; i < 100; i++)
            {
                j = i % n;
                a1[i] = a[j];
                Console.Write(a1[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Введите интервал длины m по заданному массиву");
            m = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nИнтервалы по длине обхода m: ");
            int[,] interval = new int[a1.Length/m, m];
            for (i = 0; i < a1.Length / m; i++)
            {
                for (j = 0; j < m; j++)
                {
                    int h = (i + j) % n;
                    interval[i, j] = a1[h];
                    Console.Write(interval[i, j] + " ");
                }
                if (interval[i, m - 1] == 1)
                    break;
                Console.WriteLine();                                   
            }
            Console.ReadKey(true);
            Console.WriteLine("\nПуть обхода массива: ");
            int[] way = new int[20];
            for (i = 0; i < interval.GetLength(0); i++)
            {
                way[i] = interval[i, 0];
                Console.Write(way[i] + "\t");
                if (way[i] == 0)
                    break;
            }
            Console.ReadKey();
        }
    }
}
