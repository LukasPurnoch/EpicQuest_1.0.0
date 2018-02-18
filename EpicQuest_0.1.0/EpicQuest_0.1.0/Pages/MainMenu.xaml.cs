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
    /// Interakční logika pro MainMenu.xaml
    /// </summary>
    public partial class MainMenu : Page
    {
        List<Classes.SavingType_Stats> save_stats = new List<Classes.SavingType_Stats>();
        List<int> load_stats = new List<int>();

        List<Classes.SavingType_Shop> save_shop = new List<Classes.SavingType_Shop>();
        List<int> load_shop = new List<int>();

        public MainMenu()
        {
            InitializeComponent();

            MediaPlayer.Source = new Uri(@"C:\Users\bfoty\Source\Repos\EpicQuest_1.0.0\EpicQuest_0.1.0\EpicQuest_0.1.0\Sounds\MainMenu.mp3");
            MediaPlayer.Play();

        }

        private void Reapeatable()
        {
            /*if ()
            {

            }*/
        }

        private void New_Click(object sender, RoutedEventArgs e)
        {
            Classes.SavingType_Stats savingType_Stats = new Classes.SavingType_Stats();

            savingType_Stats.Lvl = 0;
            savingType_Stats.CurrentHP = 600;
            savingType_Stats.MaxHP = 600;
            savingType_Stats.CurrentAP = 300;
            savingType_Stats.MaxAP = 300;
            savingType_Stats.CurrentEXP = 0;
            savingType_Stats.MaxEXP = 15;
            savingType_Stats.FinishedLvls = 0;

            save_stats.Add(savingType_Stats);

            Classes.Saving_Stats saving_stats = new Classes.Saving_Stats();
            saving_stats.CSVWrite_Stats(save_stats);

            /////////////////////////////////////////

            Classes.SavingType_Shop savingType_Shop = new Classes.SavingType_Shop();

            savingType_Shop.Money = 40;
            savingType_Shop.APPotions = 4;
            savingType_Shop.HPPotions = 4;
            savingType_Shop.Armor = 0;
            savingType_Shop.Sword = 0;

            save_shop.Add(savingType_Shop);

            Classes.Saving_Shop saving_shop = new Classes.Saving_Shop();
            saving_shop.CSVWrite_Shop(save_shop);

            MediaPlayer.Stop();
            Game.Content = new Story_1();
        }

        private void Load_Click(object sender, RoutedEventArgs e)
        {
            MediaPlayer.Stop();
            Game.Content = new Map();
        }

        private void myFrame_ContentRendered(object sender, EventArgs e)
        {
            Game.NavigationUIVisibility = NavigationUIVisibility.Hidden;
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Application.Current.Shutdown();
        }
    }
}
