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

namespace ListBox
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<Person> People = new List<Person>();
        public MainWindow()
        {
            InitializeComponent();
            Person person1 = new Person("Tim", "Audenaert", true);
            Person person2 = new Person("Ken", "Field", false);
            Person person3 = new Person("Piet", "Huysentruyt", true);
            People.Add(person1);
            People.Add(person2);
            People.Add(person3);

            foreach (var item in People)
            {
                ListBoxItem lbItem = new ListBoxItem();
                lbItem.Foreground = item.LoggedIn == true ? new SolidColorBrush(Colors.Green) : new SolidColorBrush(Colors.Red);
                lbItem.Content = item.FirstName + " " + item.LastName + "  " + (item.LoggedIn == true ? "(Logged in)" : "(Not logged in)");
                lbPeople.Items.Add(lbItem);
            }


        }
    }

    public class Person
    {
        public Person(string firstName, string lastName, bool loggedIn)
        {
            FirstName = firstName;
            LastName = lastName;
            LoggedIn = loggedIn;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool LoggedIn { get; set; }
    }
}
