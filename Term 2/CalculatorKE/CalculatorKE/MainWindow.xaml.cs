/*
Karter Ence
Calculator
11/10/2020
*/
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Annotations;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CalculatorKE
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        double operand1;
        double operand2;
        String operation;

        public MainWindow()
        {
            InitializeComponent();
        }

        public double radiusOfCircle()
        {
            double x = 0.0;
            double pi = Math.PI;
            double r = double.Parse(screen.Text);
            x = pi * r;
            x = x * r;
            MessageBox.Show(x.ToString());

            return x;
        }

        private void numClick(object sender, RoutedEventArgs e)
        {
            String text = "";
            Button button = (Button)sender;
            if (screen.Text != "0" & screen.Text != "+" & screen.Text != "-" 
                & screen.Text != "*" & screen.Text != "/" & screen.Text !="^")
            {
                text = screen.Text;
            }

            if (button.Content.ToString() == "π")
            {
                text = Math.PI.ToString();
            }
            else if (button.Content.ToString() == "e")
            {
                text = Math.E.ToString();
            }
            else
            {
                text += button.Content.ToString();
            }
            
            screen.Text = text;
        }

        private void num2_Click(object sender, RoutedEventArgs e)
        {

        }

        private void operatorClick(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            
            operand1 = Convert.ToDouble(screen.Text);

            if (button.Content.ToString() == "x^y")
            {
                operation = "pow";
                screen.Text = "^";
            }
            else
            {
                operation = button.Content.ToString();
                screen.Text = operation;
            }
        }

        private void clr_Click(object sender, RoutedEventArgs e)
        {
            operand1 = 0;
            operand2 = 0;
            operation = "";
            screen.Text = "0";
        }

        private void equal_Click(object sender, RoutedEventArgs e)
        {
            operand2 = Convert.ToDouble(screen.Text);
            if (operation == "+")
            {
                double ans = operand1 + operand2;
                screen.Text = ans.ToString();
            }
            else if(operation == "-")
            {
                double ans = operand1 - operand2;
                screen.Text = ans.ToString();
            }
            else if(operation == "*")
            {
                double ans = operand1 * operand2;
                screen.Text = ans.ToString();
            }
            else if(operation == "/")
            {
                if (operand2 == 0)
                {
                    MessageBox.Show("Did you just try to divide by zero? You're not clever or anything.");
                    return;
                }
                double ans = operand1 / operand2;
                screen.Text = ans.ToString();
            }
            else if (operation == "pow")
            {
                double ans = Math.Pow(operand1, operand2);
                screen.Text = ans.ToString();
            }
            else
            {
                MessageBox.Show("You know you have to select a mathematical operator, right?\nMoron.");
            }
        }

        private void sqr_Click(object sender, RoutedEventArgs e)
        {
            double operand = Convert.ToDouble(screen.Text);
            double ans = Math.Pow(operand, 2);
            screen.Text = ans.ToString();
        }

        private void sqrt_Click(object sender, RoutedEventArgs e)
        {
            double operand = Convert.ToDouble(screen.Text);
            double ans = Math.Sqrt(operand);
            screen.Text = ans.ToString();
        }

        private void negate_Click(object sender, RoutedEventArgs e)
        {
            if (screen.Text.Substring(0,1)== "-")
            {
                screen.Text = screen.Text.TrimStart('-');
            }
            else
            {
                screen.Text = "-" + screen.Text;
            }
            
        }
    }
}
