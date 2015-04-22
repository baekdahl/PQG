using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCG
{
    public class Protection
    {
        private int CallOfProtection { get; set; }

        public Protection(int callOfProtection)
        {
            CallOfProtection = callOfProtection;
        }

        public string returnMsg(out string Questlog)
        {
            switch (CallOfProtection)
            {
                case 1:
                    gotoPCG GOTO = new gotoPCG(RandomNumberGenerator.NumberBetween(1, 4));
                    gotoPCG GOTO2 = new gotoPCG(RandomNumberGenerator.NumberBetween(1, 4));

                    Questlog = "Protection 1: (Attack threatening entities) \n";
                    return GOTO.returnMsg() + "\n" + "Damage Entities \n" + GOTO2.returnMsg() + "\n" + "Report success \n";

                case 2:
                    getPCG get = new getPCG(RandomNumberGenerator.NumberBetween(1, 5));
                    gotoPCG GOTO3 = new gotoPCG(RandomNumberGenerator.NumberBetween(1, 4));
                    Questlog = "Protection 2: (Treat or Repair(1)) \n";
                    return get.returnMsg() + "\n" + GOTO3.returnMsg() + "\n" + "Use item\n";

                case 3:
                    gotoPCG GOTO4 = new gotoPCG(RandomNumberGenerator.NumberBetween(1, 4));
                    Questlog = "Protection 3: (Treat or Repair(2)) \n";
                    return GOTO4.returnMsg() + "\n" + "Repair item\n";

                case 4:
                    gotoPCG GOTO5 = new gotoPCG(RandomNumberGenerator.NumberBetween(1, 4));
                    getPCG get2 = new getPCG(RandomNumberGenerator.NumberBetween(1, 5));
                    Questlog = "Protection 4: (Create Diversion(1)) \n";
                    return get2.returnMsg() + "\n" + GOTO5.returnMsg() + "\n" + "Use ITEM\n";

                case 5:
                    gotoPCG GOTO6 = new gotoPCG(RandomNumberGenerator.NumberBetween(1, 4));

                    Questlog = "Protection 5: (Create Diversion(2)) \n";
                    return GOTO6.returnMsg() + "\n" + "Damage NPC \n";

                case 6:
                    gotoPCG GOTO7 = new gotoPCG(RandomNumberGenerator.NumberBetween(1, 4));
                    Questlog = "Protection 6: (Assemble Fortification) \n";
                    return GOTO7.returnMsg() + "\n" + "repair item\n";

                case 7:
                    gotoPCG GOTO8 = new gotoPCG(RandomNumberGenerator.NumberBetween(1, 4));
                    Questlog = "Protection 7: (Guard Entity) \n";
                    return GOTO8.returnMsg() + "\n" + "Defend the Entity\n";

                default:
                    Questlog = "Something went wrong, in Protection";
                    return "Something went wrong, in Protection";
            }
        }
    }
}
