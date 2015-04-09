using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCG
{
    public class subQuestPCG
    {
        private int CallofSubQuest { get; set; }

        public subQuestPCG(int callofSubQuest)
        {
            CallofSubQuest = callofSubQuest;
        }

        public string returnMsg()
        {
            switch (CallofSubQuest + 1)
            {
                case 1:
                    //goto
                    gotoPCG GOTO = new gotoPCG(RandomNumberGenerator.NumberBetween(0, 2));
                    return "Subquest 1: \n" + GOTO.returnMsg();
                case 2:
                    //goto
                    //Quest
                    //"goto"

                    gotoPCG GOTO2 = new gotoPCG(RandomNumberGenerator.NumberBetween(0, 2));
                    PCG pcg = new PCG();
                    return "Subquest 2: \n" + GOTO2.returnMsg() + "INSERT QUEST" + "\n" + "You arrived at that location" + "\n";
                    
                default:
                    return "Something went wrong, in Subquest" + "\n";
            }
        }
    }
}
