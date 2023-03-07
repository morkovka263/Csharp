using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace SampleProject
{
    public static class Program1
    {
        public static void Main(string[] args)
        {
            var Fullname1 = "Савченко Владимир Николаевич";
            var Fullname2 = "Лейц Дарья Дмитриевна";
            var age1 = 21;
            var age2 = 19;
            var mail1 = "abdc@mail.ru";
            var mail2 = "vbfd@mail.ru";
            var balsinfo1 = 22.1;
            var balsinfo2 = 45.5;
            var balsmath1 = 48.6;
            var balsmath2 = 19.7;
            var balsphysics1 = 38.33;
            var balsphysics2 = 22.14;

            string pattern1 = "ФИО: {0} \nВозраст: {1} \nПочта: {2} \nБаллы Информатика: {3} \nЬаллы Математика: {4} \nБаллы Физика:{5}"; 
            Console.WriteLine(pattern1,
                              Fullname1,
                              age1,
                              mail1,
                              balsinfo1,
                              balsmath1,
                              balsphysics1);
            Console.ReadKey();
            double averageBals1 = (balsinfo1 + balsmath1 + balsphysics1)/3;
            Console.WriteLine("\nСреднее кол-во баллов:");
            Console.WriteLine(averageBals1);
            Console.ReadKey();

            string pattern2 = "\nФИО: {0} \nВозраст: {1} \nПочта: {2} \nБаллы Информатика: {3} \nЬаллы Математика: {4} \nБаллы Физика:{5}";
            Console.WriteLine(pattern2,
                              Fullname2,
                              age2,
                              mail2,
                              balsinfo2,
                              balsmath2,
                              balsphysics2);
            Console.ReadKey();
            double averageBals2 = (balsinfo2 + balsmath2 + balsphysics2) / 3;
            Console.WriteLine("\nСреднее кол-во баллов:");
            Console.WriteLine(averageBals2);
            Console.ReadKey();
        }
    }
}
