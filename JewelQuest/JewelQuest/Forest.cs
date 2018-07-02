using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JewelQuest
{
    public class Forest
    {
        //member variables (has a)
        readonly Wizard wizard;
        public string wizardName;
        public string puzzleSelection;
       

        //constuctor (spawner)

        public Forest()
        {
           
        }

        //member methods(actions)
        public void ForestAdventure(Wizard wizard)
        {
            Console.WriteLine("You have selected the forest.\n\n Upon entering the forest, you discover a mysteriuos energy pulsing out of an engraved giant tree trunk. You notice three gems with a corresponding engraving and slot underneath:\nGwilth and a blue gem\nTalv and a golden gem\nGurth and a black gem\n\nType blue, gold, or black.");
            string puzzleSelection = Console.ReadLine();
            switch (puzzleSelection)
            {
                case "blue":
                    Console.WriteLine("A blue smoke fill the air obscuring your vision.\nAn argentavis swoops down from above, cutting through the smoke and grasping you carefully in its sharp talons.\nSoaring higher and higher, it flies you to the top of a cliff where a golden chest emerges from the ground.\nThe chest pulses as the tree trunk did earlier, and as you approach to open it, it explodes with purple light and opens.\n\nInside rests the WISDOM JEWEL!");
                    Console.ReadLine();
                    break;
                case "black":
                    Console.WriteLine("EPIC FAIL: The ground beneath you shakes and crumbles away.\n\nYou find your self landing on a cold hard slab of volcanic rock. A cage of dark black energy bars imprisons you.\nAn army of hunter class Orcs circles you.");
                    Console.ReadLine();
                    break;
                case "gold":
                    Console.WriteLine("EPIC FAIL: An endless wave of Daeodons attacks you from all sides. You are pinned down by this army of vicious pigs.\n\n With every Daeodon you kill two more seem to spawn in its place. This battle seems to never cease.");
                    Console.ReadLine();
                    break;
                default:
                    Console.WriteLine("Please enter your selection carefully, check spelling and case sensitivity.");
                    Console.ReadLine();
                    ForestAdventure(wizard);
                    break;
            }
           
        }
    }
}
  