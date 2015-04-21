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
            switch (CallOfComfort)
            {
                case 1:
                    getPCG get = new getPCG(RandomNumberGenerator.NumberBetween(1, 5));
                    gotoPCG GOTO = new gotoPCG(RandomNumberGenerator.NumberBetween(1, 4));

                    return "Comfort 1: (Obtain Luxuries) \n" + get.returnMsg() + "\n" + GOTO.returnMsg() + "\n" + "Give " + World.NPCbyID(RandomNumberGenerator.NumberBetween(1, World.NPCs.Count + 1)).NPCName + " the luxuries \n";

                case 2:
                    gotoPCG GOTO2 = new gotoPCG(RandomNumberGenerator.NumberBetween(1, 4));
                    gotoPCG GOTO3 = new gotoPCG(RandomNumberGenerator.NumberBetween(1, 4));
                    return "Comfort 2: (Kill Pests) \n" + GOTO2.returnMsg() + "\n" + "kill pests" + "\n" + GOTO3.returnMsg() + "\n" + "Report success to " + World.NPCbyID(RandomNumberGenerator.NumberBetween(1, World.NPCs.Count + 1)).NPCName + "\n";

                default:
                    return "Something went wrong, in Comfort";
            }
        }
    }
}
