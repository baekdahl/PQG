using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCG
{
    public class Knowledge
    {
        private int CallOfKnowledge { get; set; }

        public Knowledge(int callOfKnowledge)
        {
            CallOfKnowledge = callOfKnowledge;
        }

        public string returnMsg(out string QuestLog)
        {
            switch (CallOfKnowledge)
            {
                case 1:
                    subQuestPCG subquest = new subQuestPCG(RandomNumberGenerator.NumberBetween(1, 3));

                    QuestLog = "Knowledge 1: Deliver  \n";
                    return subquest.returnMsg() + "\n";

                case 2:
                    spyPCG Spy = new spyPCG(0);

                    QuestLog = "Knowledge 2: (Spy) \n";
                    return Spy.returnMsg() + "\n";

                case 3:
                    gotoPCG GOTO = new gotoPCG(RandomNumberGenerator.NumberBetween(1, 4));
                    gotoPCG GOTO2 = new gotoPCG(RandomNumberGenerator.NumberBetween(1, 4));
                    int tempInt = RandomNumberGenerator.NumberBetween(1, World.NPCs.Count + 1);

                    QuestLog = "Knowledge 3: (Interview) \n";
                    return GOTO.returnMsg() + "\n" + "You Listen to what " + World.NPCbyID(tempInt).NPCName + " had to say \n" + GOTO2.returnMsg() + "\n" + "You reported what " + World.NPCbyID(tempInt).NPCName + " told you \n" + "\n";

                case 4:
                    gotoPCG GOTO3 = new gotoPCG(RandomNumberGenerator.NumberBetween(1, 4));
                    gotoPCG GOTO4 = new gotoPCG(RandomNumberGenerator.NumberBetween(1, 4));
                    getPCG get = new getPCG(RandomNumberGenerator.NumberBetween(1, 5));
                   
                    QuestLog = "Knowledge 4: (Use Item In Field) \n";
                    return get.returnMsg() + "\n" + GOTO3.returnMsg() + "\n" + "Use " + World.ItemByID(RandomNumberGenerator.NumberBetween(1, World.Items.Count + 1)).ItemName + "\n" + GOTO4.returnMsg() + "\n" + "Report the Results \n" + "\n";

                default:
                    QuestLog = "Something went wrong, in Knowledge";
                    return "Something went wrong, in Knowledge";
            }
        }
    }
}
