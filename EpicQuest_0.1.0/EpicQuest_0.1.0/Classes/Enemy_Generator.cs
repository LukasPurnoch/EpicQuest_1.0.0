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

namespace EpicQuest_0._1._0.Classes
{
    public class Enemy_Generator
    {
        public void EnemyGen(int variable, int cavetype, Image Position1, Image Position2, Label Position1HP, Label Position2HP, Button Enemy1, Button Enemy2) // 1-Dungeon, 2-Forest, 3-Catacombs, 4-Depths, 5-Cave
        {
            int health1;
            int health2;

            Random EnemyType = new Random();
            int enemytype1 = EnemyType.Next(1, 6);
            int enemytype2 = EnemyType.Next(1, 6);

            if (cavetype == 1)
            {
                if (enemytype1 == 1)
                {
                    Position1.Source = new BitmapImage(new Uri("pack://application:,,,/Enemies/Behemoth.png"));

                    health1 = 90 + variable;
                    Position1HP.Content = health1;
                    Enemy1.Content = "Behemoth";
                }

                if (enemytype2 == 1)
                {
                    Position2.Source = new BitmapImage(new Uri("pack://application:,,,/Enemies/Behemoth.png"));

                    health2 = 90 + variable;
                    Position2HP.Content = health2;
                    Enemy2.Content = "Behemoth";
                }

                if (enemytype1 == 2)
                {
                    Position1.Source = new BitmapImage(new Uri("pack://application:,,,/Enemies/Magic_Dragon.png"));

                    health1 = 65 + variable;
                    Position1HP.Content = health1;
                    Enemy1.Content = "Magic Dragon";
                }

                if (enemytype2 == 2)
                {
                    Position2.Source = new BitmapImage(new Uri("pack://application:,,,/Enemies/Magic_Dragon.png"));

                    health2 = 65 + variable;
                    Position2HP.Content = health2;
                    Enemy2.Content = "Magic Dragon";
                }
                if (enemytype1 == 3)
                {
                    Position1.Source = new BitmapImage(new Uri("pack://application:,,,/Enemies/Brachioraidos.png"));

                    health1 = 95 + variable;
                    Position1HP.Content = health1;
                    Enemy1.Content = "Brachioraidos";
                }

                if (enemytype2 == 3)
                {
                    Position2.Source = new BitmapImage(new Uri("pack://application:,,,/Enemies/Brachioraidos.png"));

                    health2 = 95 + variable;
                    Position2HP.Content = health2;
                    Enemy2.Content = "Brachioraidos";
                }

                if (enemytype1 == 4)
                {
                    Position1.Source = new BitmapImage(new Uri("pack://application:,,,/Enemies/Red_Dragon.png"));

                    health1 = 80 + variable;
                    Position1HP.Content = health1;
                    Enemy1.Content = "Red Dragon";
                }

                if (enemytype2 == 4)
                {
                    Position2.Source = new BitmapImage(new Uri("pack://application:,,,/Enemies/Red_Dragon.png"));

                    health2 = 80 + variable;
                    Position2HP.Content = health2;
                    Enemy2.Content = "Red Dragon";
                }

                if (enemytype1 == 5)
                {
                    Position1.Source = new BitmapImage(new Uri("pack://application:,,,/Enemies/Trap_Door.png"));

                    health1 = 100 + variable;
                    Position1HP.Content = health1;
                    Enemy1.Content = "Trap Door";
                }

                if (enemytype2 == 5)
                {
                    Position2.Source = new BitmapImage(new Uri("pack://application:,,,/Enemies/Trap_Door.png"));

                    health2 = 100 + variable;
                    Position2HP.Content = health2;
                    Enemy2.Content = "Trap Door";
                }
            }

            if (cavetype == 2)
            {
                if (enemytype1 == 1)
                {
                    Position1.Source = new BitmapImage(new Uri("pack://application:,,,/Enemies/Hundlegs.png"));

                    health1 = 75 + variable;
                    Position1HP.Content = health1;
                    Enemy1.Content = "Hundlegs";
                }

                if (enemytype2 == 1)
                {
                    Position2.Source = new BitmapImage(new Uri("pack://application:,,,/Enemies/Hundlegs.png"));

                    health2 = 75 + variable;
                    Position2HP.Content = health2;
                    Enemy2.Content = "Hundlegs";
                }

                if (enemytype1 == 2)
                {
                    Position1.Source = new BitmapImage(new Uri("pack://application:,,,/Enemies/Gigantoad.png"));

                    health1 = 65 + variable;
                    Position1HP.Content = health1;
                    Enemy1.Content = "Gigantoad";
                }

                if (enemytype2 == 2)
                {
                    Position2.Source = new BitmapImage(new Uri("pack://application:,,,/Enemies/Gigantoad.png"));

                    health2 = 65 + variable;
                    Position2HP.Content = health2;
                    Enemy2.Content = "Gigantoad";
                }
                if (enemytype1 == 3)
                {
                    Position1.Source = new BitmapImage(new Uri("pack://application:,,,/Enemies/Death_Flower.png"));

                    health1 = 75 + variable;
                    Position1HP.Content = health1;
                    Enemy1.Content = "Death Flower";
                }

                if (enemytype2 == 3)
                {
                    Position2.Source = new BitmapImage(new Uri("pack://application:,,,/Enemies/Death_Flower.png"));

                    health2 = 75 + variable;
                    Position2HP.Content = health2;
                    Enemy2.Content = "Death Flower";
                }

                if (enemytype1 == 4)
                {
                    Position1.Source = new BitmapImage(new Uri("pack://application:,,,/Enemies/Blood_Flower.png"));

                    health1 = 80 + variable;
                    Position1HP.Content = health1;
                    Enemy1.Content = "Blood Flower";
                }

                if (enemytype2 == 4)
                {
                    Position2.Source = new BitmapImage(new Uri("pack://application:,,,/Enemies/Blood_Flower.png"));

                    health2 = 80 + variable;
                    Position2HP.Content = health2;
                    Enemy2.Content = "Blood Flower";
                }

                if (enemytype1 == 5)
                {
                    Position1.Source = new BitmapImage(new Uri("pack://application:,,,/Enemies/Flying_Eyes.png"));

                    health1 = 60 + variable;
                    Position1HP.Content = health1;
                    Enemy1.Content = "Flying Eyes";
                }

                if (enemytype2 == 5)
                {
                    Position2.Source = new BitmapImage(new Uri("pack://application:,,,/Enemies/Flying_Eyes.png"));

                    health2 = 60 + variable;
                    Position2HP.Content = health2;
                    Enemy2.Content = "Flying Eyes";
                }
            }

            if (cavetype == 3)
            {
                if (enemytype1 == 1)
                {
                    Position1.Source = new BitmapImage(new Uri("pack://application:,,,/Enemies/Ghost_Knight.png"));

                    health1 = 75 + variable;
                    Position1HP.Content = health1;
                    Enemy1.Content = "Ghost Knight";
                }

                if (enemytype2 == 1)
                {
                    Position2.Source = new BitmapImage(new Uri("pack://application:,,,/Enemies/Ghost_Knight.png"));

                    health2 = 75 + variable;
                    Position2HP.Content = health2;
                    Enemy2.Content = "Ghost Knight";
                }

                if (enemytype1 == 2)
                {
                    Position1.Source = new BitmapImage(new Uri("pack://application:,,,/Enemies/Chimera.png"));

                    health1 = 90 + variable;
                    Position1HP.Content = health1;
                    Enemy1.Content = "Chimera";
                }

                if (enemytype2 == 2)
                {
                    Position2.Source = new BitmapImage(new Uri("pack://application:,,,/Enemies/Chimera.png"));

                    health2 = 90 + variable;
                    Position2HP.Content = health2;
                    Enemy2.Content = "Chimera";
                }
                if (enemytype1 == 3)
                {
                    Position1.Source = new BitmapImage(new Uri("pack://application:,,,/Enemies/Great_Malboro.png"));

                    health1 = 70 + variable;
                    Position1HP.Content = health1;
                    Enemy1.Content = "Great Malboro";
                }

                if (enemytype2 == 3)
                {
                    Position2.Source = new BitmapImage(new Uri("pack://application:,,,/Enemies/Great_Malboro.png"));

                    health2 = 70 + variable;
                    Position2HP.Content = health2;
                    Enemy2.Content = "Great Malboro";
                }

                if (enemytype1 == 4)
                {
                    Position1.Source = new BitmapImage(new Uri("pack://application:,,,/Enemies/Fiery_Hound.png"));

                    health1 = 60 + variable;
                    Position1HP.Content = health1;
                    Enemy1.Content = "Fiery Hound";
                }

                if (enemytype2 == 4)
                {
                    Position2.Source = new BitmapImage(new Uri("pack://application:,,,/Enemies/Fiery_Hound.png"));

                    health2 = 60 + variable;
                    Position2HP.Content = health2;
                    Enemy2.Content = "Fiery Hound";
                }

                if (enemytype1 == 5)
                {
                    Position1.Source = new BitmapImage(new Uri("pack://application:,,,/Enemies/Wicked_Mask.png"));

                    health1 = 95 + variable;
                    Position1HP.Content = health1;
                    Enemy1.Content = "Wicked Mask";
                }

                if (enemytype2 == 5)
                {
                    Position2.Source = new BitmapImage(new Uri("pack://application:,,,/Enemies/Wicked_Mask.png"));

                    health2 = 95 + variable;
                    Position2HP.Content = health2;
                    Enemy2.Content = "Wicked Mask";
                }
            }

            if (cavetype == 4)
            {
                if (enemytype1 == 1)
                {
                    Position1.Source = new BitmapImage(new Uri("pack://application:,,,/Enemies/Death_Puppet.png"));

                    health1 = 80 + variable;
                    Position1HP.Content = health1;
                    Enemy1.Content = "Death Puppet";
                }

                if (enemytype2 == 1)
                {
                    Position2.Source = new BitmapImage(new Uri("pack://application:,,,/Enemies/Death_Puppet.png"));

                    health2 = 80 + variable;
                    Position2HP.Content = health2;
                    Enemy2.Content = "Death Puppet";
                }

                if (enemytype1 == 2)
                {
                    Position1.Source = new BitmapImage(new Uri("pack://application:,,,/Enemies/Eukaryote.png"));

                    health1 = 55 + variable;
                    Position1HP.Content = health1;
                    Enemy1.Content = "Eukaryote";
                }

                if (enemytype2 == 2)
                {
                    Position2.Source = new BitmapImage(new Uri("pack://application:,,,/Enemies/Eukaryote.png"));

                    health2 = 55 + variable;
                    Position2HP.Content = health2;
                    Enemy2.Content = "Eukaryote";
                }
                if (enemytype1 == 3)
                {
                    Position1.Source = new BitmapImage(new Uri("pack://application:,,,/Enemies/Gorgon.png"));

                    health1 = 50 + variable;
                    Position1HP.Content = health1;
                    Enemy1.Content = "Gorgon";
                }

                if (enemytype2 == 3)
                {
                    Position2.Source = new BitmapImage(new Uri("pack://application:,,,/Enemies/Gorgon.png"));

                    health2 = 50 + variable;
                    Position2HP.Content = health2;
                    Enemy2.Content = "Gorgon";
                }

                if (enemytype1 == 4)
                {
                    Position1.Source = new BitmapImage(new Uri("pack://application:,,,/Enemies/Black_Knight.png"));

                    health1 = 85 + variable;
                    Position1HP.Content = health1;
                    Enemy1.Content = "Black Knight";
                }

                if (enemytype2 == 4)
                {
                    Position2.Source = new BitmapImage(new Uri("pack://application:,,,/Enemies/Black_Knight.png"));

                    health2 = 85 + variable;
                    Position2HP.Content = health2;
                    Enemy2.Content = "Black Knight";
                }

                if (enemytype1 == 5)
                {
                    Position1.Source = new BitmapImage(new Uri("pack://application:,,,/Enemies/Catoblepas.png")); //////////////////////////////////////////////////////////

                    health1 = 75 + variable;
                    Position1HP.Content = health1;
                    Enemy1.Content = "Catoblepas";
                }

                if (enemytype2 == 5)
                {
                    Position2.Source = new BitmapImage(new Uri("pack://application:,,,/Enemies/Catoblepas.png"));

                    health2 = 75 + variable;
                    Position2HP.Content = health2;
                    Enemy2.Content = "Catoblepas";
                }
            }

            if (cavetype == 5)
            {
                if (enemytype1 == 1)
                {
                    Position1.Source = new BitmapImage(new Uri("pack://application:,,,/Enemies/Ghoul.png"));

                    health1 = 80 + variable;
                    Position1HP.Content = health1;
                    Enemy1.Content = "Ghoul";
                }

                if (enemytype2 == 1)
                {
                    Position2.Source = new BitmapImage(new Uri("pack://application:,,,/Enemies/Ghoul.png"));

                    health2 = 80 + variable;
                    Position2HP.Content = health2;
                    Enemy2.Content = "Ghoul";
                }

                if (enemytype1 == 2)
                {
                    Position1.Source = new BitmapImage(new Uri("pack://application:,,,/Enemies/Lilith.png"));

                    health1 = 75 + variable;
                    Position1HP.Content = health1;
                    Enemy1.Content = "Lilith";
                }

                if (enemytype2 == 2)
                {
                    Position2.Source = new BitmapImage(new Uri("pack://application:,,,/Enemies/Lilith.png"));

                    health2 = 75 + variable;
                    Position2HP.Content = health2;
                    Enemy2.Content = "Lilith";
                }
                if (enemytype1 == 3)
                {
                    Position1.Source = new BitmapImage(new Uri("pack://application:,,,/Enemies/Hydra.png"));

                    health1 = 80 + variable;
                    Position1HP.Content = health1;
                    Enemy1.Content = "Hydra";
                }

                if (enemytype2 == 3)
                {
                    Position2.Source = new BitmapImage(new Uri("pack://application:,,,/Enemies/Hydra.png"));

                    health2 = 80 + variable;
                    Position2HP.Content = health2;
                    Enemy2.Content = "Hydra";
                }

                if (enemytype1 == 4)
                {
                    Position1.Source = new BitmapImage(new Uri("pack://application:,,,/Enemies/Stone_Golem.png"));

                    health1 = 80 + variable;
                    Position1HP.Content = health1;
                    Enemy1.Content = "Stone Golem";
                }

                if (enemytype2 == 4)
                {
                    Position2.Source = new BitmapImage(new Uri("pack://application:,,,/Enemies/Stone_Golem.png"));

                    health2 = 80 + variable;
                    Position2HP.Content = health2;
                    Enemy2.Content = "Stone Golem";
                }

                if (enemytype1 == 5)
                {
                    Position1.Source = new BitmapImage(new Uri("pack://application:,,,/Enemies/Arachne.png"));

                    health1 = 70 + variable;
                    Position1HP.Content = health1;
                    Enemy1.Content = "Arachne";
                }

                if (enemytype2 == 5)
                {
                    Position2.Source = new BitmapImage(new Uri("pack://application:,,,/Enemies/Arachne.png"));

                    health2 = 70 + variable;
                    Position2HP.Content = health2;
                    Enemy2.Content = "Arachne";
                }
            }
        }
    }
}
