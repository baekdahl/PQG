using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCG
{
    public class Protection
    {
        public int CallOfProtection = RandomNumberGenerator.NumberBetween(1, 8);

        public string returnMsg(out string Questlog)
        {
            switch (CallOfProtection)
            {
                case 1:
                    gotoPCG GOTO = new gotoPCG();
                    gotoPCG GOTO2 = new gotoPCG();

                    Questlog = "Protection 1: (Attack threatening entities) \n" + "Please help us, the <enemy> have been really violent lately. Could you help us by taking them down?";
                    return GOTO.returnMsg() + "\n" + "Damage Entities \n" + GOTO2.returnMsg() + "\n" + "Report success \n";

                case 2:
                    getPCG get = new getPCG();
                    gotoPCG GOTO3 = new gotoPCG();
                    Questlog = "Protection 2: (Treat or Repair(1)) \n" + "Can you please take this <item:Consumable> and go use it at <location>. It will really help the entire village.";
                    return get.returnMsg() + "\n" + GOTO3.returnMsg() + "\n" + "Use item\n";

                case 3:
                    gotoPCG GOTO4 = new gotoPCG();
                    Questlog = "Protection 3: (Treat or Repair(2)) \n" + "Please helps us! After the last attack one of our walls have started collapsing, so we need all the manpower we have to keep it intact. Please go there and help repair it.";
                    return GOTO4.returnMsg() + "\n" + "Repair item\n";

                case 4:
                    gotoPCG GOTO5 = new gotoPCG();
                    getPCG get2 = new getPCG();
                    Questlog = "Protection 4: (Create Diversion(1)) \n" + "Please sire, we need your help. We are currently under attack at our gates and we need to reinforce it if we don’t want to fall. Could you use the back gate and goto <LOCATION> to use these explosives.";
                    return get2.returnMsg() + "\n" + GOTO5.returnMsg() + "\n" + "Use ITEM\n";

                case 5:
                    gotoPCG GOTO6 = new gotoPCG();

                    Questlog = "Protection 5: (Create Diversion(2)) \n" + "Please sire, we need help to with closing our gate. We need you to go make a diversion so we can get the last few townsfolk inside before the <enemy> hit the gate.";
                    return GOTO6.returnMsg() + "\n" + "Damage NPC \n";

                case 6:
                    gotoPCG GOTO7 = new gotoPCG();
                    Questlog = "Protection 6: (Assemble Fortification) \n" + "I need help with assembling some fortifications, could you be of assistance?";
                    return GOTO7.returnMsg() + "\n" + "repair item\n";

                case 7:
                    gotoPCG GOTO8 = new gotoPCG();
                    Questlog = "Protection 7: (Guard Entity) \n" + "Please sire, you need to help me. Please go and find <NPC>, he is in grave danger, and needs to be defended.";
                    return GOTO8.returnMsg() + "\n" + "Defend the Entity\n";

                default:
                    Questlog = "Something went wrong, in Protection";
                    return "Something went wrong, in Protection";
            }
        }
    }
}
