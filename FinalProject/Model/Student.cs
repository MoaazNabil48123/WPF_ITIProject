using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Model
{
    internal class Student
    {

        public string FName { get; set; }
        public string LName { get; set; }
        public int Grade { get; set; }

        public Student(string FName, string LName, int grade)
        {
            this.FName = FName;
            this.LName = LName;
            this.Grade = grade;
        }
    }
}
