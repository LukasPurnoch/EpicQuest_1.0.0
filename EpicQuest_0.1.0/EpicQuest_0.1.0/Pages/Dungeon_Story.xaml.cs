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
    /// Interakční logika pro Dungeon_Story.xaml
    /// </summary>
    public partial class Dungeon_Story : Page
    {
        public int increment2;
        public int stop;

        public Dungeon_Story()
        {
            InitializeComponent();

            TimeStart2();
        }

        public void Time_Tick2(object sender, EventArgs e)
        {
            increment2++;

            CLOCK1.Content = increment2;

            if (increment2 % 8 == 0)
            {
                Text1.Visibility = Visibility.Hidden;
                Text2.Visibility = Visibility.Visible;
            }
            if (increment2 % 16 == 0)
            {
                if (stop == 0)
                {
                    ForestStory.Content = new Map();
                }
                if (stop == 1)
                {

                }

                stop = 1;

            }
        }

        public void TimeStart2()
        {
            DispatcherTimer Time2 = new DispatcherTimer();
            Time2.Interval = TimeSpan.FromSeconds(1);
            Time2.Tick += Time_Tick2;
            Time2.Start();
        }
    }
}
