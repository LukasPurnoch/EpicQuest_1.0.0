﻿using System;
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
using FileHelpers;

namespace EpicQuest_0._1._0.Pages
{
    /// <summary>
    /// Interakční logika pro Depths.xaml
    /// </summary>
    public partial class Depths : Page
    {
        public int vyber;
        public int increment;

        private int earned1 = 1;
        private int earned2 = 1;

        private int counter = 0;

        private int sword_count;
        private int armor_count;

        private int levelLevel;

        List<Classes.SavingType_Stats> save_stats = new List<Classes.SavingType_Stats>();
        List<int> load_stats = new List<int>();

        List<Classes.SavingType_Shop> save_shop = new List<Classes.SavingType_Shop>();
        List<int> load_shop = new List<int>();

        public Depths()
        {
            InitializeComponent();

            MediaPlayer.Source = new Uri(@"C:\Users\bfoty\Source\Repos\EpicQuest_1.0.0\EpicQuest_0.1.0\EpicQuest_0.1.0\Sounds\FL5.mp3");
            MediaPlayer.Play();

            Classes.Saving_Stats saving_stats = new Classes.Saving_Stats();
            saving_stats.CSVRead_Stats(load_stats);

            LEVEL.Content = load_stats[0];
            HP_Bar.Value = load_stats[1];
            HP_Bar.Maximum = load_stats[2];
            AP_Bar.Value = load_stats[3];
            AP_Bar.Maximum = load_stats[4];
            EXP_Bar.Value = load_stats[5];
            EXP_Bar.Maximum = load_stats[6];

            Classes.Saving_Shop saving_shop = new Classes.Saving_Shop();
            saving_shop.CSVRead_Shop(load_shop);

            Money.Content = load_shop[0];
            InventoryAPCounter.Content = load_shop[1];
            InventoryHPCounter.Content = load_shop[2];
            armor_count = load_shop[3];
            sword_count = load_shop[4];

            Level();
            TimeStart();
        }

        public void Level()
        {
            counter += 1;

            Classes.Armor_Heal armorHeal = new Classes.Armor_Heal();
            armorHeal.HpByArmor(HP_Bar);

            if (counter == 10)
            {
                Levelcounter.Content = counter;

                Boss.Visibility = Visibility.Visible;

                Enemy1.Visibility = Visibility.Visible;
                Enemy2.Visibility = Visibility.Hidden;

                Enemy1.Content = "Blacknight Captain";
                Position1HP.Content = "650";

                Position1.Source = null;
                Position2.Source = null;

            }
            if (counter < 10)
            {
                Enemy1.Visibility = Visibility.Visible;
                Enemy2.Visibility = Visibility.Visible;

                Classes.Enemy_Generator gen = new Classes.Enemy_Generator();
                gen.EnemyGen(45, 4, Position1, Position2, Position1HP, Position2HP, Enemy1, Enemy2);

                Levelcounter.Content = counter;
            }
            if (counter > 10)
            {
                Classes.SavingType_Stats savingType_Stats = new Classes.SavingType_Stats();

                savingType_Stats.Lvl = Convert.ToInt32(LEVEL.Content);
                savingType_Stats.CurrentHP = Convert.ToInt32(HP_Bar.Value);
                savingType_Stats.MaxHP = Convert.ToInt32(HP_Bar.Maximum);
                savingType_Stats.CurrentAP = Convert.ToInt32(AP_Bar.Value);
                savingType_Stats.MaxAP = Convert.ToInt32(AP_Bar.Maximum);
                savingType_Stats.CurrentEXP = Convert.ToInt32(EXP_Bar.Value);
                savingType_Stats.MaxEXP = Convert.ToInt32(EXP_Bar.Maximum);
                savingType_Stats.FinishedLvls = 4;

                save_stats.Add(savingType_Stats);

                Classes.Saving_Stats saving_stats = new Classes.Saving_Stats();
                saving_stats.CSVWrite_Stats(save_stats);


                Classes.SavingType_Shop savingType_Shop = new Classes.SavingType_Shop();

                savingType_Shop.Money = Convert.ToInt32(Money.Content);
                savingType_Shop.APPotions = Convert.ToInt32(InventoryAPCounter.Content);
                savingType_Shop.HPPotions = Convert.ToInt32(InventoryHPCounter.Content);
                savingType_Shop.Armor = armor_count;
                savingType_Shop.Sword = sword_count;

                save_shop.Add(savingType_Shop);

                Classes.Saving_Shop saving_shop = new Classes.Saving_Shop();
                saving_shop.CSVWrite_Shop(save_shop);

                counter = 0;

                MediaPlayer.Stop();

                Final.Content = new Depths_Story();

            }
        }

