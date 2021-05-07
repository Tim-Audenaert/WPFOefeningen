﻿using System;
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

namespace Comboboxes
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

        private void btnConfirm_Click(object sender, RoutedEventArgs e)
        {
            string ageCategory = cbAgeCategory.Text == "" ? "Minderjarige" : cbAgeCategory.Text;
            string gender = cbGender.Text == "" ? "Man" : cbGender.Text;
            MessageBox.Show(ageCategory + " " + gender);
        }
    }
}
