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

namespace кт17
{
    public partial class MainWindow : Window
    {
        public int counter;
        public MainWindow()
        {
            InitializeComponent();

        }

        public void answer(object sender, EventArgs e)
        {
            gettotalscore();
        }

        public void gettotalscore()
        {
            counter = 0;
            if (correct1?.IsChecked == true) counter++;
            if (correct2?.IsChecked == true && correct22?.IsChecked == true) counter++;
            if (correct3?.IsChecked == true) counter++;
            if (correct4?.IsChecked == true) counter++;
            if (correct5?.IsChecked == true) counter++;
            if (correct6?.IsChecked == true && correct62?.IsChecked == true) counter++;
            if (correct7?.IsChecked == true) counter++;
            if (correct8?.IsChecked == true) counter++;
            if (correct9?.IsChecked == true) counter++;
            if (correct10?.IsChecked == true) counter++;
            if (correct11?.IsChecked == true) counter++;
            if (correct12?.IsChecked == true) counter++;

        }

        public void endquiz_clk(object sender, EventArgs e)
        {
            Window1 endwindow = new Window1(counter);
            this.Hide();
            endwindow.Show();
        }
    }
}
