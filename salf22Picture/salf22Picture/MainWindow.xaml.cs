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

using System.IO;

namespace salf22Picture
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        string[] images = Directory.GetFiles(@"C:\Users\Spencer Laird\Documents\4400Chapter1\salf22ImageControl\Images\", "*.jpg");
        private int counter = 0;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void nextButton_Click(object sender, RoutedEventArgs e)
        {
            if (images.Length == 0) {
                return;
            }

            var imageOne = Image.FromFile(images[counter]);

        }
    }
}
