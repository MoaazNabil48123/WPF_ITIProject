using FinalProject.Command;
using FinalProject.Model;
using FinalProject.View;
using System.Collections.ObjectModel;

namespace FinalProject.ViewModel
{
    internal class Teachers_VM : ViewModelBase
    {

        #region Property
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

        public static ObservableCollection<Teacher> ListOfTeachers { get; set; }

        private Teacher _selectedItem;
        public Teacher SelectedItem
        {
            get { DeleteCommand.RaiseCanExecuteChanged(); return _selectedItem; }
            set { _selectedItem = value; DeleteCommand.RaiseCanExecuteChanged(); }
        }

        #endregion

        #region Commands

        public MyCommand AddCommand { get; set; }
        public MyCommand DeleteCommand { get; set; }
        public MyCommand SubmitCommand { get; set; }
        public MyCommand CancelCommand { get; set; }




        //Add Method
        public void Add(object parameter)
        {
            AddTeacherWin teacherWin = new AddTeacherWin();
            teacherWin.Show();

        }



        //delete method
        public void Delete(object parameter)
        {

            ListOfTeachers.Remove((Teacher)parameter);
        }
        public bool CanDelete(object parameter)
        {
            if (parameter == null) { return false; }
            else { return true; }
        }


        //Submit Method
        public void Submit(object parameter)
        {
            string imagecorrected = $"/Images/{Image}.png";
            ListOfTeachers.Add(new Teacher(FName, LName, ID, Age, Salary, Mobil, Address, imagecorrected, Evaluation, Subject));
            ((AddTeacherWin)parameter).Close();
        }

        public void Cancel(object parameter)
        {
            ((AddTeacherWin)parameter).Close();
        }

        #endregion


        #region Constructor

        //static Constructor
        static Teachers_VM()
        {
            ListOfTeachers = new ObservableCollection<Teacher>() { new Teacher("Ken", "Kettler", 1821, 43, 7000, "01154370512", "1178 Fieldcrest Road,New York, NY 10011", "/Images/1.jpeg", "91%", "Python"),
                                                                   new Teacher("Hector ", "Hopkins", 1822, 33, 6000, "01154332412", "1169 Pyramid Valley, RoadMount Auburn, IA 52313", "/Images/2.jpeg", "93%", "Networks"),
                                                                   new Teacher("Sam ", "Juhl", 1823, 23, 4500, "01554370124", "1315 Walnut Avenue,Rochelle Park, NJ 07662", "/Images/3.jpeg", "95%", "HTML & CSS"),
                                                                   new Teacher("Todd ", "Rodrigues", 1824, 31, 5500, "01254370953", "4499 Goosetown Drive, Lenoir, NC 28638", "/Images/4.jpeg", "92%", "BIM"),
                                                                   new Teacher("Jim ", "Spivey", 1825, 38, 7000, "01054370471", "1884 Fairfax Drive, Weehawken, NJ 07087", "/Images/5.jpeg", "96%", "C#")      };


        }



        //instance Constructor
        public Teachers_VM()
        {

            AddCommand = new MyCommand(Add);
            DeleteCommand = new MyCommand(Delete);
            SubmitCommand = new MyCommand(Submit);
            CancelCommand = new MyCommand(Cancel);


        }

        #endregion




    }
}
