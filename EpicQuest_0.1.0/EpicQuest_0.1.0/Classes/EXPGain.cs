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
        
        public void EXPGain1(int variable, Button Enemy1, ProgressBar EXP_Bar, ProgressBar HP_Bar, Label LEVEL, Label MaxHP, Label NameOfHero, Label StrongHC, Label NormalHC, Label FastHC)
        {
            double max_lvl = EXP_Bar.Maximum;
            
            string enemy1 = Enemy1.Content.ToString();

            double exp = EXP_Bar.Value;
            double max_exp = EXP_Bar.Maximum;
            
            switch (enemy1)
            {
                case "Blacknight Captain":
                    exp += 200;
                    break;
                case "Ghostknight Legionaire":
                    exp += 100;
                    break;
                case "Trapdoor Leader":
                    exp += 75;
                    break;
                case "Lilith the Snake Mistress":
                    exp += 60;
                    break;
                case "Hundlegs The Captain":
                    exp += 45;
                    break;
                case "Hundlegs":
                    exp += 10 + variable;
                    break;
                case "Gigantoad":
                    exp += 5 + variable;
                    break;
                case "Death Flower":
                    exp += 5 + variable;
                    break;
                case "Blood Flower":
                    exp += 5 + variable;
                    break;
                case "Flying Eyes":
                    exp += 5 + variable;
                    break;
                case "Ghoul":
                    exp += 15 + variable;
                    break;
                case "Lilith":
                    exp += 10 + variable;
                    break;
                case "Hydra":
                    exp += 10 + variable;
                    break;
                case "Stone Golem":
                    exp += 15 + variable;
                    break;
                case "Arachne":
                    exp += 10 + variable;
                    break;
                case "Ghost Knight":
                    exp += 15 + variable;
                    break;
                case "Chimera":
                    exp += 10 + variable;
                    break;
                case "Great Malboro":
                    exp += 15 + variable;
                    break;
                case "Fiery Hound":
                    exp += 15 + variable;
                    break;
                case "Wicked Mask":
                    exp += 15 + variable;
                    break;
                case "Behemoth":
                    exp += 10 + variable;
                    break;
                case "Magic Dragon":
                    exp += 5 + variable;
                    break;
                case "Brachioraidos":
                    exp += 5 + variable;
                    break;
                case "Red Dragon":
                    exp += 10 + variable;
                    break;
                case "Trap Door":
                    exp += 15 + variable;
                    break;
                case "Death Puppet":
                    exp += 15 + variable;
                    break;
                case "Eukaryote":
                    exp += 5 + variable;
                    break;
                case "Gorgon":
                    exp += 10 + variable;
                    break;
                case "Black Knight":
                    exp += 15 + variable;
                    break;
                case "Catoblepas":
                    exp += 5 + variable;
                    break;
            }

            EXP_Bar.Value = exp;

            if (exp >= max_lvl)
            {
                max_lvl += 5;
                EXP_Bar.Maximum = max_lvl;

                double currentExp = exp - max_lvl;
                EXP_Bar.Value = currentExp;

                int.TryParse(LEVEL.Content.ToString(), out int currentLvl);
                currentLvl += 1;
                LEVEL.Content = currentLvl;

                double maxHP_E = HP_Bar.Maximum;
                double hpUpgrade = ((maxHP_E / 5) / currentLvl) + 10;
                HP_Bar.Maximum = hpUpgrade + maxHP_E;

                int.TryParse(StrongHC.Content.ToString(), out int strongHC);
                int.TryParse(NormalHC.Content.ToString(), out int normalHC);
                int.TryParse(FastHC.Content.ToString(), out int fastHC);

                strongHC += 3;
                StrongHC.Content = strongHC;
                AA.strongHitchance += 3;

                fastHC += 1;
                FastHC.Content = fastHC;
                AA.fastHitchance += 1;

                normalHC += 2;
                NormalHC.Content = normalHC;
                AA.normalHitchance += 2;
                
            }
        }

        public void EXPGain2(int variable, Button Enemy2, ProgressBar EXP_Bar, ProgressBar HP_Bar, Label LEVEL, Label MaxHP, Label NameOfHero, Label StrongHC, Label NormalHC, Label FastHC)
        {
            double max_lvl = EXP_Bar.Maximum;

            string enemy2 = Enemy2.Content.ToString();

            double exp = EXP_Bar.Value;
            double max_exp = EXP_Bar.Maximum;

            switch (enemy2)
            {
                case "Hundlegs":
                    exp += 10 + variable;
                    break;
                case "Gigantoad":
                    exp += 5 + variable;
                    break;
                case "Death Flower":
                    exp += 5 + variable;
                    break;
                case "Blood Flower":
                    exp += 5 + variable;
                    break;
                case "Flying Eyes":
                    exp += 5 + variable;
                    break;
                case "Ghoul":
                    exp += 15 + variable;
                    break;
                case "Lilith":
                    exp += 10 + variable;
                    break;
                case "Hydra":
                    exp += 10 + variable;
                    break;
                case "Stone Golem":
                    exp += 15 + variable;
                    break;
                case "Arachne":
                    exp += 10 + variable;
                    break;
                case "Ghost Knight":
                    exp += 15 + variable;
                    break;
                case "Chimera":
                    exp += 10 + variable;
                    break;
                case "Great Malboro":
                    exp += 15 + variable;
                    break;
                case "Fiery Hound":
                    exp += 15 + variable;
                    break;
                case "Wicked Mask":
                    exp += 15 + variable;
                    break;
                case "Behemoth":
                    exp += 10 + variable;
                    break;
                case "Magic Dragon":
                    exp += 5 + variable;
                    break;
                case "Brachioraidos":
                    exp += 5 + variable;
                    break;
                case "Red Dragon":
                    exp += 10 + variable;
                    break;
                case "Trap Door":
                    exp += 15 + variable;
                    break;
                case "Death Puppet":
                    exp += 15 + variable;
                    break;
                case "Eukaryote":
                    exp += 5 + variable;
                    break;
                case "Gorgon":
                    exp += 10 + variable;
                    break;
                case "Black Knight":
                    exp += 15 + variable;
                    break;
                case "Catoblepas":
                    exp += 5 + variable;
                    break;
            }

            EXP_Bar.Value = exp;

            if (exp >= max_lvl)
            {
                max_lvl += 5;
                EXP_Bar.Maximum = max_lvl;

                double currentExp = exp - max_lvl;
                EXP_Bar.Value = currentExp;

                int.TryParse(LEVEL.Content.ToString(), out int currentLvl);
                currentLvl += 1;
                LEVEL.Content = currentLvl;

                double maxHP_E = HP_Bar.Maximum;
                double hpUpgrade = ((maxHP_E / 5) / currentLvl) + 10;
                HP_Bar.Maximum = hpUpgrade + maxHP_E;

                int.TryParse(StrongHC.Content.ToString(), out int strongHC);
                int.TryParse(NormalHC.Content.ToString(), out int normalHC);
                int.TryParse(FastHC.Content.ToString(), out int fastHC);

                strongHC += 3;
                StrongHC.Content = strongHC;
                AA.strongHitchance += 3;

                fastHC += 1;
                FastHC.Content = fastHC;
                AA.fastHitchance += 1;

                normalHC += 2;
                NormalHC.Content = normalHC;
                AA.normalHitchance += 2;
                
            }
        }
    }
}
