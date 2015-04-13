using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCG
{
    public class stealPCG
    {
        private int CallOfSteal { get; set; }

        public stealPCG(int callOfSteal)
        {
            CallOfSteal = callOfSteal;
        }

        public string returnMsg()
        {
            switch (CallOfSteal + 1)
            {
            case 1:
                //goto
                //"stealth"
                //"take"

                gotoPCG GOTO = new gotoPCG(RandomNumberGenerator.NumberBetween(0, 2));
                return "Steal 1: \n" + GOTO.returnMsg() + "You stealth up close to " + World.NPCbyID(RandomNumberGenerator.NumberBetween(1,World.NPCs.Count + 1)).NPCName +" and pick up " + World.ItemByID(RandomNumberGenerator.NumberBetween(1, World.Items.Count + 1)).ItemName + " out of their pockets" + "\n";

            case 2:
                //goto
                //kill
                //"take"

                gotoPCG GOTO2 = new gotoPCG(RandomNumberGenerator.NumberBetween(0, 2));
                killPCG Kill = new killPCG(0);
                return "Steal 2: \n" + GOTO2.returnMsg() + Kill.returnMsg() + "You pick up " + World.ItemByID(RandomNumberGenerator.NumberBetween(1, World.Items.Count + 1)).ItemName + " from " + World.NPCbyID(RandomNumberGenerator.NumberBetween(1, World.NPCs.Count + 1)).NPCName + " corpse \n" + "\n";

            default:
                return "Something went wrong, in Steal";
            }
        }
    }
}
