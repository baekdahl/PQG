using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Equipment
    {
        private int CallOfEquipment { get; set; }


        public Equipment(int callOfEquipment)
        {
            CallOfEquipment = callOfEquipment;
        }

        public string returnMsg()
        {
            switch (CallOfEquipment + 1)
            {
                case 1:
                    return "Equipment 1: (Assemble) " + "\n" + "You assemble some gear \n" + "\n";
                  
                case 2:
                    Get get = new Get(RandomNumberGenerator.NumberBetween(0, 3));
                    GoTo GOTO = new GoTo(RandomNumberGenerator.NumberBetween(0, 2));
                    return "Equipment 2: (Deliver Supplies) " + "\n" + get.returnMsg() + GOTO.returnMsg() + "Give the materials to an NPC \n" + "\n";

                case 3:
                    steal Steal = new steal(RandomNumberGenerator.NumberBetween(0, 1));
                    return "Equipment 3: (Steal Supplies) \n" + Steal.returnMsg() + "\n";

                case 4:
                    GoTo GOTO2 = new GoTo(RandomNumberGenerator.NumberBetween(0, 2));
                    return "Equipment 4: (Trade for supplies) \n" + GOTO2.returnMsg() + "Meet up with a few merchants and trade for the resources \n" + "\n";

                default:
                    return "Something went wrong, in Knowledge";
            }
        }
    }
}
