using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JewelQuest
{
    public class Mountain
    {
        //member variables (has a)
        readonly Wizard wizard;
        public string wizardName;
        public string puzzleSelection;
    

        //constuctor (spawner)
        public Mountain()
        {
            
        }

        //member methods(actions)
        public void MountainAdventure(Wizard wizard)
        {
            Console.WriteLine("\n\nYou have selected the mountain.\n\nYou have three options to traverse this mountain:\n\nThe eastern trail:\nThis would be much less difficult a climb but you heard an old foe might be calling it home.\n\nThe northern trail:\nAn extremely difficult climb, but no great reward comes without struggle right?\n\nThe western trail:\nA cave entrance cuts down the time for your journey in half.\n\nType east, north, or west. Chose your path and discover your fate!");
            string puzzleSelection = Console.ReadLine();
            switch (puzzleSelection)
            {
                case "east":
                    Console.WriteLine("EPIC FAIL: The Grilzar The Black, a dark and extremely powerful wizard, has set his homestead down this eastern path. He quickly senses you in the area. His magic is far superior and more powerful than yours. He blasts you in the air firing a blue orb of thunderous energy. You sail miles away and now need to abandon your journey to heal in a nearby Elven kingdom.");
                    Console.ReadLine();
                    break;
                case "north":
                    Console.WriteLine("You somehow manage to traverse the rugged frozen rock and reach the pinnacle of the mountain.\nThe path looks much smoother ahead, however a shadow hovers over you and the warm breath of a beast hits the back of your neck./nYou turn to discover the piercing blue eyes of Corin the Northern Skin Changer./nWhile in his current form, he resembles a kodiak and his extremely unpredicable in his behavior.\nHe easily wrestles to the ground, but you cast a spell on the trees surrounding you and vines pull the beast from you and trap him in a cage of vegetation.\nOnce he calms he returns to his human form. After informing him of your quest, he tells you he has the Wisdom Jewel. He agrees to turn it over to you for safe keeping.");
                    Console.ReadLine();
                    break;
                case "west":
                    Console.WriteLine("EPIC FAIL: The western cave is now home to a all powerful mighty dragon. It consumes you in an all encompassing fire and devours your scorched flesh.");
                    Console.ReadLine();
                    break;
                default:
                    Console.WriteLine("Please enter your selection carefully, check spelling and case sensitivity.");
                    Console.ReadLine();
                    MountainAdventure(wizard);
                    break;
            }
          
        }
    }
}
 