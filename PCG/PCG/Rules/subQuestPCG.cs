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
                              return "Subquest 2: Go perform a quest and return \n" + GOTO2.returnMsg() + KnowledgeQuest.returnMsg();

                          case 2:
                              Comfort ComfortQuest = new Comfort(RandomNumberGenerator.NumberBetween(1, 3));
                              return "Subquest 2: Go perform a quest and return \n" + GOTO2.returnMsg() + ComfortQuest.returnMsg();

                          case 3:
                              Reputation ReputationQuest = new Reputation(RandomNumberGenerator.NumberBetween(1, 4));
                              return "Subquest 2: Go perform a quest and return \n" + GOTO2.returnMsg() + ReputationQuest.returnMsg();

                          case 4:
                              Serenity SerenityQuest = new Serenity(RandomNumberGenerator.NumberBetween(1, 8));
                              return "Subquest 2: Go perform a quest and return \n" + GOTO2.returnMsg() + SerenityQuest.returnMsg();

                          case 5:
                              Protection ProtectionQuest = new Protection(RandomNumberGenerator.NumberBetween(1, 8));
                              return "Subquest 2: Go perform a quest and return \n" + GOTO2.returnMsg() + ProtectionQuest.returnMsg();

                          case 6:
                              Conquest ConquestQuest = new Conquest(RandomNumberGenerator.NumberBetween(1, 3));
                              return "Subquest 2: Go perform a quest and return \n" + GOTO2.returnMsg() + ConquestQuest.returnMsg();

                          case 7:
                              Wealth WealthQuest = new Wealth(RandomNumberGenerator.NumberBetween(1, 4));
                              return "Subquest 2: Go perform a quest and return \n" + GOTO2.returnMsg() + WealthQuest.returnMsg();

                          case 8:
                              Ability AbilityQuest = new Ability(RandomNumberGenerator.NumberBetween(1, 8));
                              return "Subquest 2: Go perform a quest and return \n" + GOTO2.returnMsg() + AbilityQuest.returnMsg();

                          case 9:
                              Equipment EquipmentQuest = new Equipment(RandomNumberGenerator.NumberBetween(1, 5));
                              return "Subquest 2: Go perform a quest and return \n" + GOTO2.returnMsg() + EquipmentQuest.returnMsg();

                          default:
                              return "SOMETHING HAVE GONE WRONG";
                          }
                     
                default:
                    return "Something went wrong, in Subquest" + "\n";
            }
        }
    }
}
