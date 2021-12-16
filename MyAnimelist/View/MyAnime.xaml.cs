﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace MyAnimelist.View
{
    /// <summary>
    /// Interaction logic for MyAnime.xaml
    /// </summary>
    public partial class MyAnime : Window
    {
        public MyAnime()
        {
            InitializeComponent();
        }

        private void Home(object sender, RoutedEventArgs e)
        {
            Home home = new Home();
            this.Close();
            home.Show();
        }
    }
}
