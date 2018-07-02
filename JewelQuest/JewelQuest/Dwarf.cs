using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JewelQuest
{
    public class Dwarf
    {
        //member variables (has a)
        public string dwarfName;
        public string adventureSelection;
        Swamp swamp;
        Mines mines;


        //constuctor (spawner)
        public Dwarf()
        {

        }
        


        //member methods(actions)
        public void DwarfIntroduction()
        {
            dwarfName = "Frauld the Mountain Dwarf";
            Console.WriteLine("You have selected " + dwarfName + " a wise choice. Frauld has tremendous strength from years of mining obsidian from Mount Skull.\nMountain Dwarves are known for their fearless and at times reckless aggression.\n\nHowever, they have proven themselves capable of succeeding in the face of daunting odds and obstacles.\n\nThe Wisdom Jewel calls as it will bring your people back to its former greatness!");
            Console.ReadLine();
            AdventureSelector();
        }
        public void AdventureSelector()
        {
            Console.WriteLine("\n\nFrauld sets off on his quest for the Wisdom Jewel and must make his first choice:\n\nThe path through the Swamp Lands of Dumain or Ancient Mines of Korinth.\n\n Each path presents its own unique foes and potential obstacles.\n\nType swamp or mines to continue your quest!");
            string adventureSelection = Console.ReadLine();
            switch (adventureSelection)
            {
                case "swamp":
                    swamp = new Swamp();
                    swamp.SwampAdventure(this);
                    break;
                case "mines":
                    mines = new Mines();
                    mines.MineAdventure(this);
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
