﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCG
{
    public class Serenity
    {
        private int CallOfSerenity { get; set; }

        public Serenity(int callOfSerenity)
        {
            CallOfSerenity = callOfSerenity;
        }

        public string returnMsg(out string Questlog)
        {
            switch (CallOfSerenity)
            {
                case 1:
                    gotoPCG GOTO = new gotoPCG(RandomNumberGenerator.NumberBetween(1, 4));
                    Questlog = "Serenity 1: (Revenge, Justice) \n";  
                    return GOTO.returnMsg() + "\n" + "Damgage for Justice \n" + "\n";
                  
                case 2:
                    getPCG get = new getPCG(RandomNumberGenerator.NumberBetween(1, 5));
                    gotoPCG GOTO2 = new gotoPCG(RandomNumberGenerator.NumberBetween(1, 4));
                    gotoPCG GOTO3 = new gotoPCG(RandomNumberGenerator.NumberBetween(1, 4));
                    Questlog = "Serenity 2: (Capture Criminal(1)) \n"; 
                    return get.returnMsg() + "\n" + GOTO2.returnMsg() + "\n" + "Use item" + "\n" + GOTO3.returnMsg() + "\n" + "Hand over Criminal \n";

                case 3:
                    getPCG get2 = new getPCG(RandomNumberGenerator.NumberBetween(1, 5));
                    gotoPCG GOTO4 = new gotoPCG(RandomNumberGenerator.NumberBetween(1, 4));
                    gotoPCG GOTO5 = new gotoPCG(RandomNumberGenerator.NumberBetween(1, 4));
                    capturePCG Capture = new capturePCG(1);
                    Questlog = "Serenity 3: (Capture Criminal(2)) \n"; 
                    return get2.returnMsg() + "\n" + GOTO4.returnMsg() + "\n" + Capture.returnMsg() + "\n" + GOTO5.returnMsg() + "\n" + "Hand over Criminal \n";

                case 4:
                    gotoPCG GOTO6 = new gotoPCG(RandomNumberGenerator.NumberBetween(1, 4));
                    gotoPCG GOTO7 = new gotoPCG(RandomNumberGenerator.NumberBetween(1, 4));
                    Questlog = "Serenity 4: (Check on NPC(1)) \n"; 
                    return GOTO6.returnMsg() + "\n" + "Listen to NPC" + "\n" + GOTO7.returnMsg() + "\n" + "Report to NPC \n";

                case 5:
                    gotoPCG GOTO8 = new gotoPCG(RandomNumberGenerator.NumberBetween(1, 4));
                    gotoPCG GOTO9 = new gotoPCG(RandomNumberGenerator.NumberBetween(1, 4));
                    Questlog = "Serenity 5: (Check on NPC(2)) \n";
                    return GOTO8.returnMsg() + "\n" + "Take ITEM" + "\n" + GOTO9.returnMsg() + "\n" + "Give ITEM to NPC \n";

                case 6:
                    getPCG get3 = new getPCG(RandomNumberGenerator.NumberBetween(1, 5));
                    gotoPCG GOTO10 = new gotoPCG(RandomNumberGenerator.NumberBetween(1, 4));
                    Questlog = "Serenity 6: (Recover Lost/stolen item) \n"; 
                    return get3.returnMsg() + "\n" + GOTO10.returnMsg() + "\n" + "Give item to NPC \n";

                case 7:
                    gotoPCG GOTO11 = new gotoPCG(RandomNumberGenerator.NumberBetween(1, 4));
                    gotoPCG GOTO12 = new gotoPCG(RandomNumberGenerator.NumberBetween(1, 4));
                    Questlog = "Serenity 7: (Rescue Captured NPC) \n"; 
                    return GOTO11.returnMsg() + "Damage enemies and escort NPC" + "\n" + GOTO12.returnMsg() + "\n" + "Report your Succes to NPC \n" + "\n";

                default:
                    Questlog = "Something went wrong, in Serenity";
                    return "Something went wrong, in Serenity";
            }
        }
    }
}
