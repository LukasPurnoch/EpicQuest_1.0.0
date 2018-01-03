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
        public int earned1 = 0;
        public int earned2 = 0;

        public void DropMoney(Button Enemy1, Button Enemy2, Label Money, Label Position1HP, Label Position2HP) {

            int.TryParse(Position1HP.Content.ToString(), out int Position1HP_M);
            int.TryParse(Position2HP.Content.ToString(), out int Position2HP_M);

            string enemy1 = Enemy1.Content.ToString();
            string enemy2 = Enemy2.Content.ToString();

            int.TryParse(Money.Content.ToString(), out int money);

            if (Position1HP_M <= 0)
            {
                if (earned1 == 0)
                {
                    earned1 = 1;

                    switch (enemy1)
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

            if (Position2HP_M <= 0)
            {
                if (earned2 == 0)
                {
                    earned2 = 1;

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

    }
}
