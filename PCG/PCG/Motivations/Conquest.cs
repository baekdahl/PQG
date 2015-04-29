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

        public string returnMsg(out string Questlog)
        {
            switch (CallofConquest)
            {
                case 1:
                    gotoPCG GOTO = new gotoPCG(RandomNumberGenerator.NumberBetween(1, 4));
                    Questlog = "Conquest 1: (Attack enemy) \n" + "We need help taking back the city, from these <enemies>. Can we request your aid in taking back <Location>.";
                    return GOTO.returnMsg() + "\n" + "Damage the Enemy \n";

                case 2:
                    gotoPCG GOTO2 = new gotoPCG(RandomNumberGenerator.NumberBetween(1, 4));
                    stealPCG Steal = new stealPCG(RandomNumberGenerator.NumberBetween(1, 3));
                    gotoPCG GOTO3 = new gotoPCG(RandomNumberGenerator.NumberBetween(1, 4));
                    Questlog = "Conquest 2: (Steal stuff) \n" + "I need you to do some work for me. Please would you go to <location>, and steal the <item> for me? Please go to <location> and deliver it to <npc> afterwards.";
                    return GOTO2.returnMsg() + "\n" + Steal.returnMsg() + "\n" + GOTO3.returnMsg() + "\n" + "Give ITEM to NPC \n";

                default:
                    Questlog = "Something went wrong, in Conquest";
                    return "Something went wrong, in Conquest";
            }
        }
    }
}
