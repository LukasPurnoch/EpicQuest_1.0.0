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

namespace EpicQuest_0._1._0.Pages
{
    /// <summary>
    /// Interakční logika pro Forest.xaml
    /// </summary>
    public partial class Forest : Page
    {
        public int vyber;
        public int increment;

        public Forest()
        {
            InitializeComponent();

            Level();
            TimeStart();
            
        }

        private void Level()
        {
            Classes.Enemy_Generator gen = new Classes.Enemy_Generator();
            gen.EnemyGen(2, Position1, Position2, Position1HP, Position2HP, Enemy1, Enemy2);
        }

        public void Time_Tick(object sender, EventArgs e)
        {
            increment++;

            if (increment % 3 == 0)
            {
                Position4.Source = null;
                Position3.Source = null;
                Ardyn.Visibility = Visibility.Visible;

                Position1.Visibility = Visibility.Visible;
                Position2.Visibility = Visibility.Visible;
            }
        }

        public void TimeStart()
        {
            DispatcherTimer Time = new DispatcherTimer();
            Time.Interval = TimeSpan.FromSeconds(1);
            Time.Tick += Time_Tick;
            Time.Start();
            
        }

        private void Enemy1_Click(object sender, RoutedEventArgs e)
        {
            vyber = 1;
        }

        private void Enemy2_Click(object sender, RoutedEventArgs e)
        {
            vyber = 2;
        }

        private void StrongAtt_Click(object sender, RoutedEventArgs e)
        {
            Classes.Ardyn_Attack ArdAtt = new Classes.Ardyn_Attack();
            ArdAtt.StrongAttack(vyber, DMGEnemy, Position1HP, Position2HP, AP_Bar, Position4, Ardyn, Enemy1, Enemy2, DMGArdyn, HP_Bar, Position1, Position2, Position3);
            increment = 0;
        }

        private void FastAtt_Click(object sender, RoutedEventArgs e)
        {
            Classes.Ardyn_Attack ArdAtt = new Classes.Ardyn_Attack();
            ArdAtt.FastAttack(vyber, DMGEnemy, Position1HP, Position2HP, AP_Bar, Position4, Ardyn, Enemy1, Enemy2, DMGArdyn, HP_Bar, Position1, Position2, Position3);
            increment = 0;
        }

        private void NormalAtt_Click(object sender, RoutedEventArgs e)
        {
            Classes.Ardyn_Attack ArdAtt = new Classes.Ardyn_Attack();
            ArdAtt.NormalAttack(vyber, DMGEnemy, Position1HP, Position2HP, AP_Bar, Position4, Ardyn, Enemy1, Enemy2, DMGArdyn, HP_Bar, Position1, Position2, Position3);
            increment = 0;
        }
    }
}
