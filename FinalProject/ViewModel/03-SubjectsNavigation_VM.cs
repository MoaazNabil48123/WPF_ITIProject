using FinalProject.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.ViewModel
{
    internal class SubjectsNavigation_VM:ViewModelBase
    {

        #region Property


        private static string _selectedSubject;
        public  string SelectedSubject 
        {
            get { return _selectedSubject; }
            set { _selectedSubject = value; OnPropertyChanged(); }
        }


        private object _currentView;
        public object CurrentView
        {
            get { return _currentView; }
            set { _currentView = value; OnPropertyChanged(); }
        }


        #endregion


        #region Commands

        public MyCommand ChangeSelectedSubjectCommand { get; set; }
        public MyCommand ForwardCommand { get; set; }
        public MyCommand BackwardCommand { get; set; }


        public void Forward(object parameter) { CurrentView = new FCO_Students_VM(SelectedSubject); }
        public void Backward(object parameter) { CurrentView = new Subjects_VM(); SelectedSubject = null; }
        public void ChangeSelectedSubject(object parameter) { SelectedSubject = parameter.ToString(); }





        #endregion

        public SubjectsNavigation_VM()
        {
            ForwardCommand = new MyCommand(Forward);
            BackwardCommand = new MyCommand(Backward);
            ChangeSelectedSubjectCommand = new MyCommand(ChangeSelectedSubject);

            CurrentView = new Subjects_VM();
        }
    }
}
