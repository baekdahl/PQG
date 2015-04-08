using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class spy
    {
        private int CallOfSpy;

        public spy(int callOfSpy)
        {
            CallOfSpy = callOfSpy;
        }

        public string returnMsg()
        {
            switch (CallOfSpy + 1)
            {
            case 1:
                //goto
                //"spy"
                //goto
                //"report"
                GoTo GOTO = new GoTo(RandomNumberGenerator.NumberBetween(0, 2));
                GoTo GOTO2 = new GoTo(RandomNumberGenerator.NumberBetween(0, 2));
                return "Spy 1: " + GOTO.returnMsg() + " you spy on NPC" + GOTO2.returnMsg() + " You returned to LOCATION and reported what you learned." + "\n";

            default:
                return "Something went wrong, in Spy";
            }
        }
    }
}
