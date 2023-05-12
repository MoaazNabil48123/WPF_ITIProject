using FinalProject.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.ViewModel
{
    internal class MainProj_VM:ViewModelBase
    {
		private object _currentView;

		public object CurrentView
		{
			get { return _currentView; }
			set { _currentView = value; OnPropertyChanged(); }
		}


		public MyCommand HomeCommand { get; set; }
		public MyCommand TeachersCommand { get; set; }
		public MyCommand SubjectsCommand { get; set; }
		//public MyCommand FirstSubjectCommand { get; set; }
        public MyCommand CalculatorCommand { get; set; }

		public void Home(object parameter) { CurrentView = new Home_VM(); }
		public void Teachers(object parameter) { CurrentView = new Teachers_VM(); }
		public void Subjects(object parameter) { CurrentView = new SubjectsNavigation_VM(); }
		//public void FirstSubject(object parameter) { CurrentView = new FirstSubjectStudents_VM(); }
        public void Calculator(object parameter) { CurrentView = new Calculator_VM(); }




        public MainProj_VM()
		{
			HomeCommand = new MyCommand(Home);
			TeachersCommand = new MyCommand(Teachers);
			SubjectsCommand = new MyCommand(Subjects);
			//FirstSubjectCommand = new MyCommand(FirstSubject);
            CalculatorCommand = new MyCommand(Calculator);

            CurrentView = new Home_VM();
		}
	}
}
