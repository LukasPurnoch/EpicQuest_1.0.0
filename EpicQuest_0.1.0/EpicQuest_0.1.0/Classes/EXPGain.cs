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
    class EXPGain
    {
        Ardyn_Attack AA = new Ardyn_Attack();

        public void EXPGain1(Button Enemy1, ProgressBar EXP_Bar, Label LEVEL)
        {
            int max_lvl = 30;
            string enemy1 = Enemy1.Content.ToString();

            double exp = EXP_Bar.Value;
            double max_exp = EXP_Bar.Maximum;
            
            switch (enemy1)
            {
                case "Hundlegs":
                    exp += 10;
                    break;
                case "Gigantoad":
                    exp += 5;
                    break;
                case "Death Flower":
                    exp += 5;
                    break;
                case "Blood Flower":
                    exp += 5;
                    break;
                case "Flying Eyes":
                    exp += 5;
                    break;
                case "Ghoul":
                    exp += 15;
                    break;
                case "Lilith":
                    exp += 10;
                    break;
                case "Hydra":
                    exp += 10;
                    break;
                case "Stone Golem":
                    exp += 15;
                    break;
                case "Arachne":
                    exp += 10;
                    break;
                case "Ghost Knight":
                    exp += 15;
                    break;
                case "Chimera":
                    exp += 10;
                    break;
                case "Great Malboro":
                    exp += 15;
                    break;
                case "Fiery Hound":
                    exp += 15;
                    break;
                case "Wicked Mask":
                    exp += 15;
                    break;
                case "Behemoth":
                    exp += 10;
                    break;
                case "Magic Dragon":
                    exp += 5;
                    break;
                case "Brachioraidos":
                    exp += 5;
                    break;
                case "Red Dragon":
                    exp += 10;
                    break;
                case "Trap Door":
                    exp += 15;
                    break;
                case "Death Puppet":
                    exp += 15;
                    break;
                case "Eukaryote":
                    exp += 5;
                    break;
                case "Gorgon":
                    exp += 10;
                    break;
                case "Black Knight":
                    exp += 15;
                    break;
                case "Catoblepas":
                    exp += 5;
                    break;
            }

            EXP_Bar.Value = exp;

            if (exp >= max_lvl) // 60 >= 50 => exp 10 => max_lvl 55
            {
                double expNumbers = exp - max_lvl;

                EXP_Bar.Value = exp;

                max_lvl += 5;
                max_exp = max_lvl;

                AA.fastHitchance += 1;
                AA.normalHitchance += 2;
                AA.strongHitchance += 3;


            }
        }

        public void DropMoney2(Button Enemy2, Label Money)
        {
            string enemy2 = Enemy2.Content.ToString();

            int.TryParse(Money.Content.ToString(), out int money);

            switch (enemy2)
            {
                case "Hundlegs":
                    money += 15;
                    break;
                case "Gigantoad":
                    money += 10;
                    break;
                case "Death Flower":
                    money += 10;
                    break;
                case "Blood Flower":
                    money += 10;
                    break;
                case "Flying Eyes":
                    money += 10;
                    break;
                case "Ghoul":
                    money += 20;
                    break;
                case "Lilith":
                    money += 15;
                    break;
                case "Hydra":
                    money += 15;
                    break;
                case "Stone Golem":
                    money += 20;
                    break;
                case "Arachne":
                    money += 15;
                    break;
                case "Ghost Knight":
                    money += 20;
                    break;
                case "Chimera":
                    money += 15;
                    break;
                case "Great Malboro":
                    money += 20;
                    break;
                case "Fiery Hound":
                    money += 20;
                    break;
                case "Wicked Mask":
                    money += 20;
                    break;
                case "Behemoth":
                    money += 15;
                    break;
                case "Magic Dragon":
                    money += 10;
                    break;
                case "Brachioraidos":
                    money += 10;
                    break;
                case "Red Dragon":
                    money += 15;
                    break;
                case "Trap Door":
                    money += 20;
                    break;
                case "Death Puppet":
                    money += 20;
                    break;
                case "Eukaryote":
                    money += 10;
                    break;
                case "Gorgon":
                    money += 15;
                    break;
                case "Black Knight":
                    money += 20;
                    break;
                case "Catoblepas":
                    money += 10;
                    break;
            }
            Money.Content = money;
        }
    }
}
