using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JewelQuest
{
    class Program
    {
        static void Main(string[] args)
        {
            CharacterSelectionPhase jewelQuest1 = new CharacterSelectionPhase();
            jewelQuest1.GameIntroduction();
            jewelQuest1.CharacterSelector();

        }
    }
}
