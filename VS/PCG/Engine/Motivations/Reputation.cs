using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
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
                Get get = new Get(RandomNumberGenerator.NumberBetween(0, 3));
                GoTo GOTO = new GoTo(RandomNumberGenerator.NumberBetween(0, 2));

                return "Reputation 1: (Obtain rare item) \n" + get.returnMsg() + GOTO.returnMsg() + "Give NPC rare ITEM \n" + "\n";

            case 2:
                GoTo GOTO2 = new GoTo(RandomNumberGenerator.NumberBetween(0, 2));
                kill Kill = new kill(0);
                GoTo GOTO3 = new GoTo(RandomNumberGenerator.NumberBetween(0, 2));
                return "Reputation 2: (Kill enemies) \n" + GOTO2.returnMsg() + Kill.returnMsg() + GOTO3.returnMsg() + "Report success to NPC \n" + "\n";

            case 3:
                GoTo GOTO4 = new GoTo(RandomNumberGenerator.NumberBetween(0, 2));
                GoTo GOTO5 = new GoTo(RandomNumberGenerator.NumberBetween(0, 2));
                return "Reputation 3: (Visit a Dangerous place) \n" + GOTO4.returnMsg() + GOTO5.returnMsg() + "Report your visit to NPC \n" + "\n";

            default:
                return "Something went wrong, in Comfort";
            }
        }
    }
}
