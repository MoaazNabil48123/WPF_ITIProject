﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace FinalProject.Command
{
    internal class MyCommand : ICommand
    {


        #region Property

        public Action<object> Excute { get; set; }
        public Predicate<object> CanExcute { get; set; }

        #endregion

        #region Constructor

        public MyCommand(Action<object> excute , Predicate<object> canExcute =null )
        {
            Excute = excute;
            CanExcute = canExcute;
        }

        #endregion

        #region Interface Implementation

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            if (CanExcute==null)  { return true; }

            else { return CanExcute(parameter); }
        }

        public void Execute(object parameter)
        {
            Excute(parameter);
        }

        public void RaiseCanExecuteChanged()
        {
            CanExecuteChanged?.Invoke(this, EventArgs.Empty);
        }

        #endregion



    }
}
