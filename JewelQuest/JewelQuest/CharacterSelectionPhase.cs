using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JewelQuest
{
    class CharacterSelectionPhase
    {
        //member variables (has a)
        public Wizard wizard;
        public Paladin paladin;
        public Dwarf dwarf;
        public string characterSelection;
        

        //constuctor (spawner)
        public CharacterSelectionPhase()
        {
            
        }

        //member methods(actions)
        public void GameIntroduction()
        {
            Console.WriteLine("Welcome to Jewel Quest\n\nA world full of exotic creatures, dangerous traps, and mysterious magic.\nYou will be presented different paths and puzzles on your journey.\nMake selections wisely, if you do you will find the Wisdom Jewel and help your class rule the land.");
            Console.ReadLine();
        }
        public void CharacterSelector()
        {
            Console.WriteLine("Enter the class of character would you like to select:\n\nwizard\npaladin\ndwarf\n\n");
            string characterSelection = Console.ReadLine();
            switch (characterSelection)
                {
                    case "wizard":
                        wizard = new Wizard();
                        wizard.WizardIntroduction();
                        wizard.AdventureSelector();
                        break;
                    case "paladin":
                        paladin = new Paladin();
                        paladin.PaladinIntroduction();
                        paladin.AdventureSelector();
                        break;
                    case "dwarf":
                        dwarf = new Dwarf();
                        dwarf.DwarfIntroduction();
                        dwarf.AdventureSelector();
                        break;
                    default:
                        Console.WriteLine("Please enter your selection carefully, check spelling and case sensitivity.");
                        Console.ReadLine();
                        CharacterSelector();
                        break;
                }

        }
    }
}
