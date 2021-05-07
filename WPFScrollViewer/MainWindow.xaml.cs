using System;
using System.Collections.Generic;
using System.IO;
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

namespace WPFScrollViewer
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            foreach(var item in Directory.GetFiles("../../Images"))
            {
                Image img = new Image();
                img.Width = 400;
                img.Height = 200;
                img.Margin = new Thickness(20);
                img.Source = (ImageSource)new ImageSourceConverter().ConvertFromString(item);
                ImagePanel.Children.Add(img);
            }           
        }
    }
}
