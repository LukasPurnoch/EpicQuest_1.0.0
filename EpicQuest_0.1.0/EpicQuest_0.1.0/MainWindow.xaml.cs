﻿using EpicQuest_0._1._0.Pages;
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

namespace EpicQuest_0._1._0
{
    /// <summary>
    /// Interakční logika pro MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            //MenuMusic.Play();
        }

        private void New_Click(object sender, RoutedEventArgs e)
        {
            Game.Content = new Story_1();
        }

        private void Load_Click(object sender, RoutedEventArgs e)
        {
            Game.Content = new Map();
        }

    }
}
