using NPOI.SS.Formula.Functions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project3._10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Задание 1
            //Console.WriteLine("\nВведите целое число:");
            //int n = int.Parse(Console.ReadLine());
            //for (; ; )
            //{

            //    if (n % 2 == 0)
            //    {

            //        Console.WriteLine($"Чётное");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Не чётное");
            //    }
            //    break;
            //}


            // Задание 2
            //Console.WriteLine($"Введите кол-во карт");
            //int num = int.Parse(Console.ReadLine());

            //int s = 0;

            //Console.WriteLine($"\nВалет(J)=10, Дама(Q)=10, Король(K)=10, Туз(T)=10");
            //for (int i = 1; i <= num; i++)
            //{

            //    Console.WriteLine($"\nВведите номинал карты: {i}");
            //    //s += int.Parse(Console.ReadLine());
            //    string cards = Console.ReadLine();

            //    switch (cards)
            //    {
            //        case "1":
            //            s = s + 1; break;

            //        case "2":
            //            s = s + 2; break;

            //        case "3":
            //            s = s + 3; break;

            //        case "4":
            //            s = s + 4; break;

            //        case "5":
            //            s = s + 5; break;

            //        case "6":
            //            s = s + 6; break;

            //        case "7":
            //            s = s + 7; break;

            //        case "8":
            //            s = s + 8; break;

            //        case "9":
            //            s = s + 9; break;

            //        case "J":
            //            s = s + 10; break;

            //        case "Q":
            //            s = s + 10; break;

            //        case "K":
            //            s = s + 10; break;

            //        case "T":
            //            s = s + 10; break;

            //    }
            //    Console.WriteLine($"\nСумма карт: {s}");
            //}
            //      задание 3
            //bool prost;
            //Console.WriteLine("Проверка простого числа");
            //int n = int.Parse(Console.ReadLine());
            //int i = 2;
            //int a = 0;

            //if (n != 1)
            //{


            //    while (i != n)
            //    {
            //        a = n % i;

            //        if (a > 0)
            //        {
            //            prost = true;
            //        }
            //        else
            //        {
            //            prost = false;
            //        }
            //        if (!prost)
            //        {
            //            Console.WriteLine($"Число {n} не простое");
            //            break;

            //        }
            //        i++;

            //    }
            //}
            //if (n == i | n==1)
            //{
            //    Console.WriteLine($"{n} число простое");
            //}
            Console.WriteLine("Введите целое число");
            int n =int.Parse(Console.ReadLine());
            int c = 1;
            bool prost = false;
            
            while (c<n-1)
            {
                c++;
                if (n%c==0)
                {
                    prost= true;
                    break;
                }
                else
                {
                    prost= false;
                    
                }
            }
            if (prost == true)
            {
                Console.WriteLine("число не простое");
            }
            else 
            {
                Console.WriteLine("число простое");
            }
        }
    }
}
