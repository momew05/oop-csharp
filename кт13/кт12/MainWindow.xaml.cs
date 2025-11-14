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

namespace кт12
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        public MainWindow()
        {
            InitializeComponent();
        }

        
        private void btnOpenSecond_Click(object sender, RoutedEventArgs e)
        {
            var secondWindow = new SecondWindow();
            secondWindow.Owner = this;
            this.Hide();
            bool? result = secondWindow.ShowDialog();
            this.Show();
            if (result == true && secondWindow.hello == true) 
            {
                UserInfoTextBlock.Text = $"{secondWindow.UserName}";
            }
            else if(result == true)
            {
                UserInfoTextBlock.Text = $"Привет, {secondWindow.UserName}!";
            }
            else
            {
                MessageBox.Show("Окно было закрыто без передачи данных");
            }

            if (result == true && secondWindow.emoji == true)
            {
                secret.Visibility = Visibility.Visible;
            }


        }
    }
}
