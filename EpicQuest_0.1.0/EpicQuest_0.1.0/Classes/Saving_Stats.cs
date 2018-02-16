using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FileHelpers;

namespace EpicQuest_0._1._0.Classes
{
    public class Saving_Stats
    {
        public void CSVWrite_Stats(List<SavingType_Stats> score)
        {
            var engine = new FileHelperEngine<SavingType_Stats>();
            engine.WriteFile("Save_Stats.csv", score);
        }
        public void CSVRead_Stats(List<int> load)
        {
            var engine = new FileHelperEngine<SavingType_Stats>();
            var result = engine.ReadFile("Save_Stats.csv");

            foreach (SavingType_Stats points in result)
            {
                load.Add(points.Lvl);
                load.Add(points.CurrentHP);
                load.Add(points.MaxHP);
                load.Add(points.CurrentAP);
                load.Add(points.MaxAP);
                load.Add(points.CurrentEXP);
                load.Add(points.MaxEXP);
                load.Add(points.FinishedLvls);
            }
        }
    }
}
