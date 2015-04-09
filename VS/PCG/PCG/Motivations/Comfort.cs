using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCG
{
    public class Comfort
    {
        private int CallOfComfort { get; set; }

        public Comfort(int callOfComfort)
        {
            CallOfComfort = callOfComfort;
        }

        public string returnMsg()
        {
            switch (CallOfComfort + 1)
            {
                case 1:
                    getPCG get = new getPCG(RandomNumberGenerator.NumberBetween(0, 3));
                    gotoPCG GOTO = new gotoPCG(RandomNumberGenerator.NumberBetween(0, 2));

                    return "Comfort 1: (Obtain Luxuries) \n" + get.returnMsg() + GOTO.returnMsg() + "Give NPC Luxuries \n" + "\n";

                case 2:
                    gotoPCG GOTO2 = new gotoPCG(RandomNumberGenerator.NumberBetween(0, 2));
                    gotoPCG GOTO3 = new gotoPCG(RandomNumberGenerator.NumberBetween(0, 2));
                    return "Comfort 2: (Kill Pests) \n" + GOTO2.returnMsg() + "kill pests" + "\n" + GOTO3.returnMsg() + "Report success to NPC \n" + "\n";

                default:
                    return "Something went wrong, in Comfort";
            }
        }
    }
}
