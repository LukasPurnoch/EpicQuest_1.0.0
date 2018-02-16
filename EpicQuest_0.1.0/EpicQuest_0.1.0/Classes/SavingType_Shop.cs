using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FileHelpers;

namespace EpicQuest_0._1._0.Classes
{
    [DelimitedRecord(",")]
    public class SavingType_Shop
    {
        public int Money;
        public int APPotions;
        public int HPPotions;
    }
}
