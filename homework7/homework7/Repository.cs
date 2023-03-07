using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework7
{
    struct Repository
    {
        /// <summary>
        /// массив в котором храняться данные
        /// </summary>
        private Worker[] workers;
        /// <summary>
        /// путь к файлу
        /// </summary>
        private string path;
        /// <summary>
        /// индекс  для указания позиции при добавлении рабочего
        /// </summary>
        int index;
        /// <summary>
        /// хранит заголовки
        /// </summary>
        string[] titles;

        /// <summary>
        /// конструктор
        /// </summary>
        /// <param name="Path"></param>
        public Repository(string Path)
        {
            this.path = Path;
            this.index = 0;
            this.titles = new string[5];
            this.workers = new Worker[2];
        }

        /// <summary>
        /// метод для увиличения массива (для хранения данных)
        /// </summary>
        /// <param name="Flag"></param>
        private void Resize(bool Flag)
        {
            if (Flag)
            {
                Array.Resize(ref this.workers, this.workers.Length * 2);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ConcreteWorker"></param>
        public void Add(Worker ConcreteWorker)
        {
            this.Resize(index>= this.workers.Length);
            this.workers[index] = ConcreteWorker;
            this.index++;
        }

        /// <summary>
        /// метод для загрузки данных из файла
        /// </summary>
        public void Load()
        {
            using (StreamReader sr = new StreamReader(this.path))
            {
                titles = sr.ReadLine().Split(',');

                while (!sr.EndOfStream)
                {
                    string[] args = sr.ReadLine().Split(',');

                    Add(new Worker(args[0], args[1], args[2], Convert.ToUInt32(args[3]), args[4]));
                }
            }
        }


        /// <summary>
        /// печать в консоль
        /// </summary>
        public void PrintDbToConsole()
        {
            Console.WriteLine($"{this.titles[0], 15} {this.titles[1], 15} {this.titles[2],15} {this.titles[3],10}");

            for(int i = 0; i < index; i++)
            {
                Console.WriteLine(this.workers[i].Print());
            }
        }

        /// <summary>
        /// Колличество сотрудников
        /// </summary>
        public int Count { get { return this.index; } }
    }
}
