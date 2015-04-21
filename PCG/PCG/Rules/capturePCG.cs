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
            switch (CallOfCapture)
            {
            case 1:
                //get
                //goto
                //"capture"
                getPCG get = new getPCG(RandomNumberGenerator.NumberBetween(1, 4));
                gotoPCG GOTO = new gotoPCG(RandomNumberGenerator.NumberBetween(1, 4));
                return "Capture 1: Get something, go someplace and use it to capture somebody \n" + get.returnMsg() + "\n" + GOTO.returnMsg();

            default:
                return "Something went wrong, in Capture";
            }
        }
    }
}
