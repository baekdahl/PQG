using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCG
{
    public class killPCG
    {
        private int CallOfKill;

        public killPCG(int callOfKill)
        {
            CallOfKill = callOfKill;
        }

        public string returnMsg()
        {
            switch (CallOfKill + 1)
            {
            case 1:
                //goto
                //"kill"
                gotoPCG GOTO = new gotoPCG(RandomNumberGenerator.NumberBetween(0, 2));
                return "Kill 1: \n" + GOTO.returnMsg() + "You killed NPC \n" + "\n";

            default:
                return "Something went wrong, in Kill";
            }
        }
    }
}
