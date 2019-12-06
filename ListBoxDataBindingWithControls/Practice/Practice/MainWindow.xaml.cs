using System;
using System.Collections.Generic;
using System.Globalization;
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

        private void Window_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (TxtColor != null )
            {
                LstColors.SelectedItem = null;
                TxtColor.Text = null;
                CnvsClr = null;
            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
        }

        private void TxtColor_SelectionChanged(object sender, RoutedEventArgs e)
        {
            Console.WriteLine(CultureInfo.CurrentCulture .TextInfo .ToTitleCase(TxtColor .Text .ToString()));
        }
    }
}
