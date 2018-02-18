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
    /// Interakční logika pro Story_2.xaml
    /// </summary>
    public partial class Story_2 : Page
    {
        public int increment;
        public int stop;

        public Story_2()
        {
            InitializeComponent();

            MediaPlayer.Source = new Uri(@"C:\Users\bfoty\Source\Repos\EpicQuest_1.0.0\EpicQuest_0.1.0\EpicQuest_0.1.0\Sounds\StoryTelling2.mp3");
            MediaPlayer.Play();

            TimeStart();
        }

        public void Time_Tick(object sender, EventArgs e)
        {
            increment++;

            CLOCK.Content = increment;

            if (increment % 10 == 0)
            {
                Text1.Visibility = Visibility.Hidden;
                Text2.Visibility = Visibility.Visible;
            }
            if (increment % 20 == 0)
            {
                Text2.Visibility = Visibility.Hidden;
                Text3.Visibility = Visibility.Visible;
            }
            if (increment % 30 == 0)
            {
                if (stop == 0)
                {
                    MediaPlayer.Stop();
                    Map.Content = new MainMenu();
                }
                if (stop == 1)
                {

                }

                stop = 1;
            }
        }

        public void TimeStart()
        {
            DispatcherTimer Time = new DispatcherTimer();
            Time.Interval = TimeSpan.FromSeconds(1);
            Time.Tick += Time_Tick;
            Time.Start();
        }
    }
}
