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
using System.Windows.Threading;

namespace EpicQuest_0._1._0.Classes
{
    class Potions
    {
        public void HP_Potion(Label InventoryHPCounter, ProgressBar HP_Bar)
        {
            int.TryParse(InventoryHPCounter.Content.ToString(), out int countHP);
            
            if (countHP > 0)
            {
                HP_Bar.Value += 100;
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
