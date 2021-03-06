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
using System.Windows.Threading;

namespace EpicQuest_0._1._0.Classes
{
    class Potions
    {
        public void HP_Potion(Label LEVEL ,Label InventoryHPCounter, ProgressBar HP_Bar)
        {
            int.TryParse(InventoryHPCounter.Content.ToString(), out int countHP);
            int.TryParse(LEVEL.Content.ToString(), out int level);

            if (countHP > 0)
            {
                double scaleHP = (level * 10) + 100;

                HP_Bar.Value += scaleHP;
                countHP -= 1;

                InventoryHPCounter.Content = countHP;
                
                if (HP_Bar.Value > HP_Bar.Maximum)
                {
                    HP_Bar.Value = HP_Bar.Maximum;
                }
            }
        }

        public void AP_Potion(Label InventoryAPCounter, ProgressBar AP_Bar)
        {
            int.TryParse(InventoryAPCounter.Content.ToString(), out int countAP);

            if (countAP > 0)
            {
                AP_Bar.Value += 50;
                countAP -= 1;

                InventoryAPCounter.Content = countAP;

                if (AP_Bar.Value > AP_Bar.Maximum)
                {
                    AP_Bar.Value = AP_Bar.Maximum;
                }
            }
        }
    }
}
