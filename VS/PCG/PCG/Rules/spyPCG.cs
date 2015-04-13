using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCG
{
    public class spyPCG
    {
        private int CallOfSpy;

        public spyPCG(int callOfSpy)
        {
            CallOfSpy = callOfSpy;
        }

        public string returnMsg()
        {
            switch (CallOfSpy + 1)
            {
            case 1:
                //goto
                //"spy"
                //goto
                //"report"
                gotoPCG GOTO = new gotoPCG(RandomNumberGenerator.NumberBetween(0, 2));
                gotoPCG GOTO2 = new gotoPCG(RandomNumberGenerator.NumberBetween(0, 2));
                return "Spy 1: \n" + GOTO.returnMsg() + "You spy on " + World.NPCbyID(RandomNumberGenerator.NumberBetween(1, World.NPCs.Count + 1)).NPCName + "\n" + GOTO2.returnMsg() + "You returned to " + World.LocationByID(RandomNumberGenerator.NumberBetween(1, World.Locations.Count + 1)).LocationName + " and reported what you learned.\n" + "\n";

            default:
                return "Something went wrong, in Spy";
            }
        }
    }
}
