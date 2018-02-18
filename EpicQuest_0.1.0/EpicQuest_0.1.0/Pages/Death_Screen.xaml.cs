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
    /// Interakční logika pro Death_Screen.xaml
    /// </summary>
    public partial class Death_Screen : Page
    {
        public Death_Screen()
        {
            InitializeComponent();

            MediaPlayer.Source = new Uri(@"C:\Users\bfoty\Source\Repos\EpicQuest_1.0.0\EpicQuest_0.1.0\EpicQuest_0.1.0\Sounds\DeathScreen.mp3");
            MediaPlayer.Play();
        }

        private void Continue_Click(object sender, RoutedEventArgs e)
        {
            MediaPlayer.Stop();
            Died.Content = new Map();
        }
        private void Menu_Click(object sender, RoutedEventArgs e)
        {
            MediaPlayer.Stop();
            Died.Content = new MainMenu();
        }
    }
}
