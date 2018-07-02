using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JewelQuest
{
    public class Paladin
    {
        //member variables (has a)
        public string paladinName;
        public string adventureSelection;
        Desert desert;
        River river;

        //constuctor (spawner)
        public Paladin()
        {
            desert = new Desert();
            river = new River();
        }

        //member methods(actions)
        public void PaladinIntroduction()
        {
            paladinName = "Anduin the Helmsan";
            Console.WriteLine("\n\nYou have selected " + paladinName + " a wise choice. Anduin has spent his life on the water, navigating lands not seen by most any other Paladins. This gives him outstanding insight and knowledge of the land that has gotten him out of some disastrous circumstances. He is level headed and keeps composure in stressful situations\n\n He was recently made aware of the fact that Zilth, the General of the Orc Army, has plans to obtain the Wisdon Jewel and use it to enslave all Paladins. Guide "+ paladinName +" to the jewel before Zilth succeeds!");
            Console.ReadLine();
            AdventureSelector();
        }
        public void AdventureSelector()
        {
            Console.WriteLine("Anduin sets off on his quest for the Wisdom Jewel and must make his first choice: the path through the endless desert or Duin the river through the Elven Kingdom.\n\n Each path presents its own unique foes and potential obstacles.\n\nType desert or river to continue your quest!");
            string adventureSelection = Console.ReadLine();
            switch (adventureSelection)
            {
                case "desert":
                    desert = new Desert();
                    desert.DesertAdventure(this);
                    break;
                case "river":
                    river = new River();
                    river.RiverAdventure(this);
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
