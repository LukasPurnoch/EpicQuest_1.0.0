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
    class MoneyDrop
    {
        public void DropMoney1(Button Enemy1, Label Money) {

            string enemy1 = Enemy1.Content.ToString();

            int.TryParse(Money.Content.ToString(), out int money);

            switch (enemy1)
                {
                case "Blacknight Captain":
                    money += 200;
                    break;
                case "Ghostknight Legionaire":
                    money += 200;
                    break;
                case "Trapdoor Leader":
                    money += 100;
                    break;
                case "Lilith the Snake Mistress":
                    money += 80;
                    break;
                case "Hundlegs The Captain":
                    money += 60;
                    break;
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

        public void DropMoney2(Button Enemy2, Label Money)
        {
            string enemy2 = Enemy2.Content.ToString();

            int.TryParse(Money.Content.ToString(), out int money);

            switch (enemy2)
            {
                case "Hundlegs":
                    money += 15;
                    break;
                case "Hundlegs .I.":
                    money += 50;
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
