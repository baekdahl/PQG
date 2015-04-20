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
                    
                          switch (RandomNumberGenerator.NumberBetween(0,9) + 1)
                          {
                          case 1:
                              Knowledge KnowledgeQuest = new Knowledge(RandomNumberGenerator.NumberBetween(0, 4));
                              return "Subquest 2: \n" + GOTO2.returnMsg() + KnowledgeQuest.returnMsg() + "You arrived at that location" + "\n";

                          case 2:
                              Comfort ComfortQuest = new Comfort(RandomNumberGenerator.NumberBetween(0, 2));
                              return "Subquest 2: \n" + GOTO2.returnMsg() + ComfortQuest.returnMsg() + "You arrived at that location" + "\n";

                          case 3:
                              Reputation ReputationQuest = new Reputation(RandomNumberGenerator.NumberBetween(0, 3));
                              return "Subquest 2: \n" + GOTO2.returnMsg() + ReputationQuest.returnMsg() + "You arrived at that location" + "\n";

                          case 4:
                              Conquest ConquestQuest = new Conquest(RandomNumberGenerator.NumberBetween(0, 2));
                              return "Subquest 2: \n" + GOTO2.returnMsg() + ConquestQuest.returnMsg() + "You arrived at that location" + "\n";

                          case 5:
                              Wealth WealthQuest = new Wealth(RandomNumberGenerator.NumberBetween(0, 3));
                              return "Subquest 2: \n" + GOTO2.returnMsg() + WealthQuest.returnMsg() + "You arrived at that location" + "\n";

                          case 6:
                              Equipment EquipmentQuest = new Equipment(RandomNumberGenerator.NumberBetween(0, 4));
                              return "Subquest 2: \n" + GOTO2.returnMsg() + EquipmentQuest.returnMsg() + "You arrived at that location" + "\n";

                          case 7:
                              Ability AbilityQuest = new Ability(RandomNumberGenerator.NumberBetween(0, 7));
                              return "Subquest 2: \n" + GOTO2.returnMsg() + AbilityQuest.returnMsg() + "You arrived at that location" + "\n";

                          case 8:
                              Serenity SerenityQuest = new Serenity(RandomNumberGenerator.NumberBetween(0, 7));
                              return "Subquest 2: \n" + GOTO2.returnMsg() + SerenityQuest.returnMsg() + "You arrived at that location" + "\n";

                          case 9:
                              Protection ProtectionQuest = new Protection(RandomNumberGenerator.NumberBetween(0, 7));
                              return "Subquest 2: \n" + GOTO2.returnMsg() + ProtectionQuest.returnMsg() + "You arrived at that location" + "\n";

                          default:
                              return "SOMETHING HAVE GONE WRONG";
                          }
                     
                default:
                    return "Something went wrong, in Subquest" + "\n";
            }
        }
    }
}
