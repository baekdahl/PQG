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

        public string returnMsg()
        {
            switch (CallOfKnowledge + 1)
            {
                case 1:
                    subQuestPCG subquest = new subQuestPCG(RandomNumberGenerator.NumberBetween(0, 2));
                    return "Knowledge 1: (Deliver) " + "\n" + subquest.returnMsg() + "\n";

                case 2:
                    spyPCG Spy = new spyPCG(0);
                    return "Knowledge 2: (Spy) " + "\n" + Spy.returnMsg() + "\n";

                case 3:
                    gotoPCG GOTO = new gotoPCG(RandomNumberGenerator.NumberBetween(0, 3));
                    gotoPCG GOTO2 = new gotoPCG(RandomNumberGenerator.NumberBetween(0, 3));
                    int tempInt = RandomNumberGenerator.NumberBetween(1, World.NPCs.Count + 1);

                    return "Knowledge 3: (Interview) \n" + GOTO.returnMsg() + "You Listen to what " + World.NPCbyID(tempInt).NPCName + " had to say \n" + GOTO2.returnMsg() + "You reported what " + World.NPCbyID(tempInt).NPCName + " told you \n" + "\n";

                case 4:
                    gotoPCG GOTO3 = new gotoPCG(RandomNumberGenerator.NumberBetween(0, 3));
                    gotoPCG GOTO4 = new gotoPCG(RandomNumberGenerator.NumberBetween(0, 3));
                    getPCG get = new getPCG(RandomNumberGenerator.NumberBetween(0, 4));
                    return "Knowledge 4: (Use Item In Field) \n" + get.returnMsg() + GOTO3.returnMsg() + "Use " + World.ItemByID(RandomNumberGenerator.NumberBetween(1, World.Items.Count + 1)).ItemName + "\n" + GOTO4.returnMsg() + "Report the Results \n" + "\n";

                default:
                    return "Something went wrong, in Knowledge";
            }
        }
    }
}
