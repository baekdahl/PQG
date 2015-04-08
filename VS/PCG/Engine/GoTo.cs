using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class GoTo
    {
        private int CallofGoto { get; set; }

        public GoTo(int callOfGoto)
        {
            CallofGoto = callOfGoto;
        }

        public string returnMsg()
        {
            switch (CallofGoto + 1)
            {
            case 1:
                //Already there
                return "Goto 1: You are already at this LOCATION" + "\n";

            case 2:
                //Explore area
                return "Goto 2: You wander around the world, exploring until you stumble upon your LOCATION" + "\n";

            case 3:
                //learn
                //"goto"
                Learn learn = new Learn(RandomNumberGenerator.NumberBetween(0, 3));
                return "Goto 3: " + learn.returnMsg() + " You walk to the location" + "\n";

            default:
                return "Something went wrong, in goto" + "\n";
            }
        }
    }
}