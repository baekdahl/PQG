using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCG
{
    public class Conquest
    {
        public int CallofConquest = RandomNumberGenerator.NumberBetween(1, 3);

        public string returnMsg(out string Questlog)
        {
            switch (CallofConquest)
            {
                case 1:
                    gotoPCG GOTO = new gotoPCG();
                    Questlog = "Conquest 1: (Attack enemy) \n" + "We need help taking back the city, from these <enemies>. Can we request your aid in taking back <Location>.";
                    return GOTO.returnMsg() + "\n" + "Damage the Enemy \n";

                case 2:
                    gotoPCG GOTO2 = new gotoPCG();
                    stealPCG Steal = new stealPCG();
                    gotoPCG GOTO3 = new gotoPCG();
                    Questlog = "Conquest 2: (Steal stuff) \n" + "I need you to do some work for me. Please would you go to <location>, and steal the <item> for me? Please go to <location> and deliver it to <npc> afterwards.";
                    return GOTO2.returnMsg() + "\n" + Steal.returnMsg() + "\n" + GOTO3.returnMsg() + "\n" + "Give ITEM to NPC \n";

                default:
                    Questlog = "Something went wrong, in Conquest";
                    return "Something went wrong, in Conquest";
            }
        }
    }
}
