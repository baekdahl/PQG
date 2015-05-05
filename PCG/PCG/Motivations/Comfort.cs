using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCG
{
    public class Comfort
    {
        public int CallOfComfort = RandomNumberGenerator.NumberBetween(1, 3);

        public string returnMsg(out string QuestLog)
        {
            switch (CallOfComfort)
            {
                case 1:
                    getPCG get = new getPCG();
                    gotoPCG GOTO = new gotoPCG();

                    QuestLog = "Comfort 1: (Obtain Luxuries) \n" + "I need you to obtain some <Luxuries:ITEM> for me, and if you refuse I will make you regret. NOW GO!";
                    return get.returnMsg() + "\n" + GOTO.returnMsg() + "\n" + "Give " + World.NPCbyID(RandomNumberGenerator.NumberBetween(1, World.NPCs.Count + 1)).NPCName + " the luxuries \n";

                case 2:
                    gotoPCG GOTO2 = new gotoPCG();
                    gotoPCG GOTO3 = new gotoPCG();

                    QuestLog = "Comfort 2: (Kill Pests) \n" + "Please, can you help me! I’m the baker of this town, and <PEST> have gotten into my storage. If I can’t get into my storage I can’t bake anymore bread for the town. Please help me by clearing them out.";
                    return GOTO2.returnMsg() + "\n" + "kill pests" + "\n" + GOTO3.returnMsg() + "\n" + "Report success to " + World.NPCbyID(RandomNumberGenerator.NumberBetween(1, World.NPCs.Count + 1)).NPCName + "\n";

                default:
                    QuestLog = "Something went wrong, in Comfort";
                    return "Something went wrong, in Comfort";
            }
        }
    }
}
