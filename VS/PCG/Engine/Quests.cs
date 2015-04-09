using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Quests
    {
        public void Quests(int QuestInputNumber)
        {
            switch (QuestInputNumber + 1)
            {
                case 1:
                    Knowledge KnowledgeQuest = new Knowledge(RandomNumberGenerator.NumberBetween(0, 4));
                    rtb1.Text += KnowledgeQuest.returnMsg();
                    break;

                case 2:
                    Comfort ComfortQuest = new Comfort(RandomNumberGenerator.NumberBetween(0, 2));
                    rtb1.Text += ComfortQuest.returnMsg();
                    break;

                case 3:
                    Reputation ReputationQuest = new Reputation(RandomNumberGenerator.NumberBetween(0, 3));
                    rtb1.Text += ReputationQuest.returnMsg();
                    break;

                case 4:
                    Conquest ConquestQuest = new Conquest(RandomNumberGenerator.NumberBetween(0, 2));
                    rtb1.Text += ConquestQuest.returnMsg();
                    break;

                case 5:
                    Wealth WealthQuest = new Wealth(RandomNumberGenerator.NumberBetween(0, 3));
                    rtb1.Text += WealthQuest.returnMsg();
                    break;

                case 6:
                    Equipment EquipmentQuest = new Equipment(RandomNumberGenerator.NumberBetween(0, 4));
                    rtb1.Text += EquipmentQuest.returnMsg();
                    break;

                case 7:
                    Ability AbilityQuest = new Ability(RandomNumberGenerator.NumberBetween(0, 7));
                    rtb1.Text += AbilityQuest.returnMsg();
                    break;

                case 8:
                    Serenity SerenityQuest = new Serenity(RandomNumberGenerator.NumberBetween(0, 7));
                    rtb1.Text += SerenityQuest.returnMsg();
                    break;

                case 9:
                    Protection ProtectionQuest = new Protection(RandomNumberGenerator.NumberBetween(0, 7));
                    rtb1.Text += ProtectionQuest.returnMsg();
                    break;

                default:
                    rtb1.Text += "SOMETHING HAVE GONE WRONG";
                    rtb1.Text += "SOMETHING HAVE GONE WRONG";
                    rtb1.Text += "SOMETHING HAVE GONE WRONG";
                    rtb1.Text += "SOMETHING HAVE GONE WRONG";
                    rtb1.Text += "SOMETHING HAVE GONE WRONG";
                    break;
            }
        }
    }
}
