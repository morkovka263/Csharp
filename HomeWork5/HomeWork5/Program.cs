using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork5
{
    internal class Program
    {
        //Задание1 и 2
        static string[] SplitText(string text)
        {
            return text.Split(' ');
        }

        static string[] ReverseText(string text)
        {
            string[] texts = SplitText(text);
            Array.Reverse(texts);
            return texts;
        }

        static void PrintArray(string[] Array)
        {
            foreach (string s in Array)
            {
                Console.WriteLine(s);
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите предложение:\n");
            string result =Console.ReadLine();
            
            PrintArray(SplitText(result));

            Console.WriteLine("\nОбратный порядок слов:\n");
            PrintArray(ReverseText(result));
            Console.ReadKey();
        }
      


    }
}
