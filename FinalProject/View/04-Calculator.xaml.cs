using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

namespace FinalProject.View
{
    /// <summary>
    /// Interaction logic for Calculator.xaml
    /// </summary>
    public partial class Calculator : UserControl
    {




        public Calculator()
        {
            InitializeComponent();
        }

        private void zero_Click(object sender, RoutedEventArgs e)
        {
            equation.Text = equation.Text + "0";
        }

        private void one_Click(object sender, RoutedEventArgs e)
        {
            equation.Text = equation.Text + "1";
        }

        private void two_Click(object sender, RoutedEventArgs e)
        {
            equation.Text = equation.Text + "2";
        }

        private void three_Click(object sender, RoutedEventArgs e)
        {
            equation.Text = equation.Text + "3";
        }

        private void four_Click(object sender, RoutedEventArgs e)
        {
            equation.Text = equation.Text + "4";
        }

        private void five_Click(object sender, RoutedEventArgs e)
        {
            equation.Text = equation.Text + "5";
        }

        private void six_Click(object sender, RoutedEventArgs e)
        {
            equation.Text = equation.Text + "6";
        }

        private void seven_Click(object sender, RoutedEventArgs e)
        {
            equation.Text = equation.Text + "7";
        }

        private void eight_Click(object sender, RoutedEventArgs e)
        {
            equation.Text = equation.Text + "8";
        }

        private void nine_Click(object sender, RoutedEventArgs e)
        {
            equation.Text = equation.Text + "9";
        }

        private void sum_Click(object sender, RoutedEventArgs e)
        {
            if (equation.Text == "." || equation.Text == "" || equation.Text == null)
            {
                MessageBox.Show("syntax error");
            }
            else
            {
                equation.Text = equation.Text + " + ";

            }
        }

        private void subtract_Click(object sender, RoutedEventArgs e)
        {
            if (equation.Text == "." || equation.Text == "" || equation.Text == null)
            {
                MessageBox.Show("syntax error");
            }
            else
            {
                equation.Text = equation.Text + " - ";

            }
           
        }

        private void multiply_Click(object sender, RoutedEventArgs e)
        {
            if (equation.Text == "." || equation.Text == "" || equation.Text == null)
            {
                MessageBox.Show("syntax error");
            }
            else
            {

                equation.Text = equation.Text + " x ";
            }
            
        }

        private void division_Click(object sender, RoutedEventArgs e)
        {
            if (equation.Text == "." || equation.Text == "" || equation.Text == null)
            {
                MessageBox.Show("syntax error");
            }
            else
            {

                equation.Text = equation.Text + " / ";
            }
            
        }

        private void dot_Click(object sender, RoutedEventArgs e)
        {
            equation.Text = equation.Text + ".";
        }

        private void del_Click(object sender, RoutedEventArgs e)
        {
            equation.Text = equation.Text.Remove(equation.Text.Length - 1);
            result.Text = "";
        }

        private void clear_Click(object sender, RoutedEventArgs e)
        {
            equation.Text = "";
            result.Text = "";
        }

        private void equal_Click(object sender, RoutedEventArgs e)
        {
            string text = equation.Text.Replace("+ ", "- -");
            string[] arr1 = text.Split(new string[] { " - " }, StringSplitOptions.RemoveEmptyEntries);
            Stack<double> finalResult = new Stack<double>();
            finalResult.Push(-500000000);

            foreach (string s in arr1)
            {
                string[] arr2 = s.Split(' ');
                double result;
                if (arr2.Length > 1)
                {
                    double FNum = double.Parse(arr2[0]);
                    double SNum = double.Parse(arr2[2]);
                    string operation = arr2[1];
                    result = operation == "x" ? FNum * SNum : FNum / SNum;
                }
                else
                {
                    result = double.Parse(arr2[0]);
                }

                if (!(finalResult.Peek() == -500000000))
                {
                    finalResult.Push(finalResult.Pop() - result);
                }
                else
                {
                    finalResult.Pop();
                    finalResult.Push(result);

                }


            }

            result.Text = (finalResult.Pop()).ToString();





        }
    }
}
