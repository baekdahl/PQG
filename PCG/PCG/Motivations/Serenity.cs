using System;
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
                    Questlog = "Serenity 1: (Revenge, Justice) \n" + "We have been attacked and are in dire need of your aid. You see <NPC> went amok during the night after losing a brawl in the tavern. He/She fled town before we could get around to capture him/her. We can’t leave town, but could we get you to hunt him/she down.";  
                    return GOTO.returnMsg() + "\n" + "Damgage for Justice \n" + "\n";
                  
                case 2:
                    getPCG get = new getPCG(RandomNumberGenerator.NumberBetween(1, 5));
                    gotoPCG GOTO2 = new gotoPCG(RandomNumberGenerator.NumberBetween(1, 4));
                    gotoPCG GOTO3 = new gotoPCG(RandomNumberGenerator.NumberBetween(1, 4));
                    Questlog = "Serenity 2: (Capture Criminal(1)) \n" + "Enough must be enough, do you have a moment to help me? You see a prisoner called <NPC> escaped last night, we must capture him again! Please find out where he is and bring him/her back."; 
                    return get.returnMsg() + "\n" + GOTO2.returnMsg() + "\n" + "Use item" + "\n" + GOTO3.returnMsg() + "\n" + "Hand over Criminal \n";

                case 3:
                    getPCG get2 = new getPCG(RandomNumberGenerator.NumberBetween(1, 5));
                    gotoPCG GOTO4 = new gotoPCG(RandomNumberGenerator.NumberBetween(1, 4));
                    gotoPCG GOTO5 = new gotoPCG(RandomNumberGenerator.NumberBetween(1, 4));
                    capturePCG Capture = new capturePCG(1);
                    Questlog = "Serenity 3: (Capture Criminal(2)) \n" + "Hey there, got time to help us? You see a <enemy> <NPC> have made a lot of trouble lately, but we do not have the manpower to bring him in. Could you go and capture him/her for the us?"; 
                    return get2.returnMsg() + "\n" + GOTO4.returnMsg() + "\n" + Capture.returnMsg() + "\n" + GOTO5.returnMsg() + "\n" + "Hand over Criminal \n";

                case 4:
                    gotoPCG GOTO6 = new gotoPCG(RandomNumberGenerator.NumberBetween(1, 4));
                    gotoPCG GOTO7 = new gotoPCG(RandomNumberGenerator.NumberBetween(1, 4));
                    Questlog = "Serenity 4: (Check on NPC(1)) \n" + "Hey you there, can you help me with a small favour? You see my friend have fallen sick, and I don’t have the time to go check on him, could you go check for me?"; 
                    return GOTO6.returnMsg() + "\n" + "Listen to NPC" + "\n" + GOTO7.returnMsg() + "\n" + "Report to NPC \n";

                case 5:
                    gotoPCG GOTO8 = new gotoPCG(RandomNumberGenerator.NumberBetween(1, 4));
                    gotoPCG GOTO9 = new gotoPCG(RandomNumberGenerator.NumberBetween(1, 4));
                    Questlog = "Serenity 5: (Check on NPC(2)) \n" + "Hey you there, can you help me with a small favour? You see my friend have fallen sick, and I don’t have the time to go bring him his medicine, could you go check for me?";
                    return GOTO8.returnMsg() + "\n" + "Take ITEM" + "\n" + GOTO9.returnMsg() + "\n" + "Give ITEM to NPC \n";

                case 6:
                    getPCG get3 = new getPCG(RandomNumberGenerator.NumberBetween(1, 5));
                    gotoPCG GOTO10 = new gotoPCG(RandomNumberGenerator.NumberBetween(1, 4));
                    Questlog = "Serenity 6: (Recover Lost/stolen item) \n" + "Hey you, could you help me? I seem to have misplaced my <ITEM>, I was traveling through <LOCATION>, could you go get it back for me?"; 
                    return get3.returnMsg() + "\n" + GOTO10.returnMsg() + "\n" + "Give item to NPC \n";

                case 7:
                    gotoPCG GOTO11 = new gotoPCG(RandomNumberGenerator.NumberBetween(1, 4));
                    gotoPCG GOTO12 = new gotoPCG(RandomNumberGenerator.NumberBetween(1, 4));
                    Questlog = "Serenity 7: (Rescue Captured NPC) \n" + "Can you help me with rescuing <NPC>? He/she seem to have been captured in a nearby <enemy> camp. Please release him/her."; 
                    return GOTO11.returnMsg() + "Damage enemies and escort NPC" + "\n" + GOTO12.returnMsg() + "\n" + "Report your Succes to NPC \n" + "\n";

                default:
                    Questlog = "Something went wrong, in Serenity";
                    return "Something went wrong, in Serenity";
            }
        }
    }
}
