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

        public string returnMsg(out string Questlog)
        {
            switch (CallofWealth)
            {
                case 1:
                    gotoPCG GOTO = new gotoPCG(RandomNumberGenerator.NumberBetween(1, 4));
                    getPCG get = new getPCG(RandomNumberGenerator.NumberBetween(1, 5));
                    Questlog = "Wealth 1: (Gather Raw Materials) \n" + "Please my friend, do you have the time to spare, to help me? You see I have been running out of <item:MATERIAL> for a while now. Please could you go and get me some?"; 
                    return GOTO.returnMsg() + "\n" + get.returnMsg() + "\n";

                case 2:
                    gotoPCG GOTO2 = new gotoPCG(RandomNumberGenerator.NumberBetween(1, 4));
                    stealPCG Steal = new stealPCG(RandomNumberGenerator.NumberBetween(1, 3));
                    Questlog = "Wealth 2: (Steal valuables for resale) \n" + "Hey you! Are you interested in earning some easy money? Well, if you go and steal these <item:valuables> for me, I will make sure to resell them at a better cost.";
                    return GOTO2.returnMsg() + "\n" + Steal.returnMsg() + "\n";

                case 3:
                    Questlog = "Wealth 3: (Make valuables for resale) \n" + "I see you have a talent, that few possess. Wanna make some good money? Well if you go make some <item:valuables>, then I will resell them at a good cost, and we both make a good dime."; 
                    return "You craft some valuables \n";

                default:
                    Questlog = "Something went wrong, in Wealth";
                    return "Something went wrong, in Wealth";
            }
        }
    }
}
