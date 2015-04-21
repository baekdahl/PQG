using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCG
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
            switch (CallofConquest)
            {
                case 1:
                    gotoPCG GOTO = new gotoPCG(RandomNumberGenerator.NumberBetween(1, 4));
                    return "Conquest 1: (Attack enemy) \n" + GOTO.returnMsg() + "\n" + "Damage the Enemy \n" + "\n";

                case 2:
                    gotoPCG GOTO2 = new gotoPCG(RandomNumberGenerator.NumberBetween(1, 4));
                    stealPCG Steal = new stealPCG(RandomNumberGenerator.NumberBetween(1, 3));
                    gotoPCG GOTO3 = new gotoPCG(RandomNumberGenerator.NumberBetween(1, 4));
                    return "Conquest 2: (Steal stuff) \n" + GOTO2.returnMsg() + "\n" + Steal.returnMsg() + "\n" + GOTO3.returnMsg() + "\n" + "Give ITEM to NPC \n" + "\n";

                default:
                    return "Something went wrong, in Conquest";
            }
        }
    }
}
