using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCG
{
    public class stealPCG
    {
        private int CallOfSteal { get; set; }

        public stealPCG(int callOfSteal)
        {
            CallOfSteal = callOfSteal;
        }

        public string returnMsg()
        {
            switch (CallOfSteal)
            {
            case 1:
                //goto
                //"stealth"
                //"take"

                gotoPCG GOTO = new gotoPCG(RandomNumberGenerator.NumberBetween(1, 4));
                return "Steal 1: Go someplace, sneak up on somebody, and take something \n" + GOTO.returnMsg();

            case 2:
                //goto
                //kill
                //"take"

                gotoPCG GOTO2 = new gotoPCG(RandomNumberGenerator.NumberBetween(1, 4));
                killPCG Kill = new killPCG(1);
                return "Steal 2: Go someplace, kill somebody and take something \n" + GOTO2.returnMsg() + Kill.returnMsg();

            default:
                return "Something went wrong, in Steal";
            }
        }
    }
}
