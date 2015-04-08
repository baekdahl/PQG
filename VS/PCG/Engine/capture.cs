using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class capture
    {
        private int CallOfCapture;

        public capture(int callOfCapture)
        {
            CallOfCapture = callOfCapture;
        }

        public string returnMsg()
        {
            switch (CallOfCapture + 1)
            {
            case 1:
                //get
                //goto
                //"capture"
                Get get = new Get(RandomNumberGenerator.NumberBetween(0, 3));
                GoTo GOTO = new GoTo(RandomNumberGenerator.NumberBetween(0, 2));
                return "Capture 1: " + get.returnMsg() + GOTO.returnMsg() + "You capture NPC" + "\n";

            default:
                return "Something went wrong, in Capture";
            }
        }
    }
}
