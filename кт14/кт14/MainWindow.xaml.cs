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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace кт14
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        double? left = null;
        string op = null;

        public MainWindow()
        {
            InitializeComponent();
        }
        private void BtnDigit_Click(object sender, RoutedEventArgs e)
        {
            var button = sender as Button;
            if (button == null) return;

            string digit = button.Content.ToString();

            if (Display.Text == "0")
                Display.Text = digit;
            else
                Display.Text += digit;
        }

        private void BtnOp_Click(object sender, RoutedEventArgs e)
        {
            var button = sender as Button;
            if (button == null) return;

            left = double.Parse(Display.Text);
            op = button.Content.ToString();
            Display.Text = "0";
        }

        private void BtnEqual_Click(object sender, RoutedEventArgs e)
        {
            if (left == null || op == null) return;

            double right = double.Parse(Display.Text);
            double result = 0;
            if (op == "+")
            {
                result = left.Value + right;
            }
            else if (op == "-")
            {
                result = left.Value - right;
            }
            else if (op == "*")
            {
                result = left.Value * right;
            }
            else if (op == "/")
            {
                result = (right == 0) ? 0 : left.Value / right;
            }

            Display.Text = result.ToString();
            left = null; 
            op = null;   
        }
        
        private void BtnClear_Click(object sender, RoutedEventArgs e)
        {
            Display.Text = "0";
            left = null;
            op = null;
        }
        private void BtnBackspace_Click(object sender, RoutedEventArgs e)
        {
            if (Display.Text.Length <= 1)
                Display.Text = "0";
            else
                Display.Text = Display.Text.Remove(Display.Text.Length - 1);
        }
    }
}
