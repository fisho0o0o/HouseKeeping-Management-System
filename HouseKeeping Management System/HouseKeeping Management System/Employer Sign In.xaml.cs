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
using System.Windows.Shapes;

namespace HouseKeeping_Management_System
{
    /// <summary>
    /// Interaction logic for Employer_Sign_In.xaml
    /// </summary>
    public partial class Employer_Sign_In : Window
    {
        public Employer_Sign_In()
        {
            InitializeComponent();
        }

        private void grid(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private void btn_sub(object sender, RoutedEventArgs e)
        {

        }
    }
}
