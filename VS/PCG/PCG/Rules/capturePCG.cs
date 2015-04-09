using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCG
{
    public class capturePCG
    {
        private int CallOfCapture;

        public capturePCG(int callOfCapture)
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
                getPCG get = new getPCG(RandomNumberGenerator.NumberBetween(0, 3));
                gotoPCG GOTO = new gotoPCG(RandomNumberGenerator.NumberBetween(0, 2));
                return "Capture 1: \n" + get.returnMsg() + GOTO.returnMsg() + "You capture NPC\n" + "\n";

            default:
                return "Something went wrong, in Capture";
            }
        }
    }
}
