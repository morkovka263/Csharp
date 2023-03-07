using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace HomeWork6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //DateTime dateTime = DateTime.Now;
            //Console.WriteLine(Math.Round(1.45654,2));
            //int a = Convert.ToInt32 (Console.ReadLine());
            //int b = Convert.ToInt32 (Console.ReadLine());
            //Console.WriteLine(Math.Min(a, b));
            //Console.WriteLine(Math.Max(a, b));
            //int r = Convert.ToInt32 (Console.ReadLine());
            //double s = Math.PI * Math.Pow(r, 2); Console.WriteLine(s);

            //double sum = 0;

            //for (int k=0; k<= 1000000000; k++)
            //{
            //    sum += k;
            //}
            //Console.WriteLine(sum);
            //TimeSpan timeSpan = DateTime.Now.Subtract(dateTime);
            //Console.WriteLine($"timeSpan.TotalMilliseconds = {timeSpan.TotalMilliseconds}");
            //Console.ReadKey();
            //string x = "God of war";
            //Console.WriteLine($"x = {x}");
            //Console.WriteLine($"x.IndexOf('w') = {x.IndexOf('w')}");
            //Console.WriteLine($"x.LastIndexOf('w') = {x.LastIndexOf('w')}");
            //string s = x.Insert(x.IndexOf(' ') + 4 , "fuckin ");
            //Console.WriteLine($"s = {s}");
            //char[] symbols = "God of War".ToCharArray ();
            //foreach (var item in symbols) Console.WriteLine($"{item}");
            //string v = new String (symbols);
            //string[] lines = File.ReadAllLines(@"z:\2.txt");
            //foreach (var line in lines) Console.WriteLine($">>{line}<<");


            /// ЧТЕНИЕ И ЗАПИСЬ ДИРЕКТОРИЙ В ФАЙЛ
            //var dirs = new DirectoryInfo(@"d:\").GetDirectories();

            //StreamWriter streamWriter = new StreamWriter("dDirs.txt");

            //foreach (DirectoryInfo dir in dirs)
            //{
            //    streamWriter.WriteLine(dir.FullName);
            //    Console.WriteLine($">>{dir.FullName}");
            //}

            //streamWriter.Close();

            //using (StreamWriter sw = new StreamWriter("fDirs.txt"))
            //{

            //    foreach (DirectoryInfo dir in dirs)
            //    {
            //        sw.WriteLine(dir.FullName);
            //    }
            //}

            //using (StreamReader sr = new StreamReader("cDirs.txt"))
            //{
            //    while (!sr.EndOfStream)
            //    {
            //        Console.WriteLine(sr.ReadLine());
            //    }
            //    Console.ReadKey();
            //}

            ///Создание заметок и их чтение

            //using (StreamWriter sw = new StreamWriter("db.csv",true, Encoding.Unicode))
            //{
            //    char key = 'д';

            //    do
            //    {
            //        string note = string.Empty;
            //        Console.Write("\nВведите имя автора записи: ");
            //        note+= $"{ Console.ReadLine() }\t";

            //        string now = DateTime.Now.ToShortTimeString();
            //        Console.WriteLine($"Время заметки {now}");
            //        note += $"{now}\t";

            //        Console.Write("Введите описание заметки: ");
            //        note += $"{ Console.ReadLine() }\t";
            //        sw.WriteLine(note);
            //        Console.Write("Продолжить н/д"); key = Console.ReadKey(true).KeyChar;
            //    }while (char.ToLower(key) == 'д');
            //}


            //using (StreamReader sr = new StreamReader("db.csv", Encoding.Unicode))
            //{
            //    string line;
            //    Console.WriteLine($"{"Автор",15}{" Время",8}{" Описание"}");

            //    while ((line = sr.ReadLine()) != null)
            //    {
            //        string[] data = line.Split('\t');
            //        Console.WriteLine($"{data[0],15}{data[1],8} {data[2]}");
            //    }
            //}


            ///Запись массива в файл в бинарном виде

            //Console.WriteLine($"Нажмите Enter для продолжения\n");

            //Console.ReadKey(); Console.Clear();

            //string[] names = { "Юлия", "Ирина", "Светлана", "Алиса" };
            //string path = @"BinaryNames.dat";

            //using (BinaryWriter writer = new BinaryWriter(File.Open(path, FileMode.OpenOrCreate)))
            //{
            //    foreach (var name in names)
            //    {
            //        writer.Write(name);
            //    }
            //}
            //Console.WriteLine($"Файл {path} успешно создан. Нажмите Enter для продолжения\n ");
            //Console.ReadLine();

            //using (BinaryReader reader = new BinaryReader(File.Open(path, FileMode.Open)))
            //{
            //    while (reader.PeekChar() > -1 )
            //    {
            //        string name = reader.ReadString();
            //        Console.WriteLine(name);
            //    }
            //}

            //////string path = @"E:\Games\Grand Theft Auto Vice City The Definitive Edition\Gameface\Content\rageunreal\gtavc\metadata.dat";
            //////using (BinaryReader reader = new BinaryReader(File.Open(path,FileMode.Open)))
            //////{
            //////    while (reader.PeekChar() > -1)
            //////    {
            //////        string name = reader.ReadString();
            //////        Console.WriteLine(name);
            //////    }
            //////}
            ///

            //// FileStream работа с файлами любого типа

            Console.WriteLine($"Нажмите Enter для продолжения");

            Console.ReadKey();Console.Clear();
            Console.WriteLine("Введите строку: ");
            string text = Console.ReadLine();

            using (FileStream fstream = new FileStream(@"Fuck.txt", FileMode.Create))
            {
                byte[] array = System.Text.Encoding.Default.GetBytes(text);
                fstream.Write(array, 0, array.Length);
            }

            using (FileStream fstream = File.OpenRead(@"fuck.txt"))
            {
                byte[] array = new byte[fstream.Length];

                fstream.Read(array, 0, array.Length);

                text = System.Text.Encoding.Default.GetString(array);
                Console.WriteLine($"Текст: {text}");
            }
            Console.ReadLine();
        }
    }
}
