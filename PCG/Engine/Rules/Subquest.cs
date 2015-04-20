using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Subquest
    {
        private int CallofSubQuest { get; set; }
        
        public Subquest(int callofSubQuest)
        {
            CallofSubQuest = callofSubQuest;
        }

        public string returnMsg()
        {
            switch (CallofSubQuest + 1)
            {
                case 1:
                    //goto
                    GoTo GOTO = new GoTo(RandomNumberGenerator.NumberBetween(0, 2));
                    return "Subquest 1: \n" + GOTO.returnMsg();
                case 2:
                    //goto
                    //Quest
                    //"goto"

                   
                    GoTo GOTO2 = new GoTo(RandomNumberGenerator.NumberBetween(0, 2));
                    return "Subquest 2: \n" + GOTO2.returnMsg() + "NOT DOOOOONE" + "\n" + "You arrived at that location" + "\n";
                    
                default:
                    return "Something went wrong, in Subquest" + "\n";
            }
        }
    }
}
