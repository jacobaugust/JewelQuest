using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JewelQuest
{
    public class Wizard
    {
        //member variables (has a)
        public string wizardName;
        public string adventureSelection;
        Mountain mountain;
        Forest forest;


        //constuctor (spawner)
        public Wizard()
        {
           
        }


        //member methods(actions)
        public void WizardIntroduction()
        {
            wizardName = "Verithin The Gray";
            Console.WriteLine("\n\nYou have selected " + wizardName + " a wise choice.\nVerithin can leverage lessons learned from all his previous experiences. Ages have past since his last adventure, he values aggression as a last resort.\n\nHowever, he understands the importance of the Wisdom Jewel and the incredible power it yields. He will not see it fall into the wrong hands!");
            Console.ReadLine();
        }
        public void AdventureSelector()
        {
            Console.WriteLine("\n\nVerithin sets off on his quest for the Wisdom Jewel and must make his first choice:\nthe path through the caves of Mount Skull or the Enchanted Forest of Galidon.\n\nEach path presents its own unique foes and potential obstacles.\n\nType mountain or forest to continue your quest!\n\n");
            string adventureSelection = Console.ReadLine();
            switch (adventureSelection)
            {
                case "mountain":
                    mountain = new Mountain();
                    mountain.MountainAdventure(this);
                    break;
                case "forest":
                    forest = new Forest();
                    forest.ForestAdventure(this);
                    break;
                default:
                    Console.WriteLine("Please enter your selection carefully, check spelling and case sensitivity.");
                    Console.ReadLine();
                    AdventureSelector();
                    break;
            }

        }
    }
}
