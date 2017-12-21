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
        public void EnemyGen(int cavetype, Image Position1, Image Position2, Label Position1HP, Label Position2HP, Button Enemy1, Button Enemy2) // 1-Dungeon, 2-Forest, 3-Catacombs, 4-Depths, 5-Cave, 6-All
        {

            Random EnemyType = new Random();
            int enemytype1 = EnemyType.Next(1, 6);
            int enemytype2 = EnemyType.Next(1, 6);

            if (cavetype == 1)
            {
                if (enemytype1 == 1)
                {
                    Position1.Source = new BitmapImage(new Uri("pack://application:,,,/Enemies/Behemoth.png"));

                    Position1HP.Content = "90";
                    Enemy1.Content = "Behemoth";
                }

                if (enemytype2 == 1)
                {
                    Position2.Source = new BitmapImage(new Uri("pack://application:,,,/Enemies/Behemoth.png"));

                    Position2HP.Content = "90";
                    Enemy2.Content = "Behemoth";
                }

                if (enemytype1 == 2)
                {
                    Position1.Source = new BitmapImage(new Uri("pack://application:,,,/Enemies/Magic_Dragon.png"));

                    Position1HP.Content = "65";
                    Enemy1.Content = "Magic Dragon";
                }

                if (enemytype2 == 2)
                {
                    Position2.Source = new BitmapImage(new Uri("pack://application:,,,/Enemies/Magic_Dragon.png"));

                    Position2HP.Content = "65";
                    Enemy2.Content = "Magic Dragon";
                }
                if (enemytype1 == 3)
                {
                    Position1.Source = new BitmapImage(new Uri("pack://application:,,,/Enemies/Brachioraidos.png"));

                    Position1HP.Content = "95";
                    Enemy1.Content = "Brachioraidos";
                }

                if (enemytype2 == 3)
                {
                    Position2.Source = new BitmapImage(new Uri("pack://application:,,,/Enemies/Brachioraidos.png"));

                    Position2HP.Content = "95";
                    Enemy2.Content = "Brachioraidos";
                }

                if (enemytype1 == 4)
                {
                    Position1.Source = new BitmapImage(new Uri("pack://application:,,,/Enemies/Red_Dragon.png"));

                    Position1HP.Content = "80";
                    Enemy1.Content = "Red Dragon";
                }

                if (enemytype2 == 4)
                {
                    Position2.Source = new BitmapImage(new Uri("pack://application:,,,/Enemies/Red_Dragon.png"));

                    Position2HP.Content = "80";
                    Enemy2.Content = "Red Dragon";
                }

                if (enemytype1 == 5)
                {
                    Position1.Source = new BitmapImage(new Uri("pack://application:,,,/Enemies/Trap_Door.png"));

                    Position1HP.Content = "100";
                    Enemy1.Content = "Trap Door";
                }

                if (enemytype2 == 5)
                {
                    Position2.Source = new BitmapImage(new Uri("pack://application:,,,/Enemies/Trap_Door.png"));

                    Position2HP.Content = "100";
                    Enemy2.Content = "Trap Door";
                }
            }

            if (cavetype == 2)
            {
                if (enemytype1 == 1)
                {
                    Position1.Source = new BitmapImage(new Uri("pack://application:,,,/Enemies/Hundlegs.png"));

                    Position1HP.Content = "75";
                    Enemy1.Content = "Hundlegs";
                }

                if (enemytype2 == 1)
                {
                    Position2.Source = new BitmapImage(new Uri("pack://application:,,,/Enemies/Hundlegs.png"));

                    Position2HP.Content = "75";
                    Enemy2.Content = "Hundlegs";
                }

                if (enemytype1 == 2)
                {
                    Position1.Source = new BitmapImage(new Uri("pack://application:,,,/Enemies/Gigantoad.png"));

                    Position1HP.Content = "65";
                    Enemy1.Content = "Gigantoad";
                }

                if (enemytype2 == 2)
                {
                    Position2.Source = new BitmapImage(new Uri("pack://application:,,,/Enemies/Gigantoad.png"));

                    Position2HP.Content = "65";
                    Enemy2.Content = "Gigantoad";
                }
                if (enemytype1 == 3)
                {
                    Position1.Source = new BitmapImage(new Uri("pack://application:,,,/Enemies/Death_Flower.png"));

                    Position1HP.Content = "75";
                    Enemy1.Content = "Death_Flower";
                }

                if (enemytype2 == 3)
                {
                    Position2.Source = new BitmapImage(new Uri("pack://application:,,,/Enemies/Death_Flower.png"));

                    Position2HP.Content = "75";
                    Enemy2.Content = "Death_Flower";
                }

                if (enemytype1 == 4)
                {
                    Position1.Source = new BitmapImage(new Uri("pack://application:,,,/Enemies/Blood_Flower.png"));

                    Position1HP.Content = "80";
                    Enemy1.Content = "Blood_Flower";
                }

                if (enemytype2 == 4)
                {
                    Position2.Source = new BitmapImage(new Uri("pack://application:,,,/Enemies/Blood_Flower.png"));

                    Position2HP.Content = "80";
                    Enemy2.Content = "Blood_Flower";
                }

                if (enemytype1 == 5)
                {
                    Position1.Source = new BitmapImage(new Uri("pack://application:,,,/Enemies/Flying_Eyes.png"));

                    Position1HP.Content = "60";
                    Enemy1.Content = "Flying_Eyes";
                }

                if (enemytype2 == 5)
                {
                    Position2.Source = new BitmapImage(new Uri("pack://application:,,,/Enemies/Flying_Eyes.png"));

                    Position2HP.Content = "60";
                    Enemy2.Content = "Flying_Eyes";
                }
            }

        }
    }
}
