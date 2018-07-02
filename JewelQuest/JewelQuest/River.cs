using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JewelQuest
{
    public class River
    {
        //member variables (has a)
        readonly Paladin paladin;
        public string paladinName;
        public string puzzleSelection;
       

        //constuctor (spawner)
        public River()
        {
         
        }

        //member methods(actions)
        public void RiverAdventure(Paladin paladin)
        {
            paladinName = "Anduin the Helmsan";
            Console.WriteLine("You have selected the river.\n\nSpeeding down the rapids of the Elven river, you use all your strength to keep your raft under control.\nYou are forced to choose which tributary to head down.\nYou know the Wisom Jewel is close, to the right you hear the loud thunderous roar of water rushing.\nDirectly in front of you, a dark ominous cloud looms overhead. Finally to the right, a dense mysterious fog rolls in.\n\nType left, center, or right to guide your raft and discover your fate.");
            string puzzleSelection = Console.ReadLine();
            switch (puzzleSelection)
            {
                case "left":
                    Console.WriteLine("EPIC FAIL: The loud thunderous waters could only mean one thing a great waterfall was ahead.\nYou fall tragically to your death.");
                    Console.ReadLine();
                    break;
                case "center":
                    Console.WriteLine("As you continue forward start ahead, the Dark Elven Lord Asurith fires a flaming arrow grazing your shoulder and finally landing into the bow of your raft.\n You quickly dive into the river and make your way to cover behind a giant mossy boulder on shore.\nYou examine Asurith and see his chest glowing with a brilliant purple light.\nThe Wisdom Jewel is in sight! Underestimating his foe, Asurith rushes Anduin. Although an expert archer, in close quarters you hold the upper hand.\n You draw your dagger and parry Asurrith's attack. While grasping the rear of his cloak, you quickly cut loose the necklace holding the Jewel and slip into the waters./nStaying out of sight underwater, you escape to your raft. The Paladins can now return to greatness!");
                    Console.ReadLine();
                    break;
                case "right":
                    Console.WriteLine("EPIC FAIL: The fog grows more and more dense as you journey down the tributary. You cough and gasp for breath and become lightheaded.\nSlowly your vision fades to black.");
                    Console.ReadLine();
                    break;
                default:
                    Console.WriteLine("Please enter your selection carefully, check spelling and case sensitivity.");
                    Console.ReadLine();
                    RiverAdventure(paladin);
                    break;
            }
            
        }
    }
}