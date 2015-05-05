using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCG
{
    public class Knowledge
    {
        public int CallOfKnowledge = RandomNumberGenerator.NumberBetween(1, 5);

        public string returnMsg(out string QuestLog)
        {
            switch (CallOfKnowledge)
            {
                case 1:
                    subQuestPCG subquest = new subQuestPCG();

                    QuestLog = "Knowledge 1: Deliver  \n" + "Dear stranger, I must ask of your aid. You see I have found this powerful <ITEM> in a dungeon, I was exploring. However I am not quite ready to go home yet, but I need <NPC> to take a look at this <ITEM>. Will you please take it to <NPC>, I’m sure it will be worth your while.";
                    return subquest.returnMsg() + "\n";

                case 2:
                    spyPCG Spy = new spyPCG();

                    QuestLog = "Knowledge 2: (Spy) \n" + "Hey you there! Wanna earn some gold? You see that person over there? Thats <NPC>, I need you to follow him/her and report back to me once you have figured out what <NPC> are doing.";
                    return Spy.returnMsg() + "\n";

                case 3:
                    gotoPCG GOTO = new gotoPCG();
                    gotoPCG GOTO2 = new gotoPCG();
                    int tempInt = RandomNumberGenerator.NumberBetween(1, World.NPCs.Count + 1);

                    QuestLog = "Knowledge 3: (Interview) \n" + "I need your help! I have heard some troubling news around town, but I need to confirm rumor spreading. Can you <goto> and speak with <NPC>? He/she should be able to clear up if its true or just a rumor.";
                    return GOTO.returnMsg() + "\n" + "You Listen to what " + World.NPCbyID(tempInt).NPCName + " had to say \n" + GOTO2.returnMsg() + "\n" + "You reported what " + World.NPCbyID(tempInt).NPCName + " told you \n" + "\n";

                case 4:
                    gotoPCG GOTO3 = new gotoPCG();
                    gotoPCG GOTO4 = new gotoPCG();
                    getPCG get = new getPCG();
                   
                    QuestLog = "Knowledge 4: (Use Item In Field) \n" + "Hey you there, Please come and give me a hand, I need you to go and take this <ITEM> to <LOCATION> and tell me what happens. It’s probably not that dangerous.";
                    return get.returnMsg() + "\n" + GOTO3.returnMsg() + "\n" + "Use " + World.ItemByID(RandomNumberGenerator.NumberBetween(1, World.Items.Count + 1)).ItemName + "\n" + GOTO4.returnMsg() + "\n" + "Report the Results \n" + "\n";

                default:
                    QuestLog = "Something went wrong, in Knowledge";
                    return "Something went wrong, in Knowledge";
            }
        }
    }
}
