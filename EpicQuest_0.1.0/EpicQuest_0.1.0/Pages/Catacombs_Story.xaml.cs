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
    /// Interakční logika pro Catacombs_Story.xaml
    /// </summary>
    public partial class Catacombs_Story : Page
    {
        public int increment4;
        public int stop;

        public Catacombs_Story()
        {
            InitializeComponent();

            MediaPlayer.Source = new Uri(@"C:\Users\bfoty\Source\Repos\EpicQuest_1.0.0\EpicQuest_0.1.0\EpicQuest_0.1.0\Sounds\Victory.mp3");
            MediaPlayer.Play();

            TimeStart4();
        }

        public void Time_Tick4(object sender, EventArgs e)
        {
            increment4++;

            CLOCK1.Content = increment4;

            if (increment4 % 8 == 0)
            {
                Text1.Visibility = Visibility.Hidden;
                Text2.Visibility = Visibility.Visible;
            }
            if (increment4 % 16 == 0)
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

        public void TimeStart4()
        {
            DispatcherTimer Time4 = new DispatcherTimer();
            Time4.Interval = TimeSpan.FromSeconds(1);
            Time4.Tick += Time_Tick4;
            Time4.Start();
        }
    }
}
