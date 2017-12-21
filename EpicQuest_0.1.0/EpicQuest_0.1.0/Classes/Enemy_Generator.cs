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
    class Enemy_Generator : Pages.Dungeon
    {
        public void EnemyGen(int cavetype, Label Position1, Label Position2, Label Position1HP, Label Position2HP) // 1-Dungeon, 2-Forest, 3-Catacombs, 4-Depths, 5-Cave, 6-All
        {
            if (cavetype == 1)
            {
                Random EnemyType = new Random();
                int enemytype1 = EnemyType.Next(1, 6);
                int enemytype2 = EnemyType.Next(1, 6);

                if (enemytype1 == 1)
                {
                    //Source
                    //Position

                    //HP Set
                }
                if (enemytype2 == 1)
                {
                    //Source
                    //Position

                    //HP Set
                }
            }



        }
    }
}
