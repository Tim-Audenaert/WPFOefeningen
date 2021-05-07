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

namespace WPFOefeningen
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {       
        public MainWindow()
        {
            InitializeComponent();
            string img1src = "https://static.thetoptens.com/img/lists/15699.jpg";
            string img2src = "https://static.zerochan.net/Tsunemori.Akane.full.1823880.jpg";
            string img3src = "https://i.pinimg.com/originals/b6/9e/cb/b69ecbb0bd7798b3de642b79f8f9eb1b.jpg";

            BitmapImage img1 = new BitmapImage();
            img1.BeginInit();
            img1.UriSource = new Uri(img1src);
            img1.EndInit();

            BitmapImage img2 = new BitmapImage();
            img2.BeginInit();
            img2.UriSource = new Uri(img2src);
            img2.EndInit();

            BitmapImage img3 = new BitmapImage();
            img3.BeginInit();
            img3.UriSource = new Uri(img3src);
            img3.EndInit();

            Waifus.Add(new Waifu("Mikasa", "Ackermann", img1src, img1));
            Waifus.Add(new Waifu("Akane", "Tsunemori", img2src, img2));
            Waifus.Add(new Waifu("Uraraka", "Uchako", img3src, img3));
            CmbWaifus.ItemsSource = Waifus;
            CmbWaifus.SelectedIndex = 0;
        }
        public List<Waifu> Waifus { get; set; } = new List<Waifu>();

        private void CmbWaifus_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            LargeImage.Source = (CmbWaifus.SelectedItem as Waifu).Image;
        }
    }

    public class Waifu
    {
        public Waifu(string firstName, string lastName, string imagePath, BitmapImage image)
        {
            FirstName = firstName;
            LastName = lastName;
            ImagePath = imagePath;
            Image = image;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ImagePath { get; set; }
        public BitmapImage Image { get; set; }
    }

}
