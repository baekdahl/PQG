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

        public string returnMsg(out string QuestLog)
        {
            switch (CallOfComfort)
            {
                case 1:
                    getPCG get = new getPCG(RandomNumberGenerator.NumberBetween(1, 5));
                    gotoPCG GOTO = new gotoPCG(RandomNumberGenerator.NumberBetween(1, 4));

                    QuestLog = "Comfort 1: (Obtain Luxuries) \n";
                    return get.returnMsg() + "\n" + GOTO.returnMsg() + "\n" + "Give " + World.NPCbyID(RandomNumberGenerator.NumberBetween(1, World.NPCs.Count + 1)).NPCName + " the luxuries \n";

                case 2:
                    gotoPCG GOTO2 = new gotoPCG(RandomNumberGenerator.NumberBetween(1, 4));
                    gotoPCG GOTO3 = new gotoPCG(RandomNumberGenerator.NumberBetween(1, 4));

                    QuestLog = "Comfort 2: (Kill Pests) \n";
                    return GOTO2.returnMsg() + "\n" + "kill pests" + "\n" + GOTO3.returnMsg() + "\n" + "Report success to " + World.NPCbyID(RandomNumberGenerator.NumberBetween(1, World.NPCs.Count + 1)).NPCName + "\n";

                default:
                    QuestLog = "Something went wrong, in Comfort";
                    return "Something went wrong, in Comfort";
            }
        }
    }
}
