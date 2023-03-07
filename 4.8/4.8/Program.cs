using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //задание 1
            //Console.WriteLine("Введите кол-во строк:");
            //int line = int.Parse(Console.ReadLine());
            //Console.WriteLine("Введите кол-во столбцов:");
            //int columns = int.Parse(Console.ReadLine());
            //int sum = 0;
            //int[,] matrix = new int[line, columns];
            //Random r = new Random();
            //for (int i = 0; i < line; i++)
            //{

            //    for (int j = 0; j < columns; j++)
            //    {
            //        matrix[i, j] = r.Next(10);
            //        sum += matrix[i, j];
            //        Console.Write($"{matrix[i, j]}");
            //    }
            //    Console.WriteLine();

            //}
            //Console.WriteLine($"Сумма всех значений матрицы = {sum}");

            //задание 2
            //Console.WriteLine("Кол-во элентов в массиве:");
            //int n = int.Parse(Console.ReadLine());
            //int [] A = new int [n];
            //int min = int.MaxValue;

            //for (int i = 0; i < n; i++)
            //{
            //    Console.Write($"Введите {i + 1} число:");
            //    A[i] = int.Parse(Console.ReadLine());
            //    min = min > A[i] ? A[i] : min;
            //}
            //Console.WriteLine($"Минимальное число: {min}");

            //задание 3
            Console.WriteLine("Игра \"Угадай\"");
            Random random = new Random();

            int iiNumber = random.Next(1, 100);
            int count = 0;
            Console.WriteLine("Введите число:");
            
            while (1 == 1)
            {
                var userValue = Console.ReadLine();
                
                if (userValue == String.Empty)
                {
                    Console.WriteLine($"Загаданное число {iiNumber}. Кол-во попыток {count}");
                    break;
                }
                count++;
                int usserNumber = (int)Convert.ToDouble(userValue);

                if (iiNumber < usserNumber)
                {
                    Console.WriteLine("Загаданное число меньше");
                    
                }
                
                else if (iiNumber > usserNumber)
                {
                    Console.WriteLine("Загаданное число больше");
                    
                }

                else
                {
                    Console.WriteLine($"Загаданное число {iiNumber},попыток {count}");
                    break;
                }
                Console.WriteLine($"кол-во попыток {count}");
            }
            
        }
    }
}
