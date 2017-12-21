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

namespace EpicQuest_0._1._0.Pages
{
    /// <summary>
    /// Interakční logika pro Map.xaml
    /// </summary>
    public partial class Map : Page
    {
        public Map()
        {
            InitializeComponent();
        }

        private void DungeonLvl_Click(object sender, RoutedEventArgs e)
        {
            FromMapLevel.Content = new Dungeon();
        }

        private void ForestLvl_Click(object sender, RoutedEventArgs e)
        {
            FromMapLevel.Content = new Forest();
        }

        private void CaveLvl_Click(object sender, RoutedEventArgs e)
        {
            FromMapLevel.Content = new Cave();
        }

        private void DepthsLvl_Click(object sender, RoutedEventArgs e)
        {
            FromMapLevel.Content = new Depths();
        }

        private void CatacombsLvl_Click(object sender, RoutedEventArgs e)
        {
            FromMapLevel.Content = new Catacombs();
        }
    }
}