        public void Time_Tick(object sender, EventArgs e)
        {
            increment++;

            if (increment % 1 == 0)
            {
                if (counter == 10)
                {
                    Position4.Source = null;
                    Position3.Source = null;

                    Ardyn.Visibility = Visibility.Visible;

                    Boss.Visibility = Visibility.Visible;
                }
                else
                {
                    Position4.Source = null;
                    Position3.Source = null;
                    Ardyn.Visibility = Visibility.Visible;

                    Position1.Visibility = Visibility.Visible;
                    Position2.Visibility = Visibility.Visible;
                }
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
            Classes.Sword_Damage swordDMG = new Classes.Sword_Damage();
            int plusDMGF = swordDMG.DamageBySword(sword_count);

            Classes.Ardyn_Attack ArdAtt = new Classes.Ardyn_Attack();
            ArdAtt.StrongAttack(MediaPlayer, plusDMGF, vyber, DMGEnemy, Position1HP, Position2HP, AP_Bar, HP_Bar, Position4, Ardyn, Enemy1, Enemy2, DMGArdyn, Position1, Position2, Position3, Money, Boss, Final);

            Classes.MoneyDrop MDrop = new Classes.MoneyDrop();
            Classes.EXPGain EGain = new Classes.EXPGain();

            increment = 0;

            int.TryParse(Position1HP.Content.ToString(), out int Position1HP_MM);
            int.TryParse(Position2HP.Content.ToString(), out int Position2HP_MM);

            if (Position1HP_MM <= 0)
            {
                if (earned1 == 1)
                {
                    EGain.EXPGain1(20, Enemy1, EXP_Bar, HP_Bar, LEVEL, MaxHP, NameOfHero, StrongHC, NormalHC, FastHC);
                    MDrop.DropMoney1(20, Enemy1, Money);
                    earned1 = 2;
                }
            }

            if (Position2HP_MM <= 0)
            {
                if (earned2 == 1)
                {
                    EGain.EXPGain2(20, Enemy2, EXP_Bar, HP_Bar, LEVEL, MaxHP, NameOfHero, StrongHC, NormalHC, FastHC);
                    MDrop.DropMoney2(20, Enemy2, Money);
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
            Classes.Sword_Damage swordDMG = new Classes.Sword_Damage();
            int plusDMGF = swordDMG.DamageBySword(sword_count);

            Classes.Ardyn_Attack ArdAtt = new Classes.Ardyn_Attack();
            ArdAtt.FastAttack(MediaPlayer, plusDMGF, vyber, DMGEnemy, Position1HP, Position2HP, AP_Bar, Position4, Ardyn, Enemy1, Enemy2, DMGArdyn, HP_Bar, Position1, Position2, Position3, Money, Boss, Final);

            Classes.MoneyDrop MDrop = new Classes.MoneyDrop();
            Classes.EXPGain EGain = new Classes.EXPGain();

            increment = 0;

            int.TryParse(Position1HP.Content.ToString(), out int Position1HP_MM);
            int.TryParse(Position2HP.Content.ToString(), out int Position2HP_MM);

            if (Position1HP_MM <= 0)
            {
                if (earned1 == 1)
                {
                    EGain.EXPGain1(20, Enemy1, EXP_Bar, HP_Bar, LEVEL, MaxHP, NameOfHero, StrongHC, NormalHC, FastHC);
                    MDrop.DropMoney1(20, Enemy1, Money);
                    earned1 = 2;
                }
            }

            if (Position2HP_MM <= 0)
            {
                if (earned2 == 1)
                {
                    EGain.EXPGain2(20, Enemy2, EXP_Bar, HP_Bar, LEVEL, MaxHP, NameOfHero, StrongHC, NormalHC, FastHC);
                    MDrop.DropMoney2(20, Enemy2, Money);
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
            Classes.Sword_Damage swordDMG = new Classes.Sword_Damage();
            int plusDMGF = swordDMG.DamageBySword(sword_count);

            Classes.Ardyn_Attack ArdAtt = new Classes.Ardyn_Attack();
            ArdAtt.NormalAttack(MediaPlayer, plusDMGF, vyber, DMGEnemy, Position1HP, Position2HP, AP_Bar, Position4, Ardyn, Enemy1, Enemy2, DMGArdyn, HP_Bar, Position1, Position2, Position3, Money, Boss, Final);

            Classes.MoneyDrop MDrop = new Classes.MoneyDrop();
            Classes.EXPGain EGain = new Classes.EXPGain();

            increment = 0;

            int.TryParse(Position1HP.Content.ToString(), out int Position1HP_MM);
            int.TryParse(Position2HP.Content.ToString(), out int Position2HP_MM);

            if (Position1HP_MM <= 0)
            {
                if (earned1 == 1)
                {
                    EGain.EXPGain1(20, Enemy1, EXP_Bar, HP_Bar, LEVEL, MaxHP, NameOfHero, StrongHC, NormalHC, FastHC);
                    MDrop.DropMoney1(20, Enemy1, Money);
                    earned1 = 2;
                }
            }

            if (Position2HP_MM <= 0)
            {
                if (earned2 == 1)
                {
                    EGain.EXPGain2(20, Enemy2, EXP_Bar, HP_Bar, LEVEL, MaxHP, NameOfHero, StrongHC, NormalHC, FastHC);
                    MDrop.DropMoney2(20, Enemy2, Money);
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

        private void HPPotion_Click(object sender, RoutedEventArgs e)
        {
            Classes.Potions PotHP = new Classes.Potions();
            PotHP.HP_Potion(LEVEL, InventoryHPCounter, HP_Bar);
        }

        private void APPotion_Click(object sender, RoutedEventArgs e)
        {
            Classes.Potions PotAP = new Classes.Potions();
            PotAP.AP_Potion(InventoryAPCounter, AP_Bar);
        }

        private void BackToMap_Click(object sender, RoutedEventArgs e)
        {
            Classes.SavingType_Stats savingType_Stats = new Classes.SavingType_Stats();

            savingType_Stats.Lvl = Convert.ToInt32(LEVEL.Content);
            savingType_Stats.CurrentHP = Convert.ToInt32(HP_Bar.Value);
            savingType_Stats.MaxHP = Convert.ToInt32(HP_Bar.Maximum);
            savingType_Stats.CurrentAP = Convert.ToInt32(AP_Bar.Value);
            savingType_Stats.MaxAP = Convert.ToInt32(AP_Bar.Maximum);
            savingType_Stats.CurrentEXP = Convert.ToInt32(EXP_Bar.Value);
            savingType_Stats.MaxEXP = Convert.ToInt32(EXP_Bar.Maximum);

            if (levelLevel > 5)
            {
                savingType_Stats.FinishedLvls = levelLevel;
            }
            else
            {
                savingType_Stats.FinishedLvls = 5;
            }

            save_stats.Add(savingType_Stats);

            Classes.Saving_Stats saving_stats = new Classes.Saving_Stats();
            saving_stats.CSVWrite_Stats(save_stats);


            Classes.SavingType_Shop savingType_Shop = new Classes.SavingType_Shop();

            savingType_Shop.Money = Convert.ToInt32(Money.Content);
            savingType_Shop.APPotions = Convert.ToInt32(InventoryAPCounter.Content);
            savingType_Shop.HPPotions = Convert.ToInt32(InventoryHPCounter.Content);
            savingType_Shop.Armor = armor_count;
            savingType_Shop.Sword = sword_count;

            save_shop.Add(savingType_Shop);

            Classes.Saving_Shop saving_shop = new Classes.Saving_Shop();
            saving_shop.CSVWrite_Shop(save_shop);

            MediaPlayer.Stop();

            Final.Content = new Map();
        }
    }
}
