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

        private int earned1 = 1;
        private int earned2 = 1;

        private int counter;

        public Forest()
        {
            InitializeComponent();
            
            Level();
            TimeStart();
        }

        private void Level()
        {
            if (counter >= 10)
            {

            }
            else
            {
                Enemy1.Visibility = Visibility.Visible;
                Enemy2.Visibility = Visibility.Visible;

                Classes.Enemy_Generator gen = new Classes.Enemy_Generator();
                gen.EnemyGen(10, 2, Position1, Position2, Position1HP, Position2HP, Enemy1, Enemy2);

                counter += 1;

                Levelcounter.Content = counter;
            }
        }

        public void Time_Tick(object sender, EventArgs e)
        {
            increment++;

            if (increment % 1 == 0)
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
            ArdAtt.StrongAttack(vyber, DMGEnemy, Position1HP, Position2HP, AP_Bar, HP_Bar, Position4, Ardyn, Enemy1, Enemy2, DMGArdyn, Position1, Position2, Position3, Money);

            Classes.MoneyDrop MDrop = new Classes.MoneyDrop();
            Classes.EXPGain EGain = new Classes.EXPGain();

            increment = 0;

            int.TryParse(Position1HP.Content.ToString(), out int Position1HP_MM);
            int.TryParse(Position2HP.Content.ToString(), out int Position2HP_MM);

            if (Position1HP_MM <= 0)
            {
                if (earned1 == 1)
                {
                    EGain.EXPGain1(Enemy1, EXP_Bar, HP_Bar, LEVEL, MaxHP, NameOfHero, StrongHC, NormalHC, FastHC);
                    MDrop.DropMoney1(Enemy1, Money);
                    earned1 = 2;
                }
            }

            if (Position2HP_MM <= 0)
            {
                if (earned2 == 1)
                {
                    EGain.EXPGain2(Enemy2, EXP_Bar, HP_Bar, LEVEL, MaxHP, NameOfHero, StrongHC, NormalHC, FastHC);
                    MDrop.DropMoney2(Enemy2, Money);
                    earned2 = 2;
                }
            }            

            if (Position1HP_MM <= 0 && Position2HP_MM <= 0)
            {
                earned1 = 1;
                earned2 = 1;

                Level();
            }
        }

        private void FastAtt_Click(object sender, RoutedEventArgs e)
        {
            Classes.Ardyn_Attack ArdAtt = new Classes.Ardyn_Attack();
            ArdAtt.FastAttack(vyber, DMGEnemy, Position1HP, Position2HP, AP_Bar, Position4, Ardyn, Enemy1, Enemy2, DMGArdyn, HP_Bar, Position1, Position2, Position3, Money);

            Classes.MoneyDrop MDrop = new Classes.MoneyDrop();
            Classes.EXPGain EGain = new Classes.EXPGain();

            increment = 0;

            int.TryParse(Position1HP.Content.ToString(), out int Position1HP_MM);
            int.TryParse(Position2HP.Content.ToString(), out int Position2HP_MM);

            if (Position1HP_MM <= 0)
            {
                if (earned1 == 1)
                {
                    EGain.EXPGain1(Enemy1, EXP_Bar, HP_Bar, LEVEL, MaxHP, NameOfHero, StrongHC, NormalHC, FastHC);
                    MDrop.DropMoney1(Enemy1, Money);
                    earned1 = 2;
                }
            }

            if (Position2HP_MM <= 0)
            {
                if (earned2 == 1)
                {
                    EGain.EXPGain2(Enemy2, EXP_Bar, HP_Bar, LEVEL, MaxHP, NameOfHero, StrongHC, NormalHC, FastHC);
                    MDrop.DropMoney2(Enemy2, Money);
                    earned2 = 2;
                }
            }

            if (Position1HP_MM <= 0 && Position2HP_MM <= 0)
            {
                earned1 = 1;
                earned2 = 1;

                Level();
            }
        }

        private void NormalAtt_Click(object sender, RoutedEventArgs e)
        {
            Classes.Ardyn_Attack ArdAtt = new Classes.Ardyn_Attack();
            ArdAtt.NormalAttack(vyber, DMGEnemy, Position1HP, Position2HP, AP_Bar, Position4, Ardyn, Enemy1, Enemy2, DMGArdyn, HP_Bar, Position1, Position2, Position3, Money);

            Classes.MoneyDrop MDrop = new Classes.MoneyDrop();
            Classes.EXPGain EGain = new Classes.EXPGain();

            increment = 0;

            int.TryParse(Position1HP.Content.ToString(), out int Position1HP_MM);
            int.TryParse(Position2HP.Content.ToString(), out int Position2HP_MM);

            if (Position1HP_MM <= 0)
            {
                if (earned1 == 1)
                {
                    EGain.EXPGain1(Enemy1, EXP_Bar, HP_Bar, LEVEL, MaxHP, NameOfHero, StrongHC, NormalHC, FastHC);
                    MDrop.DropMoney1(Enemy1, Money);
                    earned1 = 2;
                }
            }

            if (Position2HP_MM <= 0)
            {
                if (earned2 == 1)
                {
                    EGain.EXPGain2(Enemy2, EXP_Bar, HP_Bar, LEVEL, MaxHP, NameOfHero, StrongHC, NormalHC, FastHC);
                    MDrop.DropMoney2(Enemy2, Money);
                    earned2 = 2;
                }
            }

            if (Position1HP_MM <= 0 && Position2HP_MM <= 0)
            {
                earned1 = 1;
                earned2 = 1;

                Level();
            }
        }
    }
}
