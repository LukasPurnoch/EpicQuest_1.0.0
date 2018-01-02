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

namespace EpicQuest_0._1._0.Pages
{
    /// <summary>
    /// Interakční logika pro Forest.xaml
    /// </summary>
    public partial class Forest : Page
    {
        public Forest()
        {
            InitializeComponent();

            Level();
            Attacks();
        }

        private void Level()
        {
            Classes.Enemy_Generator gen = new Classes.Enemy_Generator();
            gen.EnemyGen(2, Position1, Position2, Position1HP, Position2HP, Enemy1, Enemy2);
        }

        private void Attacks()
        {
            Classes.Attack_From_Enemy att = new Classes.Attack_From_Enemy();

            att.LightFromEnemy(1, Enemy1, Enemy2, Position1HP, Position2HP, DMGArdyn, DMGEnemy, HP_Bar, Position1, Position2, Position3, Position4);
        }
    }
}
