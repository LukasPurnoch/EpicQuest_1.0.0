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
    public class Attack_From_Enemy
    {
        public int increment;

        public void Time_Tick(object sender, EventArgs e)
        {
            increment++;
        }

        public void TimeStart(int stop)
        {
            DispatcherTimer Time = new DispatcherTimer();

            if (stop == 0)
            {
                Time.Interval = TimeSpan.FromSeconds(1);
                Time.Tick += Time_Tick;
                Time.Start();
            }
            else
            {
                Time.Stop();
            }
        }




        public void LightFromEnemy1(int vyber, Button Enemy1, Button Enemy2, Label Position1HP, Label Position2HP, Label DMGArdyn, Label DMGEnemy, ProgressBar HP_Bar, Image Position1, Image Position2, Image Position3, Image Position4)
        {
            string enemy1 = Enemy1.Content.ToString();
            string enemy2 = Enemy2.Content.ToString();

            Random FastHitchance1 = new Random(); // Fast Attack -> 80% Chance, 8-13 DMG
            Random FastDamage1 = new Random();

            int fastHitchance1 = FastHitchance1.Next(1, 80);
            int fastDamage1 = FastDamage1.Next(8, 13);

            if (enemy1 == "Gigantoad" || enemy1 == "Flying Eyes" || enemy1 == "Arachne" || enemy1 == "Chimera" || enemy1 == "Great Malboro" || enemy1 == "Magic Dragon" || enemy1 == "Brachioraidos" || enemy1 == "Eukaryote" || enemy1 == "Catoblepas")
            {
                int.TryParse(Position1HP.Content.ToString(), out int Position1HP_P);

                if (Position1HP_P > 0)
                {
                    
                }
            }

            TimeStart(0);

            if (increment % 4 == 0)
            {
                Position3.Source = null;
                Position4.Source = null;
                DMGArdyn.Content = null;
                DMGEnemy.Content = null;
                TimeStart(1);
            }
        }
    }
}
