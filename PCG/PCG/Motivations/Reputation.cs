using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCG
{
    public class Reputation
    {
        public int CallofReputation = RandomNumberGenerator.NumberBetween(1, 4);

        public string returnMsg(out string Questlog)
        {
            switch (CallofReputation)
            {
                case 1:
                    getPCG get = new getPCG();
                    gotoPCG GOTO = new gotoPCG();
                    Questlog = "Reputation 1: (Obtain rare item) \n" + "Hey you! Go bring me some <rare:ITEM>. oh you don’t work for me? Oh well I am still willing to let you do the job, go bring me the <rare:ITEM> and you will be well rewarded, you might even get another job."; 
                    return get.returnMsg() + "\n" + GOTO.returnMsg() + "\n" + "Give NPC rare ITEM \n" + "\n";

                case 2:
                    gotoPCG GOTO2 = new gotoPCG();
                    killPCG Kill = new killPCG();
                    gotoPCG GOTO3 = new gotoPCG();

                    Questlog = "Reputation 2: (Kill enemies) \n" + "This is not good! We need you to do us a favour, it seems like that some <enemies> have taken up hold in a nearby ruin. Could you go take care of them, so the town will be safe?"; 
                    return GOTO2.returnMsg() + "\n" + Kill.returnMsg() + "\n" + GOTO3.returnMsg() + "\n" + "Report success to NPC \n" + "\n";

                case 3:
                    gotoPCG GOTO4 = new gotoPCG();
                    gotoPCG GOTO5 = new gotoPCG();
                    Questlog = "Reputation 3: (Visit a Dangerous place) \n" + "I need  you to go and survey a ruin up ahead. We have had disturbing rumours that the enemies have been gathering there. You don’t need to do anything but survey the area.";
                    return GOTO4.returnMsg() + "\n" + GOTO5.returnMsg() + "\n" + "Report your visit to NPC \n" + "\n";

                default:
                    Questlog = "Something went wrong, in Reputation";
                    return "Something went wrong, in Reputation";
            }
        }
    }
}
