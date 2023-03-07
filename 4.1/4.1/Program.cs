using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Сформировать массив из N случайных чисел от -5 до 5");
            //Console.WriteLine("Введите n:");
            //int n = int.Parse(Console.ReadLine());
            //Random random = new Random();

            //int[] numbs= new int[n];
            //for ( int i = 0; i < numbs.Length; i++)
            //{
            //    numbs[i]  = random.Next(-5, 6);
            //    Console.WriteLine($"{numbs[i]}");
            //}
            //Console.ReadKey();



            //Console.WriteLine("Сформировать массив N случайных чисел. Подсчитать количество четных чисел");
            //Console.WriteLine("Введите n:");
            //int n = int.Parse(Console.ReadLine());
            //var numbs = new int[n];
            //Random r = new Random();
            //int evenElement = 0;

            //for (int i = 0; i < numbs.Length; i++)
            //{
            //    numbs[i] = r.Next(10);
            //    Console.WriteLine($"{numbs[i]}");
            //    if (numbs[i] % 2 == 0) evenElement++;
            //}
            //Console.WriteLine($"\nЧётных: {evenElement}");
            //Console.ReadKey();  

            //Random random = new Random();
            //Console.WriteLine("Массив из n элементов состоит из нулей и едениц.\nПоставить нули в начало, а единицы в конец.");
            //Console.WriteLine("\nКол-во элементов: ");
            //int n = int.Parse(Console.ReadLine());
            //int[] numbs =new int[n];

            //Console.WriteLine("\nИсходный массив: ");

            //for (int i = 0; i < numbs.Length; i++)
            //{
            //    numbs[i] = random.Next(0,2);
            //    Console.WriteLine($"{numbs[i]}");

            //}
            //int head = 0;
            //int tail = numbs.Length - 1;
            //bool flag = true;

            //while (head < tail)
            //{
            //    if (flag)
            //    {
            //        if (numbs[head] == 1) flag = false;
            //        else head++;
            //    }
            //    else
            //    {
            //        if (numbs[tail] == 0) flag = true;
            //        else tail--;
            //    }
            //    if (numbs[head] == 1 && numbs[tail] == 0)
            //    {
            //        int temp = numbs[head];
            //        numbs[head] = numbs[tail];
            //        numbs[tail] = temp;

            //        head++;
            //        tail--;
            //    }
            //}
            //Console.WriteLine("\nПолучившийся массив:");
            //for (int i = 0; i < numbs.Length; i++)
            //{
            //    Console.WriteLine($"{numbs[i]}");
            //}
            //Console.ReadKey();
            //Console.WriteLine();
            //for (int i = 2; i < 10; i++)
            //{
            //    for(int j = 1; j < 10; j++)
            //    {
            //        Console.WriteLine($"{i} x {j} = {i * j}");
            //    }
            //    Console.WriteLine();
            //}

            //char[] symbols = { 'S', 'K', 'I', 'L' };
            //int count = 1;
            //for (int i = 0; i < symbols.Length; i++)
            //{
            //    for (int j = 0; j < symbols.Length; j++)
            //    {
            //        for (int k = 0; k < symbols.Length; k++)
            //        {
            //            for (int l = 0; l < symbols.Length; l++)
            //            {
            //                Console.WriteLine($"{count++,3}:{symbols[i]}{symbols[j]}{symbols[k]}{symbols[l]}");
            //            }
            //        }
            //    }
            //}

            //for (double a= 1;a<500;a++)
            //{
            //    for (double b= 1;b<500;b++)
            //    {
            //        if ((2*a*a*a+3*b*b)==8337)Console.WriteLine($"a={a}, b={b}");
            //    }
            //}
            //int count = 0;
            //for (int i = 0; i < 1000; i++)
            //{
            //    if (i % 2 == 0) continue;
            //        for (int j = 0; j < 1000; j++)
            //    {
            //       Console.WriteLine($"({i} {j}) ");
            //       count++;
            //    }
            //}
            //Console.WriteLine($"count = {count}");
            //Console.WriteLine("Кол-во строк: ");
            //int row = int.Parse(Console.ReadLine());
            //Console.WriteLine("Кол-во столбцов: ");
            //int col = int.Parse(Console.ReadLine());
            //int[,] matrix = new int[row, col];
            //matrix[1,2 ] = 3;
            //Random r = new Random();
            //for (int i = 0; i < 3; i++)
            //{
            //    for (int j = 0; j < 4; j++)
            //    {
            //        matrix[i, j] = r.Next(10);
            //        Console.WriteLine(matrix[i,j]);
            //    }
            //    Console.WriteLine();
            //}
            //Random r = new Random();
            //var z = new double[3, 3];
            //Console.WriteLine("исходная матрица z[3x3]:");
            //for (int i=0; i<z.GetLength(0); i++)
            //{
            //    for (int j=0; j<z.GetLength(1); j++)
            //    {
            //        z[i, j] = r.Next(1, 10);
            //        Console.WriteLine($"{z[i, j],6}");
            //    }
            //    Console.WriteLine();
            //}

            //Console.WriteLine("Матрица z[3x3] после преобразования:");
            //for (int i=0; i<z.GetLength(0); i++)
            //{
            //    double div = z[i, i];
            //    for (int j=0;j<z.GetLength(1); j++)
            //    {
            //        z[i, j] /= div;
            //        Console.WriteLine($"{z[i,j],6}");
            //    }
            //    Console.WriteLine();
            //}
            Console.ReadKey();
            Random r = new Random();
            var A = new int[4, 4];
            Console.WriteLine("исходная матрица A[4x4]");
            for (int i = 0; i < A.GetLength(0); i++)
            {
                int sum = 0;
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    A[i, j] = r.Next(1, 10);
                    sum += A[i, j];
                    Console.Write($"{A[i, j],2}");
                }
                Console.WriteLine($" : {sum}");
            }
            // 6D матрица
            //double[,,,,,] matrix6D = new double[30, 43, 55, 61, 10, 6];
            //Console.WriteLine($"matrix6D.Rank = {matrix6D.Rank}");

            //Console.WriteLine($"matrix6D.Legth = {matrix6D.Length}");

            //Console.WriteLine($"memory: {(matrix6D.Length * sizeof(double))}");
            //зубчатый массив

            //int[][] c = new int[3][];

            //c[0]=new int[2];
            //c[0][0] = 1;
            //c[0][1] = 3;
            //c[1]=new int[4];
            //c[1][0] = 1;
            //c[1][1] = 0;
            //c[1][2] = 3;
            //c[1][3] = 1;
            //c[2]=new int[3];
            //c[2][0] = 2;
            //c[2][1] = 0;
            //c[2][2] = 1;

            //for (int i = 0; i < c.Length; i++)
            //{
            //    for (int j = 0; j < c[i].Length; j++)
            //    {
            //        Console.WriteLine($"{c[i][j]}");
            //    }
            //    Console.WriteLine();
            //}
            //Random r = new Random();
            //int[][] dataTime = new int[24][];

            //for (int j = 0; j < dataTime.Length; j++)
            //{
            //    dataTime[j] = (j >= 9 && j < 21) ? new int[12] : new int[4];
            //}
            //for (int i=0; i < dataTime.Length; i++)
            //{
            //    for(int j=0; j < dataTime[i].Length; j++)
            //    {
            //        dataTime[i][j] = r.Next(20);
            //        Console.Write($"{dataTime[i][j],3}");
            //    }
            //    Console.WriteLine();
            //}

        }
    }
}
