using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCG
{
    public class learnPCG
    {
        private int CallOfLearn { get; set; }

        public learnPCG(int callOfLearn)
        {
            CallOfLearn = callOfLearn;
        }

        public string returnMsg()
        {
            switch (CallOfLearn + 1)
            {
            case 1:
                //Already know it
                return "Learn 1: You already know this \n";

            case 2:
                //goto
                //subquest
                //"listen"
                gotoPCG GOTO = new gotoPCG(RandomNumberGenerator.NumberBetween(0, 1));
                subQuestPCG subquest = new subQuestPCG(RandomNumberGenerator.NumberBetween(0, 2));

                return "Learn 2: You need to go someplace, and perform a subquest \n" + GOTO.returnMsg() + subquest.returnMsg() + "You listen to " + World.NPCbyID(RandomNumberGenerator.NumberBetween(1, World.NPCs.Count + 1)).NPCName + "\n";

            case 3:
                //goto
                //get
                //"read"
                gotoPCG GOTO2 = new gotoPCG(RandomNumberGenerator.NumberBetween(0, 1));
                getPCG get = new getPCG(RandomNumberGenerator.NumberBetween(0, 4));
                return "Learn 3: Go someplace, and get something \n" + GOTO2.returnMsg() + get.returnMsg() + "Read what is written \n";
 
            case 4:
                //get
                //subquest
                //"give"
                //"Listen"
                getPCG get2 = new getPCG(RandomNumberGenerator.NumberBetween(0, 4));
                subQuestPCG subquest2 = new subQuestPCG(RandomNumberGenerator.NumberBetween(0, 2));

                return "Learn 4: Get something, perform subquest \n" + get2.returnMsg() + subquest2.returnMsg() + "the " + World.NPCbyID(RandomNumberGenerator.NumberBetween(1, World.NPCs.Count + 1)).NPCName + " gave you the info" + "\n";

            default:
                return "Something went wrong, in Learn" + "\n";
            }
        }
    }
}
