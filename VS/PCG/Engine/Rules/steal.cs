using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class steal
    {
        private int CallOfSteal { get; set; }

        public steal(int callOfSteal)
        {
            CallOfSteal = callOfSteal;
        }

        public string returnMsg()
        {
            switch (CallOfSteal + 1)
            {
            case 1:
                //goto
                //"stealth"
                //"take"

                GoTo GOTO = new GoTo(RandomNumberGenerator.NumberBetween(0, 2));
                return "Steal 1: \n" + GOTO.returnMsg() + "You stealth you to your target and steal an ITEM out of its pocket" + "\n";

            case 2:
                //goto
                //kill
                //"take"

                GoTo GOTO2 = new GoTo(RandomNumberGenerator.NumberBetween(0, 2));
                kill Kill = new kill(0);
                return "Steal 2: \n" + GOTO2.returnMsg() + Kill.returnMsg() + "You pick up ITEM from the dead NPCs corpse \n" + "\n";

            default:
                return "Something went wrong, in Steal";
            }
        }
    }
}
