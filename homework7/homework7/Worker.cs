using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework7
{
    struct Worker
    {
        #region Конструктор
        public Worker(string FirstName, string LastName, string Position, uint Salary , string Department )
        {
            this.firstName = FirstName;
            this.lastName = LastName;
            this.position = Position;
            this.salary = Salary;
            this.department = Department;
        }
        #endregion

        #region Метод
        public string Print()
        {
            return $"{this.firstName,15} {this.lastName,15} {this.department,15} {this.position,15} {this.salary,10}";
        }
        #endregion

        #region Свойсва
        /// <summary>
        /// Имя
        /// </summary>
        public string FirstName { get { return this.firstName; } set { this.FirstName = value; } }

        public string LastName { get { return this.lastName; } set { this.LastName = value; } }

        public string Position { get { return this.position; } set { this.position = value; } }

        /// <summary>
        /// Отдел
        /// </summary>
        public string Department { get { return this.department; } set { this.department = value; } }

        /// <summary>
        /// Оплата труда
        /// </summary>
        public uint Salary { get { return this.salary; } set { this.salary = value; } }

        public double HourRate
        {
            get
            {
                byte workingDays = 25;
                byte workingHours = 8;
                return ((double)Salary) / workingDays / workingHours;
            }
        }

        #endregion

        #region Поля


        private string firstName;
        private string lastName;
        private string department;
        private uint salary;
        private string position;
        #endregion
    }
}
