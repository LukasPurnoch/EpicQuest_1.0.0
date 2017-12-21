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
    public class Enemy_Generator : Pages.Dungeon
    {
        public void EnemyGen(int cavetype, Image Position1, Image Position2, Label Position1HP, Label Position2HP) // 1-Dungeon, 2-Forest, 3-Catacombs, 4-Depths, 5-Cave, 6-All
        {

            //EnemyType.Next(1, 6)

            Random EnemyType = new Random();
            int enemytype1 = 1;
            int enemytype2 = 1;

            if (cavetype == 1)
            {
                if (enemytype1 == 1)
                {
                    Position1.Source = new BitmapImage(new Uri("pack://application:,,,/Enemies/Behemoth.png"));
                    //Position?

                    Position1HP.Content = "90";
                }

                if (enemytype2 == 1)
                {
                    Position2.Source = new BitmapImage(new Uri("pack://application:,,,/Enemies/Behemoth.png"));
                    //Position?

                    Position2HP.Content = "90";
                }
            }



        }
    }
}
