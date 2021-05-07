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

namespace Notities
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

        private void AddToList(object sender, RoutedEventArgs e)
        {
            ToDoItem newItem = new ToDoItem(txtToDo.Text, DateTime.Now);
            lstToDo.Items.Add(newItem);
            //MessageBox.Show((lstToDo.Items[0] as ToDoItem).Text);
            txtToDo.Text = "";
        }

        private void DeleteSelected(object sender, RoutedEventArgs e)
        {

            while (lstToDo.SelectedIndex >= 0)
            {
                lstToDo.Items.RemoveAt(lstToDo.SelectedIndex);
            }
        }

        public class ToDoItem
        {
            public ToDoItem(string text, DateTime dateAdded)
            {
                Text = text;
                DateAdded = dateAdded;
            }

            public string Text { get; set; }
            public DateTime DateAdded { get; set; }
        }
    }
}
