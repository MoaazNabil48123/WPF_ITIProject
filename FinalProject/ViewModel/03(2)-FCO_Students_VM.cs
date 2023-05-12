using FinalProject.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;

namespace FinalProject.ViewModel
{
    internal class FCO_Students_VM:ViewModelBase
    {
        public static string SelectedSubject { get; set; }
        public ObservableCollection<Student> ListOfStudents { get; set; }




        public FCO_Students_VM()
        {
            switch (SelectedSubject)
            {
                case "Database":
                    ListOfStudents = new ObservableCollection<Student>() { new Student("Ken", "Kettler", 98)
                                                                  ,new Student("Hector", "Hopkins", 92)
                                                                  ,new Student("Sam", "Juhl", 99 )
                                                                  ,new Student("Todd", "Rodrigues", 93)
                                                                  ,new Student("Jim", "Spivey", 95)
                                                                  ,new Student("Elan", "Hopkins", 92)
                                                                  ,new Student("Wuyi", "Juhl", 99 )
                                                                  ,new Student("Raiden", "Kim", 93)
                                                                  ,new Student("Nico", "Larson", 95)};
                    break;


                case "Networks":
                    ListOfStudents = new ObservableCollection<Student>() { new Student("Ken", "Kettler", 98)
                                                                  ,new Student("Hector ", "Hopkins", 92)
                                                                  ,new Student("Sam ", "Juhl", 99 )
                                                                  ,new Student("Todd ", "Rodrigues", 93)
                                                                  ,new Student("Jim ", "Spivey", 95)
                                                                };
                    break;

                case "HTML":
                    ListOfStudents = new ObservableCollection<Student>() { new Student("Ken", "Kettler", 98)
                                                                  ,new Student("Hector ", "Hopkins", 92)
                                                                  ,new Student("Juhl ", "Sam", 99 )
                                                                  ,new Student("Todd ", "Juhl", 93)
                                                                  ,new Student("Spivey ", "Sam", 95)
                                                                  ,new Student("Hector ", "Hopkins", 92)
                                                                  ,new Student("Sam ", "Juhl", 99 )
                                                                  ,new Student("Todd ", "Rodrigues", 93)
                                                                  ,new Student("Jim ", "Spivey", 95)};
                    break;

                case "CSS":
                    ListOfStudents = new ObservableCollection<Student>() { new Student("Ken", "Kettler", 98)
                                                                  ,new Student("Spivey ", "Hopkins", 92)
                                                                  ,new Student("Sam ", "Spivey", 99 )
                                                                  ,new Student("Todd ", "Rodrigues", 93)
                                                                  ,new Student("Jim ", "Spivey", 95)
                                                                  ,new Student("Hector ", "Hopkins", 92)
                                                                  ,new Student("Hector ", "Juhl", 99 )
                                                                  ,new Student("Todd ", "Sam", 93)          
                                                                  ,new Student("Hector ", "Hopkins", 92)
                                                                  ,new Student("Hector ", "Juhl", 99 )
                                                                  ,new Student("Todd ", "Sam", 93)
                                                                  ,new Student("Spivey ", "Spivey", 95)};
                    break;

                case "Java Script":
                    ListOfStudents = new ObservableCollection<Student>() { 
                                                                  new Student("Sam ", "Juhl", 99 )
                                                                  ,new Student("Hector ", "Hopkins", 92)
                                                                  ,new Student("Hector ", "Hopkins", 92)
                                                                  ,new Student("Todd ", "Rodrigues", 93)
                                                                  ,new Student("Ken", "Kettler", 98)
                                                                  ,new Student("Sam ", "Juhl", 99 )
                                                                  ,new Student("Jim ", "Spivey", 95)
                                                                  ,new Student("Sam ", "Juhl", 99 ) 
                                                                  ,new Student("Todd ", "Rodrigues", 93)
                                                                  ,new Student("Sam ", "Juhl", 99 )
                                                                  ,new Student("Jim ", "Spivey", 95)
                                                                  ,new Student("Hector ", "Hopkins", 92)
                                                                  ,new Student("Todd ", "Rodrigues", 93)
                                                                  ,new Student("Jim ", "Spivey", 95)};
                    break;

                case "Python":
                    ListOfStudents = new ObservableCollection<Student>() { new Student("Ken", "Kettler", 98)
                                                                  ,new Student("Hector ", "Hopkins", 92)
                                                                  ,new Student("Sam ", "Juhl", 99 )
                                                                  ,new Student("Todd ", "Rodrigues", 93)
                                                                  ,new Student("Jim ", "Spivey", 95) };
                    break;

                case "C#":
                    ListOfStudents = new ObservableCollection<Student>() { 
                                                                   new Student("Todd ", "Rodrigues", 93)
                                                                  ,new Student("Sam ", "Juhl", 99 )
                                                                  ,new Student("Ken", "Kettler", 98)
                                                                  ,new Student("Jim ", "Spivey", 95)
                                                                  ,new Student("Hector ", "Hopkins", 92)
                                                                  ,new Student("Hector ", "Hopkins", 92)
                                                                  ,new Student("Sam ", "Juhl", 99 )
                                                                  ,new Student("Todd ", "Rodrigues", 93)
                                                                  ,new Student("Jim ", "Spivey", 95)};
                    break;

                case "WPF":
                    ListOfStudents = new ObservableCollection<Student>() {
                                                                   new Student("Todd ", "Rodrigues", 93)
                                                                  ,new Student("Ken", "Kettler", 98)
                                                                  ,new Student("Sam ", "Juhl", 99 )
                                                                  ,new Student("Jim ", "Spivey", 95)
                                                                  ,new Student("Hector ", "Hopkins", 92)
                                                                  ,new Student("Hector ", "Hopkins", 92)
                                                                  ,new Student("Sam ", "Juhl", 99 )
                                                                  ,new Student("Todd ", "Rodrigues", 93)
                                                                  ,new Student("Jim ", "Spivey", 95)};
                    break;

                case "O.S":
                    ListOfStudents = new ObservableCollection<Student>() { new Student("Ken", "Kettler", 98)
                                                                  ,new Student("Hector ", "Hopkins", 92)
                                                                  ,new Student("Sam ", "Juhl", 99 )
                                                                  ,new Student("Todd ", "Rodrigues", 93)
                                                                  ,new Student("Jim ", "Spivey", 95)
                                                                  ,new Student("Hector ", "Hopkins", 92)
                                                                  ,new Student("Sam ", "Juhl", 99 )
                                                                  ,new Student("Todd ", "Rodrigues", 93)
                                                                  ,new Student("Hector ", "Hopkins", 92)
                                                                  ,new Student("Sam ", "Juhl", 99 )
                                                                  ,new Student("Todd ", "Rodrigues", 93)
                                                                  ,new Student("Jim ", "Spivey", 95)
                                                                  ,new Student("Hector ", "Hopkins", 92)
                                                                  ,new Student("Sam ", "Juhl", 99 )
                                                                  ,new Student("Todd ", "Rodrigues", 93)
                                                                  ,new Student("Jim ", "Spivey", 95)};
                    break;

                case "BIM":
                    ListOfStudents = new ObservableCollection<Student>() { new Student("Ken", "Kettler", 98)
                                                                  ,new Student("Hector ", "Hopkins", 92)
                                                                  ,new Student("Sam ", "Juhl", 99 )
                                                                  ,new Student("Todd ", "Rodrigues", 93)
                                                                  ,new Student("Jim ", "Spivey", 95)
                                                                  ,new Student("Hector ", "Hopkins", 92)
                                                                  ,new Student("Sam ", "Juhl", 99 )
                                                                  ,new Student("Todd ", "Rodrigues", 93)
                                                                  ,new Student("Jim ", "Spivey", 95)};
                    break;


            }

        }





        public FCO_Students_VM(string selectedSubject )
        {
            SelectedSubject = selectedSubject;

        }


    }
}
