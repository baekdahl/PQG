using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
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
                    Subquest subquest = new Subquest(RandomNumberGenerator.NumberBetween(0, 1));
                    return "Knowledge 1: (Deliver) " + "\n" + subquest.returnMsg() + "\n";
                  
                case 2:
                    spy Spy = new spy(0);
                    return "Knowledge 2: (Spy) " + "\n" + Spy.returnMsg() + "\n";

                case 3:
                    GoTo GOTO = new GoTo(RandomNumberGenerator.NumberBetween(0, 2));
                    GoTo GOTO2 = new GoTo(RandomNumberGenerator.NumberBetween(0, 2));

                    return "Knowledge 3: (Interview) \n" + GOTO.returnMsg() + "You Listen to what the NPC had to say \n" + GOTO2.returnMsg() + "You reported what NPC told you \n" + "\n";

                case 4:
                    GoTo GOTO3 = new GoTo(RandomNumberGenerator.NumberBetween(0, 2));
                    GoTo GOTO4 = new GoTo(RandomNumberGenerator.NumberBetween(0, 2));
                    Get get = new Get(RandomNumberGenerator.NumberBetween(0, 3));
                    return "Knowledge 4: (Use Item In Field) \n" + get.returnMsg() + GOTO3.returnMsg() + "You Used the ITEM" + "\n" + GOTO4.returnMsg() + "GIVE??!??! \n" + "\n";

                default:
                    return "Something went wrong, in Knowledge";
            }
        }

    }
}