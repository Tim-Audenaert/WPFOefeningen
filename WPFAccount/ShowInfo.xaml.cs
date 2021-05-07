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

namespace WPFAccount
{
    /// <summary>
    /// Interaction logic for ShowInfo.xaml
    /// </summary>
    public partial class ShowInfo : Window
    {
        public ShowInfo()
        {
            Persoon persoon = ((MainWindow)Application.Current.MainWindow).Persoon;
            InitializeComponent();
            LblFullName.Content = persoon.Voornaam + " " + persoon.Achternaam;
            LblAge.Content = persoon.Leeftijd;
            LblAddress.Content = persoon.Adres;
            LblGender.Content = persoon.Geslacht ? "Man" : "Vrouw";
        }
    }
}
