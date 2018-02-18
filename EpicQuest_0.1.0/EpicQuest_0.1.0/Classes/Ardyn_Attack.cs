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
    class Ardyn_Attack
    {
        public int strongHitchance = 50;
        public int fastHitchance = 70;
        public int normalHitchance = 60;
                
        public void StrongAttack(MediaElement MediaPlayerr, int plusDMG, int vyber, Label DMGEnemy, Label Position1HP, Label Position2HP, ProgressBar AP_Bar, ProgressBar HP_Bar, Image Position4, Image Ardyn, Button Enemy1, Button Enemy2, Label DMGArdyn, Image Position1, Image Position2, Image Position3, Label Money, Image Boss, Frame Final)
        {
            double health = HP_Bar.Value;
            double ability = AP_Bar.Value;

            if (HP_Bar.Value > 0 && ability >= 3)
            {
                Random StrongHitchance = new Random();
                Random StrongDamage = new Random();

                int strongHitchance1 = StrongHitchance.Next(1, 101);
                int strongDamage1 = StrongDamage.Next(20, 25);                
                
                if (vyber == 1)
                {

                    int.TryParse(Position1HP.Content.ToString(), out int Position1HP_P);

                    if (Position1HP_P > 0)
                    {
                        AP_Bar.Value -= 3;

                        if (strongHitchance1 <= strongHitchance)
                        {
                            int SSSword = strongDamage1 + plusDMG;

                            DMGEnemy.Content = "-" + SSSword;
                            Position1HP_P -= SSSword;
                            Position1HP.Content = Position1HP_P;

                            Position4.Source = new BitmapImage(new Uri("pack://application:,,,/Characters/Cecil.png"));
                            Ardyn.Visibility = Visibility.Hidden;

                            Attack_From_Enemy EnemyAttack = new Attack_From_Enemy();
                            EnemyAttack.LightFromEnemy1(vyber, Enemy1, Enemy2, Position1HP, Position2HP, DMGArdyn, DMGEnemy, HP_Bar, Position1, Position2, Position3, Position4, Money, Boss);
                            EnemyAttack.NormalFromEnemy1(vyber, Enemy1, Enemy2, Position1HP, Position2HP, DMGArdyn, DMGEnemy, HP_Bar, Position1, Position2, Position3, Position4, Money, Boss);
                            EnemyAttack.StrongFromEnemy1(vyber, Enemy1, Enemy2, Position1HP, Position2HP, DMGArdyn, DMGEnemy, HP_Bar, Position1, Position2, Position3, Position4, Money, Boss);
                        }
                        else
                        {
                            DMGEnemy.Content = "MISS";

                            Position4.Source = new BitmapImage(new Uri("pack://application:,,,/Characters/Cecil.png"));
                            Ardyn.Visibility = Visibility.Hidden;

                            Attack_From_Enemy EnemyAttack = new Attack_From_Enemy();
                            EnemyAttack.LightFromEnemy1(vyber, Enemy1, Enemy2, Position1HP, Position2HP, DMGArdyn, DMGEnemy, HP_Bar, Position1, Position2, Position3, Position4, Money, Boss);
                            EnemyAttack.NormalFromEnemy1(vyber, Enemy1, Enemy2, Position1HP, Position2HP, DMGArdyn, DMGEnemy, HP_Bar, Position1, Position2, Position3, Position4, Money, Boss);
                            EnemyAttack.StrongFromEnemy1(vyber, Enemy1, Enemy2, Position1HP, Position2HP, DMGArdyn, DMGEnemy, HP_Bar, Position1, Position2, Position3, Position4, Money, Boss);
                        }
                    }
                }

                if (vyber == 2)
                {
                    int.TryParse(Position2HP.Content.ToString(), out int Position2HP_P);

                    if (Position2HP_P > 0)
                    {
                        AP_Bar.Value -= 3;

                        if (strongHitchance1 <= strongHitchance)
                        {
                            int SSSword = strongDamage1 + plusDMG;

                            DMGEnemy.Content = "-" + SSSword;
                            Position2HP_P -= SSSword;
                            Position2HP.Content = Position2HP_P;

                            Position4.Source = new BitmapImage(new Uri("pack://application:,,,/Characters/Cecil.png"));
                            Ardyn.Visibility = Visibility.Hidden;

                            Attack_From_Enemy EnemyAttack = new Attack_From_Enemy();
                            EnemyAttack.LightFromEnemy2(vyber, Enemy1, Enemy2, Position1HP, Position2HP, DMGArdyn, DMGEnemy, HP_Bar, Position1, Position2, Position3, Position4, Money, Boss);
                            EnemyAttack.NormalFromEnemy2(vyber, Enemy1, Enemy2, Position1HP, Position2HP, DMGArdyn, DMGEnemy, HP_Bar, Position1, Position2, Position3, Position4, Money, Boss);
                            EnemyAttack.StrongFromEnemy2(vyber, Enemy1, Enemy2, Position1HP, Position2HP, DMGArdyn, DMGEnemy, HP_Bar, Position1, Position2, Position3, Position4, Money, Boss);
                        }
                        else
                        {
                            DMGEnemy.Content = "MISS";

                            Position4.Source = new BitmapImage(new Uri("pack://application:,,,/Characters/Cecil.png"));
                            Ardyn.Visibility = Visibility.Hidden;

                            Attack_From_Enemy EnemyAttack = new Attack_From_Enemy();
                            EnemyAttack.LightFromEnemy2(vyber, Enemy1, Enemy2, Position1HP, Position2HP, DMGArdyn, DMGEnemy, HP_Bar, Position1, Position2, Position3, Position4, Money, Boss);
                            EnemyAttack.NormalFromEnemy2(vyber, Enemy1, Enemy2, Position1HP, Position2HP, DMGArdyn, DMGEnemy, HP_Bar, Position1, Position2, Position3, Position4, Money, Boss);
                            EnemyAttack.StrongFromEnemy2(vyber, Enemy1, Enemy2, Position1HP, Position2HP, DMGArdyn, DMGEnemy, HP_Bar, Position1, Position2, Position3, Position4, Money, Boss);
                        }
                    }
                }
            }
            else
            {
                MediaPlayerr.Stop();
                Final.Content = new Pages.Death_Screen();
            }
        }

        public void FastAttack(MediaElement MediaPlayerr, int plusDMG, int vyber, Label DMGEnemy, Label Position1HP, Label Position2HP, ProgressBar AP_Bar, Image Position4, Image Ardyn, Button Enemy1, Button Enemy2, Label DMGArdyn, ProgressBar HP_Bar, Image Position1, Image Position2, Image Position3, Label Money, Image Boss, Frame Final)
        {
            double health = HP_Bar.Value;
            double ability = AP_Bar.Value;

            if (HP_Bar.Value > 0 && ability >= 1)
            {

                Random FastHitchance = new Random(); // Fast Attack -> 80% Chance, 8-13 DMG
                Random FastDamage = new Random();

                int fastHitchance1 = FastHitchance.Next(1, 101);
                int fastDamage1 = FastDamage.Next(5, 10);
                
                if (vyber == 1)
                {

                    int.TryParse(Position1HP.Content.ToString(), out int Position1HP_P);

                    if (Position1HP_P > 0)
                    {
                        AP_Bar.Value -= 1;

                        if (fastHitchance1 <= fastHitchance)
                        {
                            int FFSword1 = fastDamage1 + plusDMG;

                            DMGEnemy.Content = "-" + FFSword1;
                            Position1HP_P -= FFSword1;
                            Position1HP.Content = Position1HP_P;

                            Position4.Source = new BitmapImage(new Uri("pack://application:,,,/Characters/Cecil.png"));
                            Ardyn.Visibility = Visibility.Hidden;

                            Attack_From_Enemy EnemyAttack = new Attack_From_Enemy();
                            EnemyAttack.LightFromEnemy1(vyber, Enemy1, Enemy2, Position1HP, Position2HP, DMGArdyn, DMGEnemy, HP_Bar, Position1, Position2, Position3, Position4, Money, Boss);
                            EnemyAttack.NormalFromEnemy1(vyber, Enemy1, Enemy2, Position1HP, Position2HP, DMGArdyn, DMGEnemy, HP_Bar, Position1, Position2, Position3, Position4, Money, Boss);
                            EnemyAttack.StrongFromEnemy1(vyber, Enemy1, Enemy2, Position1HP, Position2HP, DMGArdyn, DMGEnemy, HP_Bar, Position1, Position2, Position3, Position4, Money, Boss);
                        }
                        else
                        {
                            DMGEnemy.Content = "MISS";

                            Position4.Source = new BitmapImage(new Uri("pack://application:,,,/Characters/Cecil.png"));
                            Ardyn.Visibility = Visibility.Hidden;

                            Attack_From_Enemy EnemyAttack = new Attack_From_Enemy();
                            EnemyAttack.LightFromEnemy1(vyber, Enemy1, Enemy2, Position1HP, Position2HP, DMGArdyn, DMGEnemy, HP_Bar, Position1, Position2, Position3, Position4, Money, Boss);
                            EnemyAttack.NormalFromEnemy1(vyber, Enemy1, Enemy2, Position1HP, Position2HP, DMGArdyn, DMGEnemy, HP_Bar, Position1, Position2, Position3, Position4, Money, Boss);
                            EnemyAttack.StrongFromEnemy1(vyber, Enemy1, Enemy2, Position1HP, Position2HP, DMGArdyn, DMGEnemy, HP_Bar, Position1, Position2, Position3, Position4, Money, Boss);
                        }
                    }
                }

                if (vyber == 2)
                {
                    int.TryParse(Position2HP.Content.ToString(), out int Position2HP_P);

                    if (Position2HP_P > 0)
                    {
                        AP_Bar.Value -= 1;

                        if (fastHitchance1 <= fastHitchance)
                        {
                            int FFSword = fastDamage1 + plusDMG;

                            DMGEnemy.Content = "-" + FFSword;
                            Position2HP_P -= FFSword;
                            Position2HP.Content = Position2HP_P;

                            Position4.Source = new BitmapImage(new Uri("pack://application:,,,/Characters/Cecil.png"));
                            Ardyn.Visibility = Visibility.Hidden;

                            Attack_From_Enemy EnemyAttack = new Attack_From_Enemy();
                            EnemyAttack.LightFromEnemy2(vyber, Enemy1, Enemy2, Position1HP, Position2HP, DMGArdyn, DMGEnemy, HP_Bar, Position1, Position2, Position3, Position4, Money, Boss);
                            EnemyAttack.NormalFromEnemy2(vyber, Enemy1, Enemy2, Position1HP, Position2HP, DMGArdyn, DMGEnemy, HP_Bar, Position1, Position2, Position3, Position4, Money, Boss);
                            EnemyAttack.StrongFromEnemy2(vyber, Enemy1, Enemy2, Position1HP, Position2HP, DMGArdyn, DMGEnemy, HP_Bar, Position1, Position2, Position3, Position4, Money, Boss);
                        }
                        else
                        {
                            DMGEnemy.Content = "MISS";

                            Position4.Source = new BitmapImage(new Uri("pack://application:,,,/Characters/Cecil.png"));
                            Ardyn.Visibility = Visibility.Hidden;

                            Attack_From_Enemy EnemyAttack = new Attack_From_Enemy();
                            EnemyAttack.LightFromEnemy2(vyber, Enemy1, Enemy2, Position1HP, Position2HP, DMGArdyn, DMGEnemy, HP_Bar, Position1, Position2, Position3, Position4, Money, Boss);
                            EnemyAttack.NormalFromEnemy2(vyber, Enemy1, Enemy2, Position1HP, Position2HP, DMGArdyn, DMGEnemy, HP_Bar, Position1, Position2, Position3, Position4, Money, Boss);
                            EnemyAttack.StrongFromEnemy2(vyber, Enemy1, Enemy2, Position1HP, Position2HP, DMGArdyn, DMGEnemy, HP_Bar, Position1, Position2, Position3, Position4, Money, Boss);
                        }
                    }
                }
            }
            else
            {
                MediaPlayerr.Stop();
                Final.Content = new Pages.Death_Screen();
            }
        }

        public void NormalAttack(MediaElement MediaPlayerr, int plusDMG, int vyber, Label DMGEnemy, Label Position1HP, Label Position2HP, ProgressBar AP_Bar, Image Position4, Image Ardyn, Button Enemy1, Button Enemy2, Label DMGArdyn, ProgressBar HP_Bar, Image Position1, Image Position2, Image Position3, Label Money, Image Boss, Frame Final)
        {
            double health = HP_Bar.Value;
            double ability = AP_Bar.Value;

            if (HP_Bar.Value > 0 && ability >= 2)
            {

                Random NormalHitchance = new Random(); // Fast Attack -> 80% Chance, 8-13 DMG
                Random NormalDamage = new Random();

                int normalHitchance1 = NormalHitchance.Next(1, 101);
                int normalDamage1 = NormalDamage.Next(11, 16);
                
                if (vyber == 1)
                {

                    int.TryParse(Position1HP.Content.ToString(), out int Position1HP_P);

                    if (Position1HP_P > 0)
                    {
                        AP_Bar.Value -= 2;

                        if (normalHitchance1 <= normalHitchance)
                        {
                            int NNSword = normalDamage1 + plusDMG;

                            DMGEnemy.Content = "-" + NNSword;
                            Position1HP_P -= NNSword;
                            Position1HP.Content = Position1HP_P;

                            Position4.Source = new BitmapImage(new Uri("pack://application:,,,/Characters/Cecil.png"));
                            Ardyn.Visibility = Visibility.Hidden;

                            Attack_From_Enemy EnemyAttack = new Attack_From_Enemy();
                            EnemyAttack.LightFromEnemy1(vyber, Enemy1, Enemy2, Position1HP, Position2HP, DMGArdyn, DMGEnemy, HP_Bar, Position1, Position2, Position3, Position4, Money, Boss);
                            EnemyAttack.NormalFromEnemy1(vyber, Enemy1, Enemy2, Position1HP, Position2HP, DMGArdyn, DMGEnemy, HP_Bar, Position1, Position2, Position3, Position4, Money, Boss);
                            EnemyAttack.StrongFromEnemy1(vyber, Enemy1, Enemy2, Position1HP, Position2HP, DMGArdyn, DMGEnemy, HP_Bar, Position1, Position2, Position3, Position4, Money, Boss);
                        }
                        else
                        {
                            DMGEnemy.Content = "MISS";

                            Position4.Source = new BitmapImage(new Uri("pack://application:,,,/Characters/Cecil.png"));
                            Ardyn.Visibility = Visibility.Hidden;

                            Attack_From_Enemy EnemyAttack = new Attack_From_Enemy();
                            EnemyAttack.LightFromEnemy1(vyber, Enemy1, Enemy2, Position1HP, Position2HP, DMGArdyn, DMGEnemy, HP_Bar, Position1, Position2, Position3, Position4, Money, Boss);
                            EnemyAttack.NormalFromEnemy1(vyber, Enemy1, Enemy2, Position1HP, Position2HP, DMGArdyn, DMGEnemy, HP_Bar, Position1, Position2, Position3, Position4, Money, Boss);
                            EnemyAttack.StrongFromEnemy1(vyber, Enemy1, Enemy2, Position1HP, Position2HP, DMGArdyn, DMGEnemy, HP_Bar, Position1, Position2, Position3, Position4, Money, Boss);
                        }
                    }
                }

                if (vyber == 2)
                {
                    int.TryParse(Position2HP.Content.ToString(), out int Position2HP_P);

                    if (Position2HP_P > 0)
                    {
                        AP_Bar.Value -= 2;

                        if (normalHitchance1 <= normalHitchance)
                        {
                            int NNSword = normalDamage1 + plusDMG;

                            DMGEnemy.Content = "-" + NNSword;
                            Position2HP_P -= NNSword;
                            Position2HP.Content = Position2HP_P;

                            Position4.Source = new BitmapImage(new Uri("pack://application:,,,/Characters/Cecil.png"));
                            Ardyn.Visibility = Visibility.Hidden;

                            Attack_From_Enemy EnemyAttack = new Attack_From_Enemy();
                            EnemyAttack.LightFromEnemy2(vyber, Enemy1, Enemy2, Position1HP, Position2HP, DMGArdyn, DMGEnemy, HP_Bar, Position1, Position2, Position3, Position4, Money, Boss);
                            EnemyAttack.NormalFromEnemy2(vyber, Enemy1, Enemy2, Position1HP, Position2HP, DMGArdyn, DMGEnemy, HP_Bar, Position1, Position2, Position3, Position4, Money, Boss);
                            EnemyAttack.StrongFromEnemy2(vyber, Enemy1, Enemy2, Position1HP, Position2HP, DMGArdyn, DMGEnemy, HP_Bar, Position1, Position2, Position3, Position4, Money, Boss);
                        }
                        else
                        {
                            DMGEnemy.Content = "MISS";

                            Position4.Source = new BitmapImage(new Uri("pack://application:,,,/Characters/Cecil.png"));
                            Ardyn.Visibility = Visibility.Hidden;

                            Attack_From_Enemy EnemyAttack = new Attack_From_Enemy();
                            EnemyAttack.LightFromEnemy2(vyber, Enemy1, Enemy2, Position1HP, Position2HP, DMGArdyn, DMGEnemy, HP_Bar, Position1, Position2, Position3, Position4, Money, Boss);
                            EnemyAttack.NormalFromEnemy2(vyber, Enemy1, Enemy2, Position1HP, Position2HP, DMGArdyn, DMGEnemy, HP_Bar, Position1, Position2, Position3, Position4, Money, Boss);
                            EnemyAttack.StrongFromEnemy2(vyber, Enemy1, Enemy2, Position1HP, Position2HP, DMGArdyn, DMGEnemy, HP_Bar, Position1, Position2, Position3, Position4, Money, Boss);
                        }
                    }
                }
            }
            else
            {
                MediaPlayerr.Stop();
                Final.Content = new Pages.Death_Screen();
            }
        }
    }
}
