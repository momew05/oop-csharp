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

namespace кт18
{
    public partial class Window1 : Window
    {
        public Window1(int counter)
        {
            InitializeComponent();
            ShowScore(counter);
        }

        public void ShowScore(int counter)
        {
            result.Text = $"Поздравляю, вы набрали {counter} баллов";
        }
    }
}
