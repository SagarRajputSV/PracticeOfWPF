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

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            CmbBeverages.SelectedIndex = 0;
            Bind_LabelText();
        }



        #region this is where the binding function of the label text is been written
        ///<summary>
        ///This will produce the label text binding 
        ///function based on the item been selected in the combobox
        ///</summary>

        private void Bind_LabelText()
        {
            lblBeverages.Content = CmbBeverages.SelectionBoxItem.ToString();
        }

        #endregion

        //private void CmbBeverages_SelectionChanged(object sender, SelectionChangedEventArgs e)
        //{
        //    Bind_LabelText();
        //}

        private void CmbBeverages_DropDownClosed(object sender, EventArgs e)
        {
            Bind_LabelText();
        }
    }
}
