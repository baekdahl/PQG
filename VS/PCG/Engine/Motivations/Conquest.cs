using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Conquest
    {
        private int CallofConquest { get; set; }

        public Conquest(int callofConquest)
        {
            CallofConquest = callofConquest;
        }

        public string returnMsg()
        {
            switch (CallofConquest + 1)
            {
            case 1:
                GoTo GOTO = new GoTo(RandomNumberGenerator.NumberBetween(0, 2));
                return "Conquest 1: (Attack enemy) \n" + GOTO.returnMsg() + "Damage the Enemy \n" + "\n";

            case 2:
                GoTo GOTO2 = new GoTo(RandomNumberGenerator.NumberBetween(0, 2));
                steal Steal = new steal(RandomNumberGenerator.NumberBetween(0, 1));
                GoTo GOTO3 = new GoTo(RandomNumberGenerator.NumberBetween(0, 2));
                return "Conquest 2: (Steal stuff) \n" + GOTO2.returnMsg() + Steal.returnMsg() + GOTO3.returnMsg() + "Give ITEM to NPC \n" + "\n";

            default:
                return "Something went wrong, in Comfort";
            }
        }
    }
}
