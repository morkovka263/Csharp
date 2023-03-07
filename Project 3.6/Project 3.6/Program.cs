using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_3._6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("вывод");
            //for (double i = 1; i >= -1; i-=0.5)
            //{
            //    Console.WriteLine($"{i}");
            //}

            //              вывод таблицы квадратов
            //Console.Write("\nВведите start:");
            //int start = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("\nВведите end:");
            //int end = Convert.ToInt32(Console.ReadLine());
            //for (int i = start; i <= end; i++)
            //{
            //    Console.WriteLine($"{i,4}^2 = {i * i}");
            //}

            //              вывод среднего числа
            //double value;
            //double average = 0;

            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine($"Введите {i}-й результат вступительного испытания:");
            //    value = double.Parse(Console.ReadLine());
            //    average += value;
            //}
            //Console.WriteLine($"Среднее = {average / 10}");

            //              сокращение дробей
            //Console.Write("\nВведите numerator:");
            //double numerator = Convert.ToDouble(Console.ReadLine());

            //Console.Write("\nВведите denumerator");
            //double denuminator = Convert.ToDouble(Console.ReadLine());

            //Console.WriteLine($"Исходная дробь {numerator}/{denuminator}");

            //double a = numerator, b = denuminator;

            //for (int i = 0; i < 100000; i++)
            //{
            //    if (a != b) if (a > b) a = a - b; else b = b - a;
            //}
            //Console.WriteLine($"Можно сократить на {a}");

            //Console.WriteLine($"Сокращенная дробь {numerator / a}/{denuminator/ a}");

            Console.WriteLine("Игра \"Угадай\"");
            Random random = new Random();
            
            int iiNumber = random.Next(1,100);
            int count =0;
            int usserNumber;
            
            for (; ; )
            {
                Console.WriteLine("\nВведите число:");
                count ++;
                usserNumber = Convert.ToInt32(Console.ReadLine());
                if (usserNumber < iiNumber)
                {
                    Console.WriteLine("Введенное число меньше загаданного. Попробуйте еще раз");
                }
                else if (usserNumber > iiNumber)
                {
                    Console.WriteLine("Введенное число больше загаданного. Попробуйте еще раз");
                }
                else
                {
                    Console.WriteLine($"Поздравляю, число угадано! число попыток {count}");
                    Console.ReadKey();
                    break;
                }
            }
        }
    }
}
