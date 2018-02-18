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
    /// Interakční logika pro Forest_Story.xaml
    /// </summary>
    public partial class Forest_Story : Page
    {
        public int increment1;
        public int stop;

        public Forest_Story()
        {
            InitializeComponent();

            MediaPlayer.Source = new Uri(@"C:\Users\bfoty\Source\Repos\EpicQuest_1.0.0\EpicQuest_0.1.0\EpicQuest_0.1.0\Sounds\Victory.mp3");
            MediaPlayer.Play();

            TimeStart1();
        }

        public void Time_Tick1(object sender, EventArgs e)
        {
            increment1++;

            CLOCK1.Content = increment1;

            if (increment1 % 8 == 0)
            {
                Text1.Visibility = Visibility.Hidden;
                Text2.Visibility = Visibility.Visible;
            }
            if (increment1 % 16 == 0)
            {                
                if (stop == 0)
                {
                    MediaPlayer.Stop();
                    ForestStory.Content = new Map();
                }
                if (stop == 1)
                {

                }

                stop = 1;
                
            }
        }

        public void TimeStart1()
        {
            DispatcherTimer Time1 = new DispatcherTimer();
            Time1.Interval = TimeSpan.FromSeconds(1);
            Time1.Tick += Time_Tick1;
            Time1.Start();
        }
    }
}
