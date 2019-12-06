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

namespace Practice
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public void SetEndDate()
        {
            int leapYear = 0;
            for(int i=DateTime.Now.Year ;i>(DateTime.Now.Year-10);i--)
            {
                if(i%4==0)
                {
                    leapYear++;
                }
            }
            DatePicker1.DisplayDateStart = DateTime.Now - TimeSpan.FromDays((365 * 10) + leapYear); // The calculation is done in order to restrict selection of start date exactly before the ten years as a start date
            DatePicker1.DisplayDateEnd = DateTime.Now + TimeSpan.FromDays(30);
        }

        private void Window_Loaded(Object sender, RoutedEventArgs e)
        {
            SetEndDate();
        }
    }

}
