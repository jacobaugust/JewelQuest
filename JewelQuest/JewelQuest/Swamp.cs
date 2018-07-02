using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JewelQuest
{
    class Swamp
    {
        //member variables (has a)
        public string puzzleSelection;
        CharacterSelectionPhase characterSelectionPhase;

        //constuctor (spawner)
        public Swamp()
        {
 
        }

        //member methods(actions)
        public void SwampAdventure(Dwarf dwarf)
        {
            Console.WriteLine("You have selected the swamp lands.\n\n Upon entering the swamp, you discover a mysteriuos ancient artifact it appears to be an Orc skull encased in Obsidian and a strange energy exudes from it.\n\nA giant gate and wall blocks your path, it has three obsidian mantles lined in a row from top to bottom.\n\n The bottom mantle is lined with a green slimy substance,\nthe center mantle is covered in small soft white circular objects no bigger than your finger,\nthe top mantle is very dusty and covered in webs.\n\nType bottom, center, or top to place your obsidian skull and discover your fate.");
            string puzzleSelection = Console.ReadLine();
            switch (puzzleSelection)
            {
                case "bottom":
                    Console.WriteLine("EPIC FAIL: A Beelzebufo, a giant devil frog, materializes magically from the skull.\n\nYou attempt to strike it with your ax but it quickly disarms you with its tongue.\nThe tongue strike creates a stinging sensation in your hands.\nPoison rushes through your veins and you slip into a darkness as you hear the crunching of bones in the jaws of the devil frog.");
                    Console.ReadLine();
                    break;
                case "center":
                    Console.WriteLine("Great success! The small white circular objects explode with a purple light.\nEach of them transform into a glowing army of insects who carry you over the gate.\n\nUpon reaching the otherside a chest is resting an overgrown altar. The insects fly into and are absorbed by the altar causing a great explosion of light and fragments of wood.\n\nYou rub your eyes and refocus your vision to see the Wisdom Jewel restting in all its glory upon the altar!");
                    Console.ReadLine();
                    break;
                case "top":
                    Console.WriteLine("EPIC FAIL:  After placing the skull on the mantle, the webs on the mantle begin to glow read.\nThey grow to massive size and circle you trapping you inside an inescapable web cocoon.\\nA red smoke fills the air as the Broodmother spider enters and feasts on your flesh.");
                    Console.ReadLine();
                    break;
                default:
                    Console.WriteLine("Please enter your selection carefully, check spelling and case sensitivity.");
                    Console.ReadLine();
                    SwampAdventure(dwarf);
                    break;
            }
            
        }
    }
}
