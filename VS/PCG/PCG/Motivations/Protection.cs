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

        public string returnMsg()
        {
            switch (CallOfProtection + 1)
            {
                case 1:
                    gotoPCG GOTO = new gotoPCG(RandomNumberGenerator.NumberBetween(0, 2));
                    gotoPCG GOTO2 = new gotoPCG(RandomNumberGenerator.NumberBetween(0, 2));
                    return "Protection 1: (Attack threatening entities) " + "\n" + GOTO.returnMsg() + "Damgage Entities \n" + GOTO2.returnMsg() + "Report success \n" + "\n";

                case 2:
                    getPCG get = new getPCG(RandomNumberGenerator.NumberBetween(0, 3));
                    gotoPCG GOTO3 = new gotoPCG(RandomNumberGenerator.NumberBetween(0, 2));
                    return "Protection 2: (Treat or Repair(1)) " + "\n" + get.returnMsg() + GOTO3.returnMsg() + "Use item\n" + "\n";

                case 3:
                    gotoPCG GOTO4 = new gotoPCG(RandomNumberGenerator.NumberBetween(0, 2));
                    return "Protection 3: (Treat or Repair(2)) \n" + GOTO4.returnMsg() + "Repair ITEM\n" + "\n";

                case 4:
                    gotoPCG GOTO5 = new gotoPCG(RandomNumberGenerator.NumberBetween(0, 2));
                    getPCG get2 = new getPCG(RandomNumberGenerator.NumberBetween(0, 3));
                    return "Protection 4: (Create Diversion(1)) \n" + get2.returnMsg() + GOTO5.returnMsg() + "Use ITEM\n" + "\n";

                case 5:
                    gotoPCG GOTO6 = new gotoPCG(RandomNumberGenerator.NumberBetween(0, 2));

                    return "Protection 5: (Create Diversion(2)) \n" + GOTO6.returnMsg() + "Damage NPC \n" + "\n";

                case 6:
                    gotoPCG GOTO7 = new gotoPCG(RandomNumberGenerator.NumberBetween(0, 2));
                    return "Protection 6: (Assemble Fortification) \n" + GOTO7.returnMsg() + "repair item\n" + "\n";

                case 7:
                    gotoPCG GOTO8 = new gotoPCG(RandomNumberGenerator.NumberBetween(0, 2));
                    return "Protection 7: (Guard Entity) \n" + GOTO8.returnMsg() + "Defend the Entity\n" + "\n";

                default:
                    return "Something went wrong, in Protection";
            }
        }
    }
}
