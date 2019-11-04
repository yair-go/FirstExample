using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstExample
{
    class Student
    {
        #region Fields
        private string name;
        private int id;
        private DateTime birthday;
        #endregion

        #region Ctors
        public Student(string name = "" , int id = 1, int year = 1970, int month = 1, int day = 1 )
        {
            this.name = name;
            this.id = id;
            this.birthday = new DateTime(year, month, day);
        }

        public Student(string name, int id, DateTime birthday )
        {
            this.name = name;
            this.id = id;
            this.birthday = birthday;
        }
        #endregion

        #region Properties
        public string Name
        {
            set { name = value; }
            get { return name; }
        }

        public int Id { get => id;}

        public DateTime Birthday { get; }
        public int Age
        {
            get { return DateTime.Now.Year - birthday.Year; }
        }
        #endregion

        #region Methods

        public override string ToString()
        {
            return Name + " " + Age;
        }


        #endregion
    }
}
