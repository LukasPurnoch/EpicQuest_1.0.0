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
using EpicQuest_0._1._0.Classes;
using System.Windows.Threading;

namespace EpicQuest_0._1._0.Pages
{
    /// <summary>
    /// Interakční logika pro Story_1.xaml
    /// </summary>
    public partial class Story_1 : Page
    {
        public int increment;
        public int stop;

        public Story_1()
        {
            InitializeComponent();

            TimeStart();

            MediaPlayer.Source = new Uri(@"C:\Users\bfoty\Source\Repos\EpicQuest_1.0.0\EpicQuest_0.1.0\EpicQuest_0.1.0\Cinematics\StoryTell_1.mp4");
            MediaPlayer.Play();
        }

        public void Time_Tick(object sender, EventArgs e)
        {
            increment++;

            if (increment % 41 == 0)
            {
                if (stop == 0)
                {
                    MediaPlayer.Stop();
                    Map.Content = new Map();
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
