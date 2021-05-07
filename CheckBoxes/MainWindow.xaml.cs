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

namespace CheckBoxes
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

        private void ShowCheckedButtons(object sender, RoutedEventArgs e)
        {
            string checkedColors = string.Empty;
            foreach (CheckBox item in CheckBoxes.Children)
            {
                if(item.IsChecked == true) checkedColors += (item.Content + " ");
            }
            MessageBox.Show(checkedColors);
        }
    }
}
