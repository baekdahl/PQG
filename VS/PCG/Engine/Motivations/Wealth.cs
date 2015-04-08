using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Wealth
    {
        private int CallofWealth { get; set; }

        public Wealth(int callofWealth)
        {
            CallofWealth = callofWealth;
        }

        public string returnMsg()
        {
            switch (CallofWealth + 1)
            {
            case 1:
                GoTo GOTO = new GoTo(RandomNumberGenerator.NumberBetween(0, 2));
                Get get = new Get(RandomNumberGenerator.NumberBetween(0,3));
                return "Wealth 1: (Gather Raw Materials) \n" + GOTO.returnMsg() + get.returnMsg() + "\n";

            case 2:
                GoTo GOTO2 = new GoTo(RandomNumberGenerator.NumberBetween(0, 2));
                steal Steal = new steal(RandomNumberGenerator.NumberBetween(0, 1));
                return "Wealth 2: (Steal valuables for resale) \n" + GOTO2.returnMsg() + Steal.returnMsg() + "\n";

            case 3:
                return "Wealth 3: (Make valuables for resale) \n" + "You craft some valuables \n" + "\n"; 

            default:
                return "Something went wrong, in Wealth";
            }
        }
    }
}
