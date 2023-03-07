using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_3._7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //                          while цикл
            // рандомные 10 значений
            //Random random = new Random();
            // int i = 0;
            // while (i < 10)
            // {
            //     Console.WriteLine($"{random.Next(-8, 10)}");
            //     i++;
            // }
            // Console.ReadKey();
            // подсчет квадратов 
            //Console.WriteLine("\nВведите start");
            //int start = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("\nВведите end");
            //int end = Convert.ToInt32(Console.ReadLine());
            //while (start < end)
            //{
            //    Console.WriteLine($"{start,4}^2 = {start * start}");
            //    start++;
            //}
            // среднее значение
            //double value;
            //double average = 0;
            //int i = 1;

            //while (i <=10)
            //{
            //    Console.WriteLine($"Введите {i}-й результат испытания:");
            //    value = double.Parse(Console.ReadLine());
            //    average += value;
            //    i++;
            //}
            //Console.WriteLine($"Среднее = {average / 10}");

            // Сокращение дробей
            Console.WriteLine("\nВведите numerator:"); 
            double numerator = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\nВведите denumerator:");
            double denuminator = Convert.ToDouble(Console.ReadLine());

            double a = numerator, b = denuminator;
            while (a != b )
            {
                if (a > b) a = a - b; b = b - a;
            }
            Console.WriteLine($"Можно сократить на {a}");
            Console.WriteLine($"Сокращенная дробь {numerator /a}/ {denuminator/b}");
        }
    }
}