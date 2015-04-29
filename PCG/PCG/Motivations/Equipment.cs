using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCG
{
    public class Equipment
    {
        private int CallOfEquipment { get; set; }


        public Equipment(int callOfEquipment)
        {
            CallOfEquipment = callOfEquipment;
        }

        public string returnMsg(out string Questlog)
        {
            switch (CallOfEquipment)
            {
                case 1:
                Questlog = "Equipment 1: (Assemble) \n" + "You there, are you as good at your trait as you are with your swordplay? We could really use the help from a talented worker, to help us to restore our stocks.";
                    return "You assemble some gear \n";

                case 2:
                    getPCG get = new getPCG(RandomNumberGenerator.NumberBetween(1, 5));
                    gotoPCG GOTO = new gotoPCG(RandomNumberGenerator.NumberBetween(1, 4));

                    Questlog = "Equipment 2: (Deliver Supplies) \n" + "Hey you there, can I request a moment? I am a merchant from <LOCATION>, and I seem to have lost my way, could you be of assistance and take these materials to the <NPC:JOB>.";
                    return  get.returnMsg() + "\n" + GOTO.returnMsg() + "\n" + "Give the materials to " + World.NPCbyID(RandomNumberGenerator.NumberBetween(1, World.NPCs.Count + 1)).NPCName + "\n";

                case 3:
                    stealPCG Steal = new stealPCG(RandomNumberGenerator.NumberBetween(1, 3));
                    Questlog = "Equipment 3: (Steal Supplies) \n" + "You want to earn a few coins? You see those supplies over there? Good, I need you to go get them for me. ehmm I of course own them, I just need someone to pick them up for me.";
                    return Steal.returnMsg() + "\n";

                case 4:
                    gotoPCG GOTO2 = new gotoPCG(RandomNumberGenerator.NumberBetween(1, 4));
                    Questlog = "Equipment 4: (Trade for supplies) \n" + "Please go to the big market in <location>, and find me some <item:supplies>.";
                    return GOTO2.returnMsg() + "\n" + "Meet up with merchants and trade for resources \n";

                default:
                    Questlog = "Something went wrong, in Equipment";
                    return "Something went wrong, in Equipment";
            }
        }
    }
}
