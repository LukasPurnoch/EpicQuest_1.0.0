using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FileHelpers;

namespace EpicQuest_0._1._0.Classes
{
    [DelimitedRecord(",")]
    public class SavingType_Stats
    {
        public int Lvl;
        public int CurrentHP;
        public int MaxHP;
        public int CurrentAP;
        public int MaxAP;
        public int CurrentEXP;
        public int MaxEXP;
        public int FinishedLvls;
    }
}
