using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class kill
    {
        private int CallOfKill;

        public kill(int callOfKill)
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
                GoTo GOTO = new GoTo(RandomNumberGenerator.NumberBetween(0, 2));
                return "Kill 1: \n" + GOTO.returnMsg() + "You killed NPC \n" + "\n";

            default:
                return "Something went wrong, in Kill";
            }
        }
    }
}
