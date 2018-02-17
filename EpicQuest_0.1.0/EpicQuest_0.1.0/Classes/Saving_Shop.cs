using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FileHelpers;

namespace EpicQuest_0._1._0.Classes
{
    public class Saving_Shop
    {
        public void CSVWrite_Shop(List<SavingType_Shop> score)
        {
            var engine = new FileHelperEngine<SavingType_Shop>();
            engine.WriteFile("Save_Shop.csv", score);
        }
        public void CSVRead_Shop(List<int> load)
        {
            var engine = new FileHelperEngine<SavingType_Shop>();
            var result = engine.ReadFile("Save_Shop.csv");

            foreach (SavingType_Shop points in result)
            {
                load.Add(points.Money);
                load.Add(points.APPotions);
                load.Add(points.HPPotions);
                load.Add(points.Armor);
                load.Add(points.Sword);
            }
        }
    }
}
