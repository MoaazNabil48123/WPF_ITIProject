using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace FinalProject.View
{
    /// <summary>
    /// Interaction logic for AddTeacherWin.xaml
    /// </summary>
    public partial class AddTeacherWin : Window
    {
        public AddTeacherWin()
        {
            InitializeComponent();
            
            submitButton.CommandParameter = this;
            CancelButton.CommandParameter = this;
        }
    }
}
