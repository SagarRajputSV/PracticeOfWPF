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

        private void BtnSelect_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            CmbMenu.SelectedIndex = 0;
            BtnSelect.IsEnabled = false;
        }

        private void CmbMenu_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (CmbMenu.SelectedIndex == 0)
            {
                BtnSelect.IsEnabled = false;
            }
                

            else
            {
                BtnSelect.IsEnabled = true;
            }
                
        }
    }
}
