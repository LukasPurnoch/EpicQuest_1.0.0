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
        public void LightFromEnemy1(int vyber, Button Enemy1, Button Enemy2, Label Position1HP, Label Position2HP, Label DMGArdyn, Label DMGEnemy, ProgressBar HP_Bar, Image Position1, Image Position2, Image Position3, Image Position4)
        {
            string enemy1 = Enemy1.Content.ToString();
            string enemy2 = Enemy2.Content.ToString();

            Random FastHitchance1 = new Random(); // Fast Attack -> 80% Chance, 8-13 DMG
            Random FastDamage1 = new Random();

            int fastHitchance1 = FastHitchance1.Next(1, 81);
            int fastDamage1 = FastDamage1.Next(8, 13);

            if (enemy1 == "Gigantoad" || enemy1 == "Flying Eyes" || enemy1 == "Arachne" || enemy1 == "Chimera" || enemy1 == "Great Malboro" || enemy1 == "Magic Dragon" || enemy1 == "Brachioraidos" || enemy1 == "Eukaryote" || enemy1 == "Catoblepas")
            {
                int.TryParse(Position1HP.Content.ToString(), out int Position1HP_P);

                if (Position1HP_P > 0)
                {
                    if (fastHitchance1 <= 80)
                    {
                        double HPS = HP_Bar.Value;
                        DMGArdyn.Content = "-" + fastDamage1;

                        HPS -= fastDamage1;

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
                    }
                    else
                    {
                        DMGArdyn.Content = "MISS";

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
                    }
                }
            }
        }
        public void LightFromEnemy2(int vyber, Button Enemy1, Button Enemy2, Label Position1HP, Label Position2HP, Label DMGArdyn, Label DMGEnemy, ProgressBar HP_Bar, Image Position1, Image Position2, Image Position3, Image Position4)
        {
            string enemy1 = Enemy1.Content.ToString();
            string enemy2 = Enemy2.Content.ToString();

            Random FastHitchance2 = new Random(); // Fast Attack -> 80% Chance, 8-13 DMG
            Random FastDamage2 = new Random();

            int fastHitchance2 = FastHitchance2.Next(1, 81);
            int fastDamage2 = FastDamage2.Next(8, 13);

            if (enemy2 == "Gigantoad" || enemy2 == "Flying Eyes" || enemy2 == "Arachne" || enemy2 == "Chimera" || enemy2 == "Great Malboro" || enemy2 == "Magic Dragon" || enemy2 == "Brachioraidos" || enemy2 == "Eukaryote" || enemy2 == "Catoblepas")
            {
                int.TryParse(Position2HP.Content.ToString(), out int Position2HP_P);

                if (Position2HP_P > 0)
                {
                    if (fastHitchance2 <= 80)
                    {
                        double HPS = HP_Bar.Value;
                        DMGArdyn.Content = "-" + fastDamage2;

                        HPS -= fastDamage2;

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
                    }
                    else
                    {
                        DMGArdyn.Content = "MISS";

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
                    }
                }
            }
        }

        public void NormalFromEnemy1(int vyber, Button Enemy1, Button Enemy2, Label Position1HP, Label Position2HP, Label DMGArdyn, Label DMGEnemy, ProgressBar HP_Bar, Image Position1, Image Position2, Image Position3, Image Position4)
        {
            string enemy1 = Enemy1.Content.ToString();
            string enemy2 = Enemy2.Content.ToString();

            Random NormalHitchance1 = new Random(); // Normal Attack -> 60% Chance, 14-19 DMG
            Random NormalDamage1 = new Random();

            int normalHitchance1 = NormalHitchance1.Next(1, 61);
            int normalDamage1 = NormalDamage1.Next(14, 20);

            if (enemy1 == "Death Flower" || enemy1 == "Lilith" || enemy1 == "Hydra" || enemy1 == "Ghost Knight" || enemy1 == "Fiery Hound" || enemy1 == "Behemoth" || enemy1 == "Red Dragon" || enemy1 == "Death Puppet" || enemy1 == "Gorgon")
            {
                int.TryParse(Position1HP.Content.ToString(), out int Position1HP_P);

                if (Position1HP_P > 0)
                {
                    if (normalHitchance1 <= 80)
                    {
                        double HPS = HP_Bar.Value;
                        DMGArdyn.Content = "-" + normalDamage1;

                        HPS -= normalDamage1;

                        switch (enemy1)
                        {
                            case "Death Flower":
                                Position3.Source = new BitmapImage(new Uri("pack://application:,,,/Enemies/Death_Flower.png"));
                                Position1.Visibility = Visibility.Hidden;
                                break;
                            case "Lilith":
                                Position3.Source = new BitmapImage(new Uri("pack://application:,,,/Enemies/Lilith.png"));
                                Position1.Visibility = Visibility.Hidden;
                                break;
                            case "Hydra":
                                Position3.Source = new BitmapImage(new Uri("pack://application:,,,/Enemies/Hydra.png"));
                                Position1.Visibility = Visibility.Hidden;
                                break;
                            case "Ghost Knight":
                                Position3.Source = new BitmapImage(new Uri("pack://application:,,,/Enemies/Ghost_Knight.png"));
                                Position1.Visibility = Visibility.Hidden;
                                break;
                            case "Fiery Hound":
                                Position3.Source = new BitmapImage(new Uri("pack://application:,,,/Enemies/Fiery_Hound.png"));
                                Position1.Visibility = Visibility.Hidden;
                                break;
                            case "Behemoth":
                                Position3.Source = new BitmapImage(new Uri("pack://application:,,,/Enemies/Behemoth.png"));
                                Position1.Visibility = Visibility.Hidden;
                                break;
                            case "Red Dragon":
                                Position3.Source = new BitmapImage(new Uri("pack://application:,,,/Enemies/Red_Dragon.png"));
                                Position1.Visibility = Visibility.Hidden;
                                break;
                            case "Death Puppet":
                                Position3.Source = new BitmapImage(new Uri("pack://application:,,,/Enemies/Death_Puppet.png"));
                                Position1.Visibility = Visibility.Hidden;
                                break;
                            case "Gorgon":
                                Position3.Source = new BitmapImage(new Uri("pack://application:,,,/Enemies/Gorgon.png"));
                                Position1.Visibility = Visibility.Hidden;
                                break;
                        }
                    }
                    else
                    {
                        DMGArdyn.Content = "MISS";

                        switch (enemy1)
                        {
                            case "Death Flower":
                                Position3.Source = new BitmapImage(new Uri("pack://application:,,,/Enemies/Death_Flower.png"));
                                Position1.Visibility = Visibility.Hidden;
                                break;
                            case "Lilith":
                                Position3.Source = new BitmapImage(new Uri("pack://application:,,,/Enemies/Lilith.png"));
                                Position1.Visibility = Visibility.Hidden;
                                break;
                            case "Hydra":
                                Position3.Source = new BitmapImage(new Uri("pack://application:,,,/Enemies/Hydra.png"));
                                Position1.Visibility = Visibility.Hidden;
                                break;
                            case "Ghost Knight":
                                Position3.Source = new BitmapImage(new Uri("pack://application:,,,/Enemies/Ghost_Knight.png"));
                                Position1.Visibility = Visibility.Hidden;
                                break;
                            case "Fiery Hound":
                                Position3.Source = new BitmapImage(new Uri("pack://application:,,,/Enemies/Fiery_Hound.png"));
                                Position1.Visibility = Visibility.Hidden;
                                break;
                            case "Behemoth":
                                Position3.Source = new BitmapImage(new Uri("pack://application:,,,/Enemies/Behemoth.png"));
                                Position1.Visibility = Visibility.Hidden;
                                break;
                            case "Red Dragon":
                                Position3.Source = new BitmapImage(new Uri("pack://application:,,,/Enemies/Red_Dragon.png"));
                                Position1.Visibility = Visibility.Hidden;
                                break;
                            case "Death Puppet":
                                Position3.Source = new BitmapImage(new Uri("pack://application:,,,/Enemies/Death_Puppet.png"));
                                Position1.Visibility = Visibility.Hidden;
                                break;
                            case "Gorgon":
                                Position3.Source = new BitmapImage(new Uri("pack://application:,,,/Enemies/Gorgon.png"));
                                Position1.Visibility = Visibility.Hidden;
                                break;
                        }
                    }
                }
            }
        }
        public void NormalFromEnemy2(int vyber, Button Enemy1, Button Enemy2, Label Position1HP, Label Position2HP, Label DMGArdyn, Label DMGEnemy, ProgressBar HP_Bar, Image Position1, Image Position2, Image Position3, Image Position4)
        {
            string enemy1 = Enemy1.Content.ToString();
            string enemy2 = Enemy2.Content.ToString();

            Random NormalHitchance2 = new Random(); // Normal Attack -> 60% Chance, 14-19 DMG
            Random NormalDamage2 = new Random();

            int normalHitchance2 = NormalHitchance2.Next(1, 61);
            int normalDamage2 = NormalDamage2.Next(14, 20);

            if (enemy2 == "Death Flower" || enemy2 == "Lilith" || enemy2 == "Hydra" || enemy2 == "Ghost Knight" || enemy2 == "Fiery Hound" || enemy2 == "Behemoth" || enemy2 == "Red Dragon" || enemy2 == "Death Puppet" || enemy2 == "Gorgon")
            {
                int.TryParse(Position2HP.Content.ToString(), out int Position2HP_P);

                if (Position2HP_P > 0)
                {
                    if (normalHitchance2 <= 80)
                    {
                        double HPS = HP_Bar.Value;
                        DMGArdyn.Content = "-" + normalDamage2;

                        HPS -= normalDamage2;

                        switch (enemy2)
                        {
                            case "Death Flower":
                                Position3.Source = new BitmapImage(new Uri("pack://application:,,,/Enemies/Death_Flower.png"));
                                Position2.Visibility = Visibility.Hidden;
                                break;
                            case "Lilith":
                                Position3.Source = new BitmapImage(new Uri("pack://application:,,,/Enemies/Lilith.png"));
                                Position2.Visibility = Visibility.Hidden;
                                break;
                            case "Hydra":
                                Position3.Source = new BitmapImage(new Uri("pack://application:,,,/Enemies/Hydra.png"));
                                Position2.Visibility = Visibility.Hidden;
                                break;
                            case "Ghost Knight":
                                Position3.Source = new BitmapImage(new Uri("pack://application:,,,/Enemies/Ghost_Knight.png"));
                                Position2.Visibility = Visibility.Hidden;
                                break;
                            case "Fiery Hound":
                                Position3.Source = new BitmapImage(new Uri("pack://application:,,,/Enemies/Fiery_Hound.png"));
                                Position2.Visibility = Visibility.Hidden;
                                break;
                            case "Behemoth":
                                Position3.Source = new BitmapImage(new Uri("pack://application:,,,/Enemies/Behemoth.png"));
                                Position2.Visibility = Visibility.Hidden;
                                break;
                            case "Red Dragon":
                                Position3.Source = new BitmapImage(new Uri("pack://application:,,,/Enemies/Red_Dragon.png"));
                                Position2.Visibility = Visibility.Hidden;
                                break;
                            case "Death Puppet":
                                Position3.Source = new BitmapImage(new Uri("pack://application:,,,/Enemies/Death_Puppet.png"));
                                Position2.Visibility = Visibility.Hidden;
                                break;
                            case "Gorgon":
                                Position3.Source = new BitmapImage(new Uri("pack://application:,,,/Enemies/Gorgon.png"));
                                Position2.Visibility = Visibility.Hidden;
                                break;
                        }
                    }
                    else
                    {
                        DMGArdyn.Content = "MISS";

                        switch (enemy2)
                        {
                            case "Death Flower":
                                Position3.Source = new BitmapImage(new Uri("pack://application:,,,/Enemies/Death_Flower.png"));
                                Position2.Visibility = Visibility.Hidden;
                                break;
                            case "Lilith":
                                Position3.Source = new BitmapImage(new Uri("pack://application:,,,/Enemies/Lilith.png"));
                                Position2.Visibility = Visibility.Hidden;
                                break;
                            case "Hydra":
                                Position3.Source = new BitmapImage(new Uri("pack://application:,,,/Enemies/Hydra.png"));
                                Position2.Visibility = Visibility.Hidden;
                                break;
                            case "Ghost Knight":
                                Position3.Source = new BitmapImage(new Uri("pack://application:,,,/Enemies/Ghost_Knight.png"));
                                Position2.Visibility = Visibility.Hidden;
                                break;
                            case "Fiery Hound":
                                Position3.Source = new BitmapImage(new Uri("pack://application:,,,/Enemies/Fiery_Hound.png"));
                                Position2.Visibility = Visibility.Hidden;
                                break;
                            case "Behemoth":
                                Position3.Source = new BitmapImage(new Uri("pack://application:,,,/Enemies/Behemoth.png"));
                                Position2.Visibility = Visibility.Hidden;
                                break;
                            case "Red Dragon":
                                Position3.Source = new BitmapImage(new Uri("pack://application:,,,/Enemies/Red_Dragon.png"));
                                Position2.Visibility = Visibility.Hidden;
                                break;
                            case "Death Puppet":
                                Position3.Source = new BitmapImage(new Uri("pack://application:,,,/Enemies/Death_Puppet.png"));
                                Position2.Visibility = Visibility.Hidden;
                                break;
                            case "Gorgon":
                                Position3.Source = new BitmapImage(new Uri("pack://application:,,,/Enemies/Gorgon.png"));
                                Position2.Visibility = Visibility.Hidden;
                                break;
                        }
                    }
                }
            }
        }

        public void StrongFromEnemy1(int vyber, Button Enemy1, Button Enemy2, Label Position1HP, Label Position2HP, Label DMGArdyn, Label DMGEnemy, ProgressBar HP_Bar, Image Position1, Image Position2, Image Position3, Image Position4)
        {
            string enemy1 = Enemy1.Content.ToString();
            string enemy2 = Enemy2.Content.ToString();

            Random StrongHitchance1 = new Random(); // Normal Attack -> 30% Chance, 25-30 DMG
            Random StrongDamage1 = new Random();

            int strongHitchance1 = StrongHitchance1.Next(1, 30);
            int strongDamage1 = StrongDamage1.Next(25, 31);

            if (enemy1 == "Hundlegs" || enemy1 == "Blood Flower" || enemy1 == "Ghoul" || enemy1 == "Stone Golem" || enemy1 == "Wicked Mask" || enemy1 == "Trap Door" || enemy1 == "Black Knigh")
            {
                int.TryParse(Position1HP.Content.ToString(), out int Position1HP_P);

                if (Position1HP_P > 0)
                {
                    if (strongHitchance1 <= 30)
                    {
                        double HPS = HP_Bar.Value;
                        DMGArdyn.Content = "-" + strongDamage1;

                        HPS -= strongDamage1;

                        switch (enemy1)
                        {
                            case "Hundlegs":
                                Position3.Source = new BitmapImage(new Uri("pack://application:,,,/Enemies/Hundlegs.png"));
                                Position1.Visibility = Visibility.Hidden;
                                break;
                            case "Blood Flower":
                                Position3.Source = new BitmapImage(new Uri("pack://application:,,,/Enemies/Blood_Flower.png"));
                                Position1.Visibility = Visibility.Hidden;
                                break;
                            case "Ghoul":
                                Position3.Source = new BitmapImage(new Uri("pack://application:,,,/Enemies/Ghoul.png"));
                                Position1.Visibility = Visibility.Hidden;
                                break;
                            case "Stone Golem":
                                Position3.Source = new BitmapImage(new Uri("pack://application:,,,/Enemies/Stone_Golem.png"));
                                Position1.Visibility = Visibility.Hidden;
                                break;
                            case "Wicked Mask":
                                Position3.Source = new BitmapImage(new Uri("pack://application:,,,/Enemies/Wicked_Mask.png"));
                                Position1.Visibility = Visibility.Hidden;
                                break;
                            case "Trap Door":
                                Position3.Source = new BitmapImage(new Uri("pack://application:,,,/Enemies/Trap_Door.png"));
                                Position1.Visibility = Visibility.Hidden;
                                break;
                            case "Black Knigh":
                                Position3.Source = new BitmapImage(new Uri("pack://application:,,,/Enemies/Black_Knight.png"));
                                Position1.Visibility = Visibility.Hidden;
                                break;                            
                        }
                    }
                    else
                    {
                        DMGArdyn.Content = "MISS";

                        switch (enemy1)
                        {
                            case "Hundlegs":
                                Position3.Source = new BitmapImage(new Uri("pack://application:,,,/Enemies/Hundlegs.png"));
                                Position1.Visibility = Visibility.Hidden;
                                break;
                            case "Blood Flower":
                                Position3.Source = new BitmapImage(new Uri("pack://application:,,,/Enemies/Blood_Flower.png"));
                                Position1.Visibility = Visibility.Hidden;
                                break;
                            case "Ghoul":
                                Position3.Source = new BitmapImage(new Uri("pack://application:,,,/Enemies/Ghoul.png"));
                                Position1.Visibility = Visibility.Hidden;
                                break;
                            case "Stone Golem":
                                Position3.Source = new BitmapImage(new Uri("pack://application:,,,/Enemies/Stone_Golem.png"));
                                Position1.Visibility = Visibility.Hidden;
                                break;
                            case "Wicked Mask":
                                Position3.Source = new BitmapImage(new Uri("pack://application:,,,/Enemies/Wicked_Mask.png"));
                                Position1.Visibility = Visibility.Hidden;
                                break;
                            case "Trap Door":
                                Position3.Source = new BitmapImage(new Uri("pack://application:,,,/Enemies/Trap_Door.png"));
                                Position1.Visibility = Visibility.Hidden;
                                break;
                            case "Black Knigh":
                                Position3.Source = new BitmapImage(new Uri("pack://application:,,,/Enemies/Black_Knight.png"));
                                Position1.Visibility = Visibility.Hidden;
                                break;
                        }
                    }
                }
            }
        }
        public void StrongFromEnemy2(int vyber, Button Enemy1, Button Enemy2, Label Position1HP, Label Position2HP, Label DMGArdyn, Label DMGEnemy, ProgressBar HP_Bar, Image Position1, Image Position2, Image Position3, Image Position4)
        {
            string enemy1 = Enemy1.Content.ToString();
            string enemy2 = Enemy2.Content.ToString();

            Random StrongHitchance2 = new Random(); // Normal Attack -> 30% Chance, 25-30 DMG
            Random StrongDamage2 = new Random();

            int strongHitchance2 = StrongHitchance2.Next(1, 30);
            int strongDamage2 = StrongDamage2.Next(25, 31);

            if (enemy2 == "Hundlegs" || enemy2 == "Blood Flower" || enemy2 == "Ghoul" || enemy2 == "Stone Golem" || enemy2 == "Wicked Mask" || enemy2 == "Trap Door" || enemy2 == "Black Knigh")
            {
                int.TryParse(Position2HP.Content.ToString(), out int Position2HP_P);

                if (Position2HP_P > 0)
                {
                    if (strongHitchance2 <= 30)
                    {
                        double HPS = HP_Bar.Value;
                        DMGArdyn.Content = "-" + strongDamage2;

                        HPS -= strongDamage2;

                        switch (enemy2)
                        {
                            case "Hundlegs":
                                Position3.Source = new BitmapImage(new Uri("pack://application:,,,/Enemies/Hundlegs.png"));
                                Position2.Visibility = Visibility.Hidden;
                                break;
                            case "Blood Flower":
                                Position3.Source = new BitmapImage(new Uri("pack://application:,,,/Enemies/Blood_Flower.png"));
                                Position2.Visibility = Visibility.Hidden;
                                break;
                            case "Ghoul":
                                Position3.Source = new BitmapImage(new Uri("pack://application:,,,/Enemies/Ghoul.png"));
                                Position2.Visibility = Visibility.Hidden;
                                break;
                            case "Stone Golem":
                                Position3.Source = new BitmapImage(new Uri("pack://application:,,,/Enemies/Stone_Golem.png"));
                                Position2.Visibility = Visibility.Hidden;
                                break;
                            case "Wicked Mask":
                                Position3.Source = new BitmapImage(new Uri("pack://application:,,,/Enemies/Wicked_Mask.png"));
                                Position2.Visibility = Visibility.Hidden;
                                break;
                            case "Trap Door":
                                Position3.Source = new BitmapImage(new Uri("pack://application:,,,/Enemies/Trap_Door.png"));
                                Position2.Visibility = Visibility.Hidden;
                                break;
                            case "Black Knigh":
                                Position3.Source = new BitmapImage(new Uri("pack://application:,,,/Enemies/Black_Knight.png"));
                                Position2.Visibility = Visibility.Hidden;
                                break;
                        }
                    }
                    else
                    {
                        DMGArdyn.Content = "MISS";

                        switch (enemy2)
                        {
                            case "Hundlegs":
                                Position3.Source = new BitmapImage(new Uri("pack://application:,,,/Enemies/Hundlegs.png"));
                                Position2.Visibility = Visibility.Hidden;
                                break;
                            case "Blood Flower":
                                Position3.Source = new BitmapImage(new Uri("pack://application:,,,/Enemies/Blood_Flower.png"));
                                Position2.Visibility = Visibility.Hidden;
                                break;
                            case "Ghoul":
                                Position3.Source = new BitmapImage(new Uri("pack://application:,,,/Enemies/Ghoul.png"));
                                Position2.Visibility = Visibility.Hidden;
                                break;
                            case "Stone Golem":
                                Position3.Source = new BitmapImage(new Uri("pack://application:,,,/Enemies/Stone_Golem.png"));
                                Position2.Visibility = Visibility.Hidden;
                                break;
                            case "Wicked Mask":
                                Position3.Source = new BitmapImage(new Uri("pack://application:,,,/Enemies/Wicked_Mask.png"));
                                Position2.Visibility = Visibility.Hidden;
                                break;
                            case "Trap Door":
                                Position3.Source = new BitmapImage(new Uri("pack://application:,,,/Enemies/Trap_Door.png"));
                                Position2.Visibility = Visibility.Hidden;
                                break;
                            case "Black Knigh":
                                Position3.Source = new BitmapImage(new Uri("pack://application:,,,/Enemies/Black_Knight.png"));
                                Position2.Visibility = Visibility.Hidden;
                                break;
                        }
                    }
                }
            }
        }
    }
}
