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

namespace WPFAccount
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public Persoon Persoon { get; set; }
        public MainWindow()
        {
            InitializeComponent();
        }

        public void ShowInfo(object sender, RoutedEventArgs e)
        {
            Persoon = new Persoon(TxtFirstName.Text, TxtLastName.Text, Convert.ToInt32(TxtAge.Text), TxtAddress.Text, RbMan.IsChecked == true ? true : false);
            ShowInfo newShowInfo = new ShowInfo();
            newShowInfo.Show();
        }
    }

    public class Persoon
    {
        public Persoon(string voornaam, string achternaam, int leeftijd, string adres, bool geslacht)
        {
            Voornaam = voornaam;
            Achternaam = achternaam;
            Leeftijd = leeftijd;
            Adres = adres;
            Geslacht = geslacht;
        }

        public string Voornaam { get; set; }
        public string Achternaam { get; set; }
        public int Leeftijd { get; set; }
        public string Adres { get; set; }
        public bool Geslacht { get; set; }


    }
}
