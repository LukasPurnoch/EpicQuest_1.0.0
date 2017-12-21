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
    /// Interakční logika pro Depths.xaml
    /// </summary>
    public partial class Depths : Page
    {
        public Depths()
        {
            InitializeComponent();

            Level();
        }

        private void Level()
        {
            Classes.Enemy_Generator gen = new Classes.Enemy_Generator();
            gen.EnemyGen(4, Position1, Position2, Position1HP, Position2HP, Enemy1, Enemy2);
        }
    }
}
