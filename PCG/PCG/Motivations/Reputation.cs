using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCG
{
    public class Reputation
    {
        private int CallofReputation { get; set; }

        public Reputation(int callofReputation)
        {
            CallofReputation = callofReputation;
        }

        public string returnMsg(out string Questlog)
        {
            switch (CallofReputation)
            {
                case 1:
                    getPCG get = new getPCG(RandomNumberGenerator.NumberBetween(1, 5));
                    gotoPCG GOTO = new gotoPCG(RandomNumberGenerator.NumberBetween(1, 4));
                    Questlog = "Reputation 1: (Obtain rare item) \n"; 
                    return get.returnMsg() + "\n" + GOTO.returnMsg() + "\n" + "Give NPC rare ITEM \n" + "\n";

                case 2:
                    gotoPCG GOTO2 = new gotoPCG(RandomNumberGenerator.NumberBetween(1, 4));
                    killPCG Kill = new killPCG(1);
                    gotoPCG GOTO3 = new gotoPCG(RandomNumberGenerator.NumberBetween(1, 4));

                    Questlog = "Reputation 2: (Kill enemies) \n"; 
                    return GOTO2.returnMsg() + "\n" + Kill.returnMsg() + "\n" + GOTO3.returnMsg() + "\n" + "Report success to NPC \n" + "\n";

                case 3:
                    gotoPCG GOTO4 = new gotoPCG(RandomNumberGenerator.NumberBetween(1, 4));
                    gotoPCG GOTO5 = new gotoPCG(RandomNumberGenerator.NumberBetween(1, 4));
                    Questlog = "Reputation 3: (Visit a Dangerous place) \n";
                    return GOTO4.returnMsg() + "\n" + GOTO5.returnMsg() + "\n" + "Report your visit to NPC \n" + "\n";

                default:
                    Questlog = "Something went wrong, in Reputation";
                    return "Something went wrong, in Reputation";
            }
        }
    }
}
