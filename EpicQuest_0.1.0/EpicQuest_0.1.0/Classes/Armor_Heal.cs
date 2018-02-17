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

namespace EpicQuest_0._1._0.Classes
{
    public class Armor_Heal
    {
        List<SavingType_Shop> save_shop = new List<SavingType_Shop>();
        List<int> load_shop = new List<int>();

        public int maxHPArmor;

        public void HpByArmor(ProgressBar HP_Bar)
        {
            Saving_Shop saving_shop = new Saving_Shop();
            saving_shop.CSVRead_Shop(load_shop);

            maxHPArmor = load_shop[3] * 40;

            HP_Bar.Maximum += maxHPArmor;
        }
    }
}
