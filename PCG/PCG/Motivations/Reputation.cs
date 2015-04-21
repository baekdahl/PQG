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

        public string returnMsg()
        {
            switch (CallofReputation + 1)
            {
                case 1:
                    getPCG get = new getPCG(RandomNumberGenerator.NumberBetween(0, 4));
                    gotoPCG GOTO = new gotoPCG(RandomNumberGenerator.NumberBetween(0, 3));

                    return "Reputation 1: (Obtain rare item) \n" + get.returnMsg() + GOTO.returnMsg() + "Give NPC rare ITEM \n" + "\n";

                case 2:
                    gotoPCG GOTO2 = new gotoPCG(RandomNumberGenerator.NumberBetween(0, 3));
                    killPCG Kill = new killPCG(0);
                    gotoPCG GOTO3 = new gotoPCG(RandomNumberGenerator.NumberBetween(0, 3));
                    return "Reputation 2: (Kill enemies) \n" + GOTO2.returnMsg() + Kill.returnMsg() + GOTO3.returnMsg() + "Report success to NPC \n" + "\n";

                case 3:
                    gotoPCG GOTO4 = new gotoPCG(RandomNumberGenerator.NumberBetween(0, 3));
                    gotoPCG GOTO5 = new gotoPCG(RandomNumberGenerator.NumberBetween(0, 3));
                    return "Reputation 3: (Visit a Dangerous place) \n" + GOTO4.returnMsg() + GOTO5.returnMsg() + "Report your visit to NPC \n" + "\n";

                default:
                    return "Something went wrong, in Comfort";
            }
        }
    }
}
