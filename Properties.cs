using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneralName
{
    class Student
    {
        private int grade;
        private int id;
        private string name;
        public int getGrade()
        {
            return this.grade;
        }
        public void setGrade(int value)
        {
            this.grade = value;
        }
        public string Name
        {
            set
            {
                if (string.IsNullOrEmpty(this.name))
                {
                    throw new Exception("Name cannot be null or empty");
                }
                this.name = value;
            }
            get
            {
                return string.IsNullOrEmpty(this.name) ? "No Name" : this.name;
            }
        }
        public int Id
        {
            set
            {
                if (value <= 0)
                {
                    throw new Exception("Student id cannot be negative!");
                }
                this.id = value;
            }
            get
            {
                return this.id;
            }
        }
        public override string ToString()
        {
            return "Student information: \n--------------------\nGrade: " + this.grade + "\nId: " + this.id;
        }
    }
    class Properties
    {
        static void Main(string[] args)
        {
            Student Example = new Student();
            Example.Id = 100;
            Example.setGrade(100);
            Console.WriteLine(Example.ToString());
            Console.Read();
        }
    }
}
