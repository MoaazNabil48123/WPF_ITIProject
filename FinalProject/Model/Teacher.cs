using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Model
{
    internal class Teacher
    {
        public string FName { get; set; }
        public string LName { get; set; }
        public int ID { get; set; }
        public int Age { get; set; }
        public int Salary { get; set; }
        public string Mobil { get; set; }
        public string Address { get; set; }
        public string Image { get; set; }
        public string Evaluation { get; set; }
        public string Subject { get; set; }

        public Teacher(string FName, string LName, int ID, int Age, int Salary, string Mobil, string Address, string Image, string Evaluation, string Subject)
        {
            this.FName = FName;
            this.LName = LName;
            this.ID = ID;
            this.Age = Age;
            this.Salary = Salary;
            this.Mobil = Mobil;
            this.Address = Address;
            this.Image = Image;
            this.Evaluation = Evaluation;
            this.Subject = Subject;
        }


        public Teacher (string FName)
        {
            this.FName = FName;
        }
    }
}
