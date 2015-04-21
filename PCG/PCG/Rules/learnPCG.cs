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
            switch (CallOfLearn)
            {
            case 1:
                //Already know it
                return "Learn 1: You already know it";

            case 2:
                //goto
                //subquest
                //"listen"
                gotoPCG GOTO = new gotoPCG(RandomNumberGenerator.NumberBetween(1, 4));
                subQuestPCG subquest = new subQuestPCG(RandomNumberGenerator.NumberBetween(1, 3));

                return "Learn 2: Go someplace, perform subquest, get info from NPC \n" + GOTO.returnMsg() + "\n" + subquest.returnMsg();

            case 3:
                //goto
                //get
                //"read"
                gotoPCG GOTO2 = new gotoPCG(RandomNumberGenerator.NumberBetween(1, 4));
                getPCG get = new getPCG(RandomNumberGenerator.NumberBetween(1, 5));
                return "Learn 3: Go someplace, get something, and read what is written on it \n" + GOTO2.returnMsg() + "\n" + get.returnMsg();
 
            case 4:
                //get
                //subquest
                //"give"
                //"Listen"
                getPCG get2 = new getPCG(RandomNumberGenerator.NumberBetween(1, 5));
                subQuestPCG subquest2 = new subQuestPCG(RandomNumberGenerator.NumberBetween(1, 3));
                return "Learn 4: Get something, perform subquest, give to NPC in return for info \n" + get2.returnMsg() + "\n" + subquest2.returnMsg();

            default:
                return "Something went wrong, in Learn";
            }
        }
    }
}
