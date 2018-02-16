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
    /// Interakční logika pro Depths_Story.xaml
    /// </summary>
    public partial class Depths_Story : Page
    {
        public int increment3;
        public int stop;

        public Depths_Story()
        {
            InitializeComponent();

            TimeStart3();
        }

        public void Time_Tick3(object sender, EventArgs e)
        {
            increment3++;

            CLOCK1.Content = increment3;

            if (increment3 % 8 == 0)
            {
                Text1.Visibility = Visibility.Hidden;
                Text2.Visibility = Visibility.Visible;
            }
            if (increment3 % 16 == 0)
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

        public void TimeStart3()
        {
            DispatcherTimer Time3 = new DispatcherTimer();
            Time3.Interval = TimeSpan.FromSeconds(1);
            Time3.Tick += Time_Tick3;
            Time3.Start();
        }
    }
}
