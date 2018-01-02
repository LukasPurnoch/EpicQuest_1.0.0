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

        public void LightFromEnemy(int vyber, Button Enemy1, Button Enemy2, Label Position1HP, Label Position2HP, Label DMGArdyn, Label DMGEnemy, ProgressBar HP_Bar, Image Position1, Image Position2, Image Position3, Image Position4)
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
                    switch (enemy1)
                    {
                        case "Gigantoad":
                            Position3.Source = new BitmapImage(new Uri("pack://application:,,,/Enemies/Gigantoad.png"));
                            Position1.Visibility = Visibility.Hidden;
                            break;
                        case "Flying Eyes":
                            Position3.Source = new BitmapImage(new Uri("pack://application:,,,/Enemies/Flying_Eyes.png"));
                            Position1.Visibility = Visibility.Hidden;
                            break;
                        case "Arachne":
                            Position3.Source = new BitmapImage(new Uri("pack://application:,,,/Enemies/Arachne.png"));
                            Position1.Visibility = Visibility.Hidden;
                            break;
                        case "Chimera":
                            Position3.Source = new BitmapImage(new Uri("pack://application:,,,/Enemies/Chimera.png"));
                            Position1.Visibility = Visibility.Hidden;
                            break;
                        case "Great Malboro":
                            Position3.Source = new BitmapImage(new Uri("pack://application:,,,/Enemies/Great_Malboro.png"));
                            Position1.Visibility = Visibility.Hidden;
                            break;
                        case "Magic Dragon":
                            Position3.Source = new BitmapImage(new Uri("pack://application:,,,/Enemies/Magic_Dragon.png"));
                            Position1.Visibility = Visibility.Hidden;
                            break;
                        case "Brachioraidos":
                            Position3.Source = new BitmapImage(new Uri("pack://application:,,,/Enemies/Brachioraidos.png"));
                            Position1.Visibility = Visibility.Hidden;
                            break;
                        case "Eukaryote":
                            Position3.Source = new BitmapImage(new Uri("pack://application:,,,/Enemies/Eukaryote.png"));
                            Position1.Visibility = Visibility.Hidden;
                            break;
                        case "Catoblepas":
                            Position3.Source = new BitmapImage(new Uri("pack://application:,,,/Enemies/Catoblepas.png"));
                            Position1.Visibility = Visibility.Hidden;
                            break;
                    }

                    if (vyber == 1)
                    {
                        Position4.Source = new BitmapImage(new Uri("pack://application:,,,/Characters/Cecil.png"));
                    }

                    if (fastHitchance1 >= 80)
                    {
                        double HPS = HP_Bar.Value;
                        DMGArdyn.Content = "-" + fastDamage1;

                        HPS -= fastDamage1;
                    }                    
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

            Random FastHitchance2 = new Random(); // Fast Attack -> 80% Chance, 8-13 DMG
            Random FastDamage2 = new Random();

            int fastHitchance2 = FastHitchance2.Next(1, 80);
            int fastDamage2 = FastDamage2.Next(8, 13);

            if (enemy2 == "Gigantoad" || enemy2 == "Flying Eyes" || enemy2 == "Arachne" || enemy2 == "Chimera" || enemy2 == "Great Malboro" || enemy2 == "Magic Dragon" || enemy2 == "Brachioraidos" || enemy2 == "Eukaryote" || enemy2 == "Catoblepas")
            {
                int.TryParse(Position2HP.Content.ToString(), out int Position2HP_P);

                if (Position2HP_P > 0)
                {
                    switch (enemy2)
                    {
                        case "Gigantoad":
                            Position3.Source = new BitmapImage(new Uri("pack://application:,,,/Enemies/Gigantoad.png"));
                            Position2.Visibility = Visibility.Hidden;
                            break;
                        case "Flying Eyes":
                            Position3.Source = new BitmapImage(new Uri("pack://application:,,,/Enemies/Flying_Eyes.png"));
                            Position2.Visibility = Visibility.Hidden;
                            break;
                        case "Arachne":
                            Position3.Source = new BitmapImage(new Uri("pack://application:,,,/Enemies/Arachne.png"));
                            Position2.Visibility = Visibility.Hidden;
                            break;
                        case "Chimera":
                            Position3.Source = new BitmapImage(new Uri("pack://application:,,,/Enemies/Chimera.png"));
                            Position2.Visibility = Visibility.Hidden;
                            break;
                        case "Great Malboro":
                            Position3.Source = new BitmapImage(new Uri("pack://application:,,,/Enemies/Great_Malboro.png"));
                            Position2.Visibility = Visibility.Hidden;
                            break;
                        case "Magic Dragon":
                            Position3.Source = new BitmapImage(new Uri("pack://application:,,,/Enemies/Magic_Dragon.png"));
                            Position2.Visibility = Visibility.Hidden;
                            break;
                        case "Brachioraidos":
                            Position3.Source = new BitmapImage(new Uri("pack://application:,,,/Enemies/Brachioraidos.png"));
                            Position2.Visibility = Visibility.Hidden;
                            break;
                        case "Eukaryote":
                            Position3.Source = new BitmapImage(new Uri("pack://application:,,,/Enemies/Eukaryote.png"));
                            Position2.Visibility = Visibility.Hidden;
                            break;
                        case "Catoblepas":
                            Position3.Source = new BitmapImage(new Uri("pack://application:,,,/Enemies/Catoblepas.png"));
                            Position2.Visibility = Visibility.Hidden;
                            break;
                    }

                    if (vyber == 1)
                    {
                        Position4.Source = new BitmapImage(new Uri("pack://application:,,,/Characters/Cecil.png"));
                    }

                    if (fastHitchance2 >= 80)
                    {
                        double HPS = HP_Bar.Value;
                        DMGArdyn.Content = "-" + fastDamage2;

                        HPS -= fastDamage2;
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
