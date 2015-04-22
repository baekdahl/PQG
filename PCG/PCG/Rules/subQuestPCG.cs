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
        string holder;

        public subQuestPCG(int callofSubQuest)
        {
            CallofSubQuest = callofSubQuest;
        }

        public string returnMsg()
        {
            switch (CallofSubQuest)
            {
                case 1:
                    //goto
                    gotoPCG GOTO = new gotoPCG(RandomNumberGenerator.NumberBetween(1, 4));
                    return "Subquest 1: Subquest could be just to go someplace \n" + GOTO.returnMsg();
                case 2:
                    //goto
                    //Quest
                    //"goto"
                    gotoPCG GOTO2 = new gotoPCG(RandomNumberGenerator.NumberBetween(1, 4));
                    
                          switch (RandomNumberGenerator.NumberBetween(1,10))
                          {
                          case 1:
                              Knowledge KnowledgeQuest = new Knowledge(RandomNumberGenerator.NumberBetween(1, 5));
                              return "Subquest 2: Go perform a quest and return \n" + GOTO2.returnMsg() + "\n" + "\n" + KnowledgeQuest.returnMsg(out holder);

                          case 2:
                              Comfort ComfortQuest = new Comfort(RandomNumberGenerator.NumberBetween(1, 3));
                              return "Subquest 2: Go perform a quest and return \n" + GOTO2.returnMsg() + "\n" + "\n" + ComfortQuest.returnMsg(out holder);

                          case 3:
                              Reputation ReputationQuest = new Reputation(RandomNumberGenerator.NumberBetween(1, 4));
                              return "Subquest 2: Go perform a quest and return \n" + GOTO2.returnMsg() + "\n" + "\n" + ReputationQuest.returnMsg(out holder);

                          case 4:
                              Serenity SerenityQuest = new Serenity(RandomNumberGenerator.NumberBetween(1, 8));
                              return "Subquest 2: Go perform a quest and return \n" + GOTO2.returnMsg() + "\n" + "\n" + SerenityQuest.returnMsg(out holder);

                          case 5:
                              Protection ProtectionQuest = new Protection(RandomNumberGenerator.NumberBetween(1, 8));
                              return "Subquest 2: Go perform a quest and return \n" + GOTO2.returnMsg() + "\n" + "\n" + ProtectionQuest.returnMsg(out holder);

                          case 6:
                              Conquest ConquestQuest = new Conquest(RandomNumberGenerator.NumberBetween(1, 3));
                              return "Subquest 2: Go perform a quest and return \n" + GOTO2.returnMsg() + "\n" + "\n" + ConquestQuest.returnMsg(out holder);

                          case 7:
                              Wealth WealthQuest = new Wealth(RandomNumberGenerator.NumberBetween(1, 4));
                              return "Subquest 2: Go perform a quest and return \n" + GOTO2.returnMsg() + "\n" + "\n" + WealthQuest.returnMsg(out holder);

                          case 8:
                              Ability AbilityQuest = new Ability(RandomNumberGenerator.NumberBetween(1, 8));
                              return "Subquest 2: Go perform a quest and return \n" + GOTO2.returnMsg() + "\n" + "\n" + AbilityQuest.returnMsg(out holder);

                          case 9:
                              Equipment EquipmentQuest = new Equipment(RandomNumberGenerator.NumberBetween(1, 5));
                              return "Subquest 2: Go perform a quest and return \n" + GOTO2.returnMsg() + "\n" + "\n" + EquipmentQuest.returnMsg(out holder);

                          default:
                              return "SOMETHING HAVE GONE WRONG";
                          }
                     
                default:
                    return "Something went wrong, in Subquest" + "\n";
            }
        }
    }
}
