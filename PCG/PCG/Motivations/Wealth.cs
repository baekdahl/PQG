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
            switch (CallofWealth + 1)
            {
                case 1:
                    gotoPCG GOTO = new gotoPCG(RandomNumberGenerator.NumberBetween(0, 3));
                    getPCG get = new getPCG(RandomNumberGenerator.NumberBetween(0, 4));
                    return "Wealth 1: (Gather Raw Materials) \n" + GOTO.returnMsg() + get.returnMsg() + "\n";

                case 2:
                    gotoPCG GOTO2 = new gotoPCG(RandomNumberGenerator.NumberBetween(0, 3));
                    stealPCG Steal = new stealPCG(RandomNumberGenerator.NumberBetween(0, 2));
                    return "Wealth 2: (Steal valuables for resale) \n" + GOTO2.returnMsg() + Steal.returnMsg() + "\n";

                case 3:
                    return "Wealth 3: (Make valuables for resale) \n" + "You craft some valuables \n" + "\n";

                default:
                    return "Something went wrong, in Wealth";
            }
        }
    }
}
