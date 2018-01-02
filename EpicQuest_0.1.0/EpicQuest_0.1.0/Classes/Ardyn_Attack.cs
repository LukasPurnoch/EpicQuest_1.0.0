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

        public void StrongAttack(int vyber, Label DMGEnemy, Label Position1HP, Label Position2HP, ProgressBar AP_Bar, Image Position4, Image Ardyn, Button Enemy1, Button Enemy2, Label DMGArdyn, ProgressBar HP_Bar, Image Position1, Image Position2, Image Position3)
        {
            Random StrongHitchance = new Random(); // Fast Attack -> 80% Chance, 8-13 DMG
            Random StrongDamage = new Random();

            int strongHitchance1 = StrongHitchance.Next(1, 101);
            int strongDamage1 = StrongDamage.Next(25, 31);

            if (vyber == 1)
            {
                int.TryParse(Position1HP.Content.ToString(), out int Position1HP_P);

                if (Position1HP_P > 0)
                {
                    if (strongHitchance1 <= 30)
                    {
                        DMGEnemy.Content = "-" + strongDamage1;
                        Position1HP_P -= strongDamage1;
                        Position1HP.Content = Position1HP_P;
                                                
                        Position4.Source = new BitmapImage(new Uri("pack://application:,,,/Characters/Cecil.png"));
                        Ardyn.Visibility = Visibility.Hidden;

                        Attack_From_Enemy EnemyAttack = new Attack_From_Enemy();
                        EnemyAttack.LightFromEnemy1(vyber, Enemy1, Enemy2, Position1HP, Position2HP, DMGArdyn, DMGEnemy, HP_Bar, Position1, Position2, Position3, Position4);
                        EnemyAttack.NormalFromEnemy1(vyber, Enemy1, Enemy2, Position1HP, Position2HP, DMGArdyn, DMGEnemy, HP_Bar, Position1, Position2, Position3, Position4);
                        EnemyAttack.StrongFromEnemy1(vyber, Enemy1, Enemy2, Position1HP, Position2HP, DMGArdyn, DMGEnemy, HP_Bar, Position1, Position2, Position3, Position4);
                    }
                    else
                    {
                        DMGEnemy.Content = "MISS";
                                                
                        Position4.Source = new BitmapImage(new Uri("pack://application:,,,/Characters/Cecil.png"));
                        Ardyn.Visibility = Visibility.Hidden;

                        Attack_From_Enemy EnemyAttack = new Attack_From_Enemy();
                        EnemyAttack.LightFromEnemy1(vyber, Enemy1, Enemy2, Position1HP, Position2HP, DMGArdyn, DMGEnemy, HP_Bar, Position1, Position2, Position3, Position4);
                        EnemyAttack.NormalFromEnemy1(vyber, Enemy1, Enemy2, Position1HP, Position2HP, DMGArdyn, DMGEnemy, HP_Bar, Position1, Position2, Position3, Position4);
                        EnemyAttack.StrongFromEnemy1(vyber, Enemy1, Enemy2, Position1HP, Position2HP, DMGArdyn, DMGEnemy, HP_Bar, Position1, Position2, Position3, Position4);
                    }
                }   
            }

            if (vyber == 2)
            {
                int.TryParse(Position2HP.Content.ToString(), out int Position2HP_P);

                if (Position2HP_P > 0)
                {
                    if (strongHitchance1 <= 30)
                    {
                        DMGEnemy.Content = "-" + strongDamage1;
                        Position2HP_P -= strongDamage1;
                        Position2HP.Content = Position2HP_P;

                        Position4.Source = new BitmapImage(new Uri("pack://application:,,,/Characters/Cecil.png"));
                        Ardyn.Visibility = Visibility.Hidden;

                        Attack_From_Enemy EnemyAttack = new Attack_From_Enemy();
                        EnemyAttack.LightFromEnemy2(vyber, Enemy1, Enemy2, Position1HP, Position2HP, DMGArdyn, DMGEnemy, HP_Bar, Position1, Position2, Position3, Position4);
                        EnemyAttack.NormalFromEnemy2(vyber, Enemy1, Enemy2, Position1HP, Position2HP, DMGArdyn, DMGEnemy, HP_Bar, Position1, Position2, Position3, Position4);
                        EnemyAttack.StrongFromEnemy2(vyber, Enemy1, Enemy2, Position1HP, Position2HP, DMGArdyn, DMGEnemy, HP_Bar, Position1, Position2, Position3, Position4);
                    }
                    else
                    {
                        DMGEnemy.Content = "MISS";

                        Position4.Source = new BitmapImage(new Uri("pack://application:,,,/Characters/Cecil.png"));
                        Ardyn.Visibility = Visibility.Hidden;

                        Attack_From_Enemy EnemyAttack = new Attack_From_Enemy();
                        EnemyAttack.LightFromEnemy2(vyber, Enemy1, Enemy2, Position1HP, Position2HP, DMGArdyn, DMGEnemy, HP_Bar, Position1, Position2, Position3, Position4);
                        EnemyAttack.NormalFromEnemy2(vyber, Enemy1, Enemy2, Position1HP, Position2HP, DMGArdyn, DMGEnemy, HP_Bar, Position1, Position2, Position3, Position4);
                        EnemyAttack.StrongFromEnemy2(vyber, Enemy1, Enemy2, Position1HP, Position2HP, DMGArdyn, DMGEnemy, HP_Bar, Position1, Position2, Position3, Position4);
                    }
                }
            }
        }

        public void FastAttack(int vyber, Label DMGEnemy, Label Position1HP, Label Position2HP, ProgressBar AP_Bar, Image Position4, Image Ardyn, Button Enemy1, Button Enemy2, Label DMGArdyn, ProgressBar HP_Bar, Image Position1, Image Position2, Image Position3)
        {
            Random FastHitchance = new Random(); // Fast Attack -> 80% Chance, 8-13 DMG
            Random FastDamage = new Random();

            int fastHitchance1 = FastHitchance.Next(1, 101);
            int fastDamage1 = FastDamage.Next(8, 14);

            if (vyber == 1)
            {
                int.TryParse(Position1HP.Content.ToString(), out int Position1HP_P);

                if (Position1HP_P > 0)
                {
                    if (fastHitchance1 <= 80)
                    {
                        DMGEnemy.Content = "-" + fastDamage1;
                        Position1HP_P -= fastDamage1;
                        Position1HP.Content = Position1HP_P;

                        Position4.Source = new BitmapImage(new Uri("pack://application:,,,/Characters/Cecil.png"));
                        Ardyn.Visibility = Visibility.Hidden;

                        Attack_From_Enemy EnemyAttack = new Attack_From_Enemy();
                        EnemyAttack.LightFromEnemy1(vyber, Enemy1, Enemy2, Position1HP, Position2HP, DMGArdyn, DMGEnemy, HP_Bar, Position1, Position2, Position3, Position4);
                        EnemyAttack.NormalFromEnemy1(vyber, Enemy1, Enemy2, Position1HP, Position2HP, DMGArdyn, DMGEnemy, HP_Bar, Position1, Position2, Position3, Position4);
                        EnemyAttack.StrongFromEnemy1(vyber, Enemy1, Enemy2, Position1HP, Position2HP, DMGArdyn, DMGEnemy, HP_Bar, Position1, Position2, Position3, Position4);
                    }
                    else
                    {
                        DMGEnemy.Content = "MISS";

                        Position4.Source = new BitmapImage(new Uri("pack://application:,,,/Characters/Cecil.png"));
                        Ardyn.Visibility = Visibility.Hidden;

                        Attack_From_Enemy EnemyAttack = new Attack_From_Enemy();
                        EnemyAttack.LightFromEnemy1(vyber, Enemy1, Enemy2, Position1HP, Position2HP, DMGArdyn, DMGEnemy, HP_Bar, Position1, Position2, Position3, Position4);
                        EnemyAttack.NormalFromEnemy1(vyber, Enemy1, Enemy2, Position1HP, Position2HP, DMGArdyn, DMGEnemy, HP_Bar, Position1, Position2, Position3, Position4);
                        EnemyAttack.StrongFromEnemy1(vyber, Enemy1, Enemy2, Position1HP, Position2HP, DMGArdyn, DMGEnemy, HP_Bar, Position1, Position2, Position3, Position4);
                    }
                }
            }

            if (vyber == 2)
            {
                int.TryParse(Position2HP.Content.ToString(), out int Position2HP_P);

                if (Position2HP_P > 0)
                {
                    if (fastHitchance1 <= 80)
                    {
                        DMGEnemy.Content = "-" + fastDamage1;
                        Position2HP_P -= fastDamage1;
                        Position2HP.Content = Position2HP_P;

                        Position4.Source = new BitmapImage(new Uri("pack://application:,,,/Characters/Cecil.png"));
                        Ardyn.Visibility = Visibility.Hidden;

                        Attack_From_Enemy EnemyAttack = new Attack_From_Enemy();
                        EnemyAttack.LightFromEnemy2(vyber, Enemy1, Enemy2, Position1HP, Position2HP, DMGArdyn, DMGEnemy, HP_Bar, Position1, Position2, Position3, Position4);
                        EnemyAttack.NormalFromEnemy2(vyber, Enemy1, Enemy2, Position1HP, Position2HP, DMGArdyn, DMGEnemy, HP_Bar, Position1, Position2, Position3, Position4);
                        EnemyAttack.StrongFromEnemy2(vyber, Enemy1, Enemy2, Position1HP, Position2HP, DMGArdyn, DMGEnemy, HP_Bar, Position1, Position2, Position3, Position4);
                    }
                    else
                    {
                        DMGEnemy.Content = "MISS";

                        Position4.Source = new BitmapImage(new Uri("pack://application:,,,/Characters/Cecil.png"));
                        Ardyn.Visibility = Visibility.Hidden;

                        Attack_From_Enemy EnemyAttack = new Attack_From_Enemy();
                        EnemyAttack.LightFromEnemy2(vyber, Enemy1, Enemy2, Position1HP, Position2HP, DMGArdyn, DMGEnemy, HP_Bar, Position1, Position2, Position3, Position4);
                        EnemyAttack.NormalFromEnemy2(vyber, Enemy1, Enemy2, Position1HP, Position2HP, DMGArdyn, DMGEnemy, HP_Bar, Position1, Position2, Position3, Position4);
                        EnemyAttack.StrongFromEnemy2(vyber, Enemy1, Enemy2, Position1HP, Position2HP, DMGArdyn, DMGEnemy, HP_Bar, Position1, Position2, Position3, Position4);
                    }
                }
            }
        }

        public void NormalAttack(int vyber, Label DMGEnemy, Label Position1HP, Label Position2HP, ProgressBar AP_Bar, Image Position4, Image Ardyn, Button Enemy1, Button Enemy2, Label DMGArdyn, ProgressBar HP_Bar, Image Position1, Image Position2, Image Position3)
        {
            Random NormalHitchance = new Random(); // Fast Attack -> 80% Chance, 8-13 DMG
            Random NormalDamage = new Random();

            int normalHitchance1 = NormalHitchance.Next(1, 101);
            int normalDamage1 = NormalDamage.Next(14, 19);

            if (vyber == 1)
            {
                int.TryParse(Position1HP.Content.ToString(), out int Position1HP_P);

                if (Position1HP_P > 0)
                {
                    if (normalHitchance1 <= 60)
                    {
                        DMGEnemy.Content = "-" + normalDamage1;
                        Position1HP_P -= normalDamage1;
                        Position1HP.Content = Position1HP_P;

                        Position4.Source = new BitmapImage(new Uri("pack://application:,,,/Characters/Cecil.png"));
                        Ardyn.Visibility = Visibility.Hidden;

                        Attack_From_Enemy EnemyAttack = new Attack_From_Enemy();
                        EnemyAttack.LightFromEnemy1(vyber, Enemy1, Enemy2, Position1HP, Position2HP, DMGArdyn, DMGEnemy, HP_Bar, Position1, Position2, Position3, Position4);
                        EnemyAttack.NormalFromEnemy1(vyber, Enemy1, Enemy2, Position1HP, Position2HP, DMGArdyn, DMGEnemy, HP_Bar, Position1, Position2, Position3, Position4);
                        EnemyAttack.StrongFromEnemy1(vyber, Enemy1, Enemy2, Position1HP, Position2HP, DMGArdyn, DMGEnemy, HP_Bar, Position1, Position2, Position3, Position4);
                    }
                    else
                    {
                        DMGEnemy.Content = "MISS";

                        Position4.Source = new BitmapImage(new Uri("pack://application:,,,/Characters/Cecil.png"));
                        Ardyn.Visibility = Visibility.Hidden;

                        Attack_From_Enemy EnemyAttack = new Attack_From_Enemy();
                        EnemyAttack.LightFromEnemy1(vyber, Enemy1, Enemy2, Position1HP, Position2HP, DMGArdyn, DMGEnemy, HP_Bar, Position1, Position2, Position3, Position4);
                        EnemyAttack.NormalFromEnemy1(vyber, Enemy1, Enemy2, Position1HP, Position2HP, DMGArdyn, DMGEnemy, HP_Bar, Position1, Position2, Position3, Position4);
                        EnemyAttack.StrongFromEnemy1(vyber, Enemy1, Enemy2, Position1HP, Position2HP, DMGArdyn, DMGEnemy, HP_Bar, Position1, Position2, Position3, Position4);
                    }
                }
            }

            if (vyber == 2)
            {
                int.TryParse(Position2HP.Content.ToString(), out int Position2HP_P);

                if (Position2HP_P > 0)
                {
                    if (normalHitchance1 <= 60)
                    {
                        DMGEnemy.Content = "-" + normalDamage1;
                        Position2HP_P -= normalDamage1;
                        Position2HP.Content = Position2HP_P;

                        Position4.Source = new BitmapImage(new Uri("pack://application:,,,/Characters/Cecil.png"));
                        Ardyn.Visibility = Visibility.Hidden;

                        Attack_From_Enemy EnemyAttack = new Attack_From_Enemy();
                        EnemyAttack.LightFromEnemy2(vyber, Enemy1, Enemy2, Position1HP, Position2HP, DMGArdyn, DMGEnemy, HP_Bar, Position1, Position2, Position3, Position4);
                        EnemyAttack.NormalFromEnemy2(vyber, Enemy1, Enemy2, Position1HP, Position2HP, DMGArdyn, DMGEnemy, HP_Bar, Position1, Position2, Position3, Position4);
                        EnemyAttack.StrongFromEnemy2(vyber, Enemy1, Enemy2, Position1HP, Position2HP, DMGArdyn, DMGEnemy, HP_Bar, Position1, Position2, Position3, Position4);
                    }
                    else
                    {
                        DMGEnemy.Content = "MISS";

                        Position4.Source = new BitmapImage(new Uri("pack://application:,,,/Characters/Cecil.png"));
                        Ardyn.Visibility = Visibility.Hidden;

                        Attack_From_Enemy EnemyAttack = new Attack_From_Enemy();
                        EnemyAttack.LightFromEnemy2(vyber, Enemy1, Enemy2, Position1HP, Position2HP, DMGArdyn, DMGEnemy, HP_Bar, Position1, Position2, Position3, Position4);
                        EnemyAttack.NormalFromEnemy2(vyber, Enemy1, Enemy2, Position1HP, Position2HP, DMGArdyn, DMGEnemy, HP_Bar, Position1, Position2, Position3, Position4);
                        EnemyAttack.StrongFromEnemy2(vyber, Enemy1, Enemy2, Position1HP, Position2HP, DMGArdyn, DMGEnemy, HP_Bar, Position1, Position2, Position3, Position4);
                    }
                }
            }
        }
    }
}
