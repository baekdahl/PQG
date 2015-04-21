using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCG
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
            switch (CallofWealth)
            {
                case 1:
                    gotoPCG GOTO = new gotoPCG(RandomNumberGenerator.NumberBetween(1, 4));
                    getPCG get = new getPCG(RandomNumberGenerator.NumberBetween(1, 5));
                    return "Wealth 1: (Gather Raw Materials) \n" + GOTO.returnMsg() + "\n" + get.returnMsg() + "\n";

                case 2:
                    gotoPCG GOTO2 = new gotoPCG(RandomNumberGenerator.NumberBetween(1, 4));
                    stealPCG Steal = new stealPCG(RandomNumberGenerator.NumberBetween(1, 3));
                    return "Wealth 2: (Steal valuables for resale) \n" + GOTO2.returnMsg() + "\n" + Steal.returnMsg() + "\n";

                case 3:
                    return "Wealth 3: (Make valuables for resale) \n" + "You craft some valuables \n";

                default:
                    return "Something went wrong, in Wealth";
            }
        }
    }
}
