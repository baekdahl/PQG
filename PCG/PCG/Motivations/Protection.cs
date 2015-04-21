﻿using System;
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
            switch (CallOfProtection)
            {
                case 1:
                    gotoPCG GOTO = new gotoPCG(RandomNumberGenerator.NumberBetween(1, 4));
                    gotoPCG GOTO2 = new gotoPCG(RandomNumberGenerator.NumberBetween(1, 4));
                    return "Protection 1: (Attack threatening entities) " + "\n" + GOTO.returnMsg() + "\n" + "Damage Entities \n" + GOTO2.returnMsg() + "\n" + "Report success \n" + "\n";

                case 2:
                    getPCG get = new getPCG(RandomNumberGenerator.NumberBetween(1, 5));
                    gotoPCG GOTO3 = new gotoPCG(RandomNumberGenerator.NumberBetween(1, 4));
                    return "Protection 2: (Treat or Repair(1)) " + "\n" + get.returnMsg() + "\n" + GOTO3.returnMsg() + "\n" + "Use item\n" + "\n";

                case 3:
                    gotoPCG GOTO4 = new gotoPCG(RandomNumberGenerator.NumberBetween(1, 4));
                    return "Protection 3: (Treat or Repair(2)) \n" + GOTO4.returnMsg() + "\n" + "Repair ITEM\n" + "\n";

                case 4:
                    gotoPCG GOTO5 = new gotoPCG(RandomNumberGenerator.NumberBetween(1, 4));
                    getPCG get2 = new getPCG(RandomNumberGenerator.NumberBetween(1, 5));
                    return "Protection 4: (Create Diversion(1)) \n" + get2.returnMsg() + "\n" + GOTO5.returnMsg() + "\n" + "Use ITEM\n" + "\n";

                case 5:
                    gotoPCG GOTO6 = new gotoPCG(RandomNumberGenerator.NumberBetween(1, 4));
                    return "Protection 5: (Create Diversion(2)) \n" + GOTO6.returnMsg() + "\n" + "Damage NPC \n" + "\n";

                case 6:
                    gotoPCG GOTO7 = new gotoPCG(RandomNumberGenerator.NumberBetween(1, 4));
                    return "Protection 6: (Assemble Fortification) \n" + GOTO7.returnMsg() + "\n" + "repair item\n" + "\n";

                case 7:
                    gotoPCG GOTO8 = new gotoPCG(RandomNumberGenerator.NumberBetween(1, 4));
                    return "Protection 7: (Guard Entity) \n" + GOTO8.returnMsg() + "\n" + "Defend the Entity\n" + "\n";

                default:
                    return "Something went wrong, in Protection";
            }
        }
    }
}
