using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Home6
{
    internal class Program
    {
        static void Main(string[] args)
        {
           

            int idobject = 0;
            Console.WriteLine("Какую команду выполнить?");
            Console.WriteLine("Создать запись. Нажмите 1");
            Console.WriteLine("Прочитать записи. Нажмите 2");
            //Console.WriteLine("Удалить запись. Нажмите 3");

           
            while (true)
            {
                int userinput = int.Parse(Console.ReadLine());
                int Program = userinput;
                switch (Program)
                {
                    case 1:
                        {
                            int a=0;
                            using (StreamWriter sw = new StreamWriter("staff.data", true, Encoding.Unicode))
                            { }
                            using (StreamReader sr = new StreamReader("staff.data", Encoding.Unicode))

                            {
                                string line;

                                while ((line = sr.ReadLine()) != null)
                                {
                                    string[] data = line.Split('#');
                                    a = Convert.ToInt32( data[0]);
                                    
                                }
                            }

                            using (StreamWriter sw = new StreamWriter("staff.data", true, Encoding.Unicode))
                            {
                               

                                while (true)
                                {
                                    idobject =a+1 ;
                                    string note = string.Empty;
                                    Console.Write($"\n{idobject} ");
                                    note += $"{idobject}#";

                                    string date = DateTime.Now.ToLongDateString();
                                    string time = DateTime.Now.ToShortTimeString();
                                    Console.WriteLine($" {date} {time}");
                                    note += $"{date} {time}#";

                                    Console.WriteLine($"ФИО: ");
                                    note += $"{Console.ReadLine() }#";

                                    Console.Write("Возраст: ");
                                    note += $"{ Console.ReadLine() }#";

                                    Console.Write("Рост: ");
                                    note += $"{ Console.ReadLine() }#t";

                                    Console.Write("Дата рождения: ");
                                    note += $"{ Console.ReadLine() }#";

                                    Console.Write("Место рождения: ");
                                    note += $"{ Console.ReadLine() }#";


                                    sw.WriteLine(note);
                                    break;
                                }
                                Console.WriteLine("Для продолжения нажмите 1 или 2 чтобы прочить данные");
                            }
                            break;
                        }

                    case 2:
                        {
                            File.Exists(@"staff.data");
                            using (StreamReader sr = new StreamReader("staff.data", Encoding.Unicode))
                            {
                                string line;

                                while ((line = sr.ReadLine()) != null)
                                {
                                    string[] data = line.Split('#');
                                    Console.WriteLine($"\nid: {data[0]} \nдата:{data[1]} \nФИО:{data[2]} \nВозраст:{data[3]} \nРост:{data[4]} \nДата рождения: {data[5]} \nМесто рождения: {data[7]}");
                                    

                                }
                            }
                            break;
                        }
                        Console.ReadKey();
                   
                }
            }
        }
    }
}
