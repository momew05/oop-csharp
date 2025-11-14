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

namespace кт12
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    
    public partial class SecondWindow : Window
    {
        public bool hello;
        public bool emoji;
        public SecondWindow()
        {
            InitializeComponent();
        }

        public string UserName { get; set; }
        

        private void OpenMain_Click(object sender, RoutedEventArgs e)
        {
            UserName = UserNameTextBox.Text;
            this.DialogResult = true;
            this.Close();
            
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void UnableGreeting_Click(object sender, RoutedEventArgs e)
        {
            MenuItem Hello = (MenuItem)sender;         
            hello = Hello.IsChecked; 
            
        }

        private void AddEmoji_Click(object sender, RoutedEventArgs e)
        {
            MenuItem Emoji = (MenuItem)sender;
            emoji = Emoji.IsChecked;
            
        }

        private void CloseMenu_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
