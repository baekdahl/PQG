using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCG
{
    public class Equipment
    {
        private int CallOfEquipment { get; set; }


        public Equipment(int callOfEquipment)
        {
            CallOfEquipment = callOfEquipment;
        }

        public string returnMsg(out string Questlog)
        {
            switch (CallOfEquipment)
            {
                case 1:
                    Questlog = "Equipment 1: (Assemble) \n";
                    return "You assemble some gear \n";

                case 2:
                    getPCG get = new getPCG(RandomNumberGenerator.NumberBetween(1, 5));
                    gotoPCG GOTO = new gotoPCG(RandomNumberGenerator.NumberBetween(1, 4));

                    Questlog = "Equipment 2: (Deliver Supplies) \n";
                    return  get.returnMsg() + "\n" + GOTO.returnMsg() + "\n" + "Give the materials to " + World.NPCbyID(RandomNumberGenerator.NumberBetween(1, World.NPCs.Count + 1)).NPCName + "\n";

                case 3:
                    stealPCG Steal = new stealPCG(RandomNumberGenerator.NumberBetween(1, 3));
                    Questlog = "Equipment 3: (Steal Supplies) \n";
                    return Steal.returnMsg() + "\n";

                case 4:
                    gotoPCG GOTO2 = new gotoPCG(RandomNumberGenerator.NumberBetween(1, 4));
                    Questlog = "Equipment 4: (Trade for supplies) \n";
                    return GOTO2.returnMsg() + "\n" + "Meet up with merchants and trade for resources \n";

                default:
                    Questlog = "Something went wrong, in Equipment";
                    return "Something went wrong, in Equipment";
            }
        }
    }
}
