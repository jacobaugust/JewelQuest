using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JewelQuest
{
    class Desert
    {
        //member variables (has a)
        public string puzzleSelection;
      

        //constuctor (spawner)
        public Desert()
        {
          
        }


        //member methods(actions)
        public void DesertAdventure(Paladin paladin)
        {
            Console.WriteLine("You have selected the endless desert.\n\n After a long day of navigating the desert the sun has taken its toll, you must choose between three places to seek refuge for the night and rest.\nTo your left, you see a large cresent shaped opening looks like an inviting shaded area to escape the sun.\nThe right offers a large collection of desert rocks to traverse under.\nStraight ahead you see a hole you could slide down to get to cooler air underground. Type left, center, or right.");
            puzzleSelection = Console.ReadLine();
            switch (puzzleSelection)
            {
                case "Left":
                    Console.WriteLine("EPIC FAIL: You enter the space, relaxing and resting in the shade this refuge provides.\nYou close your eyes to rest as night falls, but the sound of tapping claws ring from deep in the darkness.\nA giant scorpion appears, you try to run but it strikes you with its barp and venom flows through your veins.\nYour last breath screams out in horror as the scoprion lifts you from the ground.");
                    Console.ReadLine();
                    break;
                case "center":
                    Console.WriteLine("EPIC FAIL: You slide down the hole grasping on to the sand and digging your heels into the sides to control your speed.\nA welcomed temperature drop provides momentary relief, however as you hit flat ground and regain your footing, you ear a high pitched hiss behind you.\nA titanboa snaps its fangs like a whip sinking them into your shoulders. You feel the venom rushing through your veins, as the giant snake begins to swallow you whole.");
                    Console.ReadLine();
                    break;
                case "right":
                    Console.WriteLine("You feel safe under the rocks, but quickly realize this is home to another creature. A giant horned lizard crawls out from under the rocks.\nIt lunges towards you snapping its jaws at your torso.\nAdrenline rushes through your legs as you quickly leap to higher ground and draw your daggers in each hand.\nDiving down from above, you plunge your dagger into the eyes of the lizard.\nThe lizard throws you off and you slam into the rocks. Gathering yourself, you notice a glowing beam of light exiting the mouth of the lizard.\nThe tongue of the lizard attempts to sense your location. You quickly slip under the lizard and drive both daggers into the lizard's lungs. The lizard cough, a loud high pitched ping rings out in the rocks below./nThe lizard retreates up the mountain. You investage the noise further and discover the same light shining in the desert sun. You found it... THE WISDOM GEM!");
                    Console.ReadLine();
                    break;
                default:
                    Console.WriteLine("Please enter your selection carefully, check spelling and case sensitivity.");
                    Console.ReadLine();
                    DesertAdventure(paladin);
                    break;
            }
           
        }
    }
}