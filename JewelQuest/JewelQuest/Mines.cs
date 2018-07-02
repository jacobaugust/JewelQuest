using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JewelQuest
{
    class Mines
    {
        //member variables (has a)
        public string puzzleSelection;
       


        //constuctor (spawner)
        public Mines()
        {
          
        }

        //member methods(actions)
        public void MineAdventure(Dwarf dwarf)
        {
            Console.WriteLine("You have selected the mines.\n\n Upon entering the mines, you discover an hand engraved oak carriage with rusting bronze trim.\nYou climb inside and begin traveling down the dark, dank tracks of the mines.\n You reach a golden track switch with a sign posted with three arrows, all the text on the signs is in an ancient Elven language you don't understand.\n To the left the tracks appear in poor condition, but you see torch light in the distance. \nThe center track looks in excellent shape, however nothing but darkness ahead./nRight, you have a fair track with a golden sign lit by torch displaying the Elvish phrase (guruthos).\n\n Type left, center, or right and discover your fate.");
            string puzzleSelection = Console.ReadLine();
            switch (puzzleSelection)
            {
                case "left":
                    Console.WriteLine("Excellent you have chosen wisely. You speed down the torch lit tracks jostling back and forth grasping tightly to your War Ax.\n\nA giant crab creature the size of a mountain grizzly appears snatching you from your carriage.\n\nYou quickly plundge your ax into its back cracking the creature open.\n\nA golden substance spills from its wound, as well as a purple light shining from inside its outer shell.\n\nCracking the creature open further, you make your discovery.\n\n It's the WISDOM JEWEL. Finally the Mountain Dwarfs will return to greatness!");
                    Console.ReadLine();
                    break;
                case "center":
                    Console.WriteLine("EPIC FAIL: You speed smoothly down the track only to discover these tracks although smooth have not been completed.\n\nYou fall treacherously to your death down 500 foot mine cliff.");
                    Console.ReadLine();
                    break;
                case "right":
                    Console.WriteLine("EPIC FAIL: You discover the Elvish phrase stands for death. After shortly traveling down the right tracks, your carriage runs over and snaps a worn rope that releases a humongous ax.\n\nThe ax swings down and splitting through your armor and slicing you in half. ");
                    Console.ReadLine();
                    break;
                default:
                    Console.WriteLine("Please enter your selection carefully, check spelling and case sensitivity.");
                    Console.ReadLine();
                    MineAdventure(dwarf);
                    break;
            }
          
            
        }
        }
}
