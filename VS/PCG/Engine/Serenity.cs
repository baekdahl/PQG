using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Serenity
    {
        private int CallOfSerenity { get; set; }

        public Serenity(int callOfSerenity)
        {
            CallOfSerenity = callOfSerenity;
        }

        public string returnMsg()
        {
            switch (CallOfSerenity + 1)
            {
                case 1:
                    GoTo GOTO = new GoTo(RandomNumberGenerator.NumberBetween(0, 2));
                    return "Serenity 1: (Revenge, Justice) " + "\n" + GOTO.returnMsg() + "Damgage for Justice \n" + "\n";
                  
                case 2:
                    Get get = new Get(RandomNumberGenerator.NumberBetween(0, 3));
                    GoTo GOTO2 = new GoTo(RandomNumberGenerator.NumberBetween(0, 2));
                    GoTo GOTO3 = new GoTo(RandomNumberGenerator.NumberBetween(0, 2));
                    return "Serenity 2: (Capture Criminal(1)) " + "\n" + get.returnMsg() + GOTO2.returnMsg() + "Use item" + "\n" + GOTO3.returnMsg() + "Hand over Criminal \n" + "\n";

                case 3:
                    Get get2 = new Get(RandomNumberGenerator.NumberBetween(0, 3));
                    GoTo GOTO4 = new GoTo(RandomNumberGenerator.NumberBetween(0, 2));
                    GoTo GOTO5 = new GoTo(RandomNumberGenerator.NumberBetween(0, 2));
                    capture Capture = new capture(RandomNumberGenerator.NumberBetween(0, 1));

                    return "Serenity 3: (Capture Criminal(2)) \n" + get2.returnMsg() + GOTO4.returnMsg() + Capture.returnMsg() + GOTO5.returnMsg() + "Hand over Criminal \n" + "\n";

                case 4:
                    GoTo GOTO6 = new GoTo(RandomNumberGenerator.NumberBetween(0,2));
                    GoTo GOTO7 = new GoTo(RandomNumberGenerator.NumberBetween(0,2));
                    return "Serenity 4: (Check on NPC(1)) \n" + GOTO6.returnMsg() + "Listen to NPC" + "\n" + GOTO7.returnMsg() + "Report to NPC \n" + "\n";

                case 5:
                    GoTo GOTO8 = new GoTo(RandomNumberGenerator.NumberBetween(0,2));
                    GoTo GOTO9 = new GoTo(RandomNumberGenerator.NumberBetween(0,2));
                    return "Serenity 5: (Check on NPC(2)) \n" + GOTO8.returnMsg() + "Take ITEM" + "\n" + GOTO9.returnMsg() + "Give ITEM to NPC \n" + "\n";

                case 6:
                    Get get3 = new Get(RandomNumberGenerator.NumberBetween(0, 3));
                    GoTo GOTO10 = new GoTo(RandomNumberGenerator.NumberBetween(0, 2));
                    return "Serenity 6: (Recover Lost/stolen item) \n" + get3.returnMsg() + GOTO10.returnMsg() + "Give item to NPC \n" + "\n";

                case 7:
                    GoTo GOTO11 = new GoTo(RandomNumberGenerator.NumberBetween(0, 2));
                    GoTo GOTO12 = new GoTo(RandomNumberGenerator.NumberBetween(0, 2));
                    return "Serenity 7: (Rescue Captured NPC) \n" + GOTO11.returnMsg() + "Damage enemies and escort NPC" + "\n" + GOTO12.returnMsg() + "Report your Succes to NPC \n" + "\n";

                default:
                    return "Something went wrong, in Serenity";
            }
        }
    }
}
