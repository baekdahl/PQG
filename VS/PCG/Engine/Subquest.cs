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
                    //GoTo GOTO = new GoTo(RandomNumberGenerator.NumberBetween(0, 2));
                    return "\n Random AS BALLS!!!!!!!!!";
                case 2:
                    //goto
                    //quest
                    //goto
                    return "Needs more iNFO";

                default:
                    return "Something went wrong, in Subquest";
            }
        }
    }
}
