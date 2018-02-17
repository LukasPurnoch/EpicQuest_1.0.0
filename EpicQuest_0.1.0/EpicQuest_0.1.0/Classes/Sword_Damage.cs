using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FileHelpers;

namespace EpicQuest_0._1._0.Classes
{
    class Sword_Damage
    {
        Ardyn_Attack AA = new Ardyn_Attack();

        public int damageUp;

        List<SavingType_Shop> save_shop = new List<SavingType_Shop>();
        List<int> load_shop = new List<int>();

        public void DamageBySword()
        {
            Saving_Shop saving_shop = new Saving_Shop();
            saving_shop.CSVRead_Shop(load_shop);
            
            damageUp = load_shop[4] * 2;

            AA.damageFromSword = damageUp;
        }
    }
}
