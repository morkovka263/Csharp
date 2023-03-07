using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework7
{
    internal partial class Program
    {
        static void Main(string[] args)
        {
            #region Массив
            //int[] income = new int[12];
            //int[] consumption = new int[12];
            //int[] arrived = new int[12];
            #endregion

            #region MonthlyReport

            //MonthlyReport[] report = new MonthlyReport[12];
            //report[0] = new MonthlyReport();
            ////{
            ////    Income = 111,
            ////    consuption = 32,
            ////    Month = "Январь";
            ////};
            //report[0].Month = "First";
            //report[0].Income = 123;
            //report[0].consumption = 23;
            //report[0].arrived = report[0].Income = report[0].consumption;

            #endregion

            #region Worked

            //Worker worker = new Worker();

            //worker.Position = "engen";
            //worker.FirstName = "Pidor";
            #endregion

            #region Dog
            //Dog dog = new Dog();
            //dog.Nickname = "Nikson";
            //dog.Breed = "PidorYshastii";

            #endregion

            #region Cat1

            //Cat1 cat1 = new Cat1("Шотландская", "Барсик");

            //Console.WriteLine(cat1.GetBreed());

            ////cat1.Breed = "Хуй";

            ////Console.WriteLine(cat1.Breed);

            #endregion

            #region Account1

            //Account1 account1 = new Account1("BigDick", "veryBig");
            //Console.WriteLine(account1.Login);

            //account1.SetPassword("My");

            #endregion


            #region Cat2

            //Cat2 cat2 = new Cat2() ;

            //cat2.Nickname = "Dick";
            //cat2.Breed = "big";

            //Console.WriteLine(cat2.Nickname);
            //cat2.Nickname = Console.ReadLine();
            //Console.WriteLine(cat2.Nickname);
            //cat2.EyeColor = "sss";
            #endregion

            #region db

            //Repository1 db1 = new Repository1(
            //    new Worker("Должность_1", 10000, "Имя_1"),
            //    new Worker("Должность_2", 10000, "Имя_2"),
            //    new Worker("Должность_3", 10000, "Имя_3"),
            //    new Worker("Должность_4", 10000, "Имя_4")
            //    );
            //Console.WriteLine(db1[0].Print());
            //string a = Console.ReadLine();



            //Console.WriteLine(db1[0]);

            #endregion


            #region
            string path = @"data.csv";

            Repository rep = new Repository(path);
            rep.Load();
            rep.PrintDbToConsole();
            Console.WriteLine(rep.Count);

            rep.Add(new Worker("111","111","111",111,"111"));

            Console.ReadKey();

            rep.PrintDbToConsole();
            Console.WriteLine(rep.Count);
            Console.ReadKey();
            #endregion
        }
    }
}
