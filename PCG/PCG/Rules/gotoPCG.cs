using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCG
{
    public class gotoPCG
    {
        private int CallofGoto { get; set; }

        public gotoPCG(int callOfGoto)
        {
            CallofGoto = callOfGoto;
        }

        public string returnMsg()
        {
            switch (CallofGoto + 1)
            {
            case 1:
                //Already there
                //World.LocationByID(RandomNumberGenerator.NumberBetween(0, 4)).LocationName
                return "Goto 1: You are already at " + World.LocationByID(RandomNumberGenerator.NumberBetween(1, World.Locations.Count + 1)).LocationName + "\n";

            case 2:
                //Explore area
                return "Goto 2: You wander around the world, exploring until you stumble upon " + World.LocationByID(RandomNumberGenerator.NumberBetween(1, World.Locations.Count + 1)).LocationName + "\n";
                
            case 3:
                //learn
                //"goto"
                learnPCG learn = new learnPCG(RandomNumberGenerator.NumberBetween(0, 3));
                return "Goto 3: You need to learn the location \n" + learn.returnMsg() + "You walk to " + World.LocationByID(RandomNumberGenerator.NumberBetween(1, World.Locations.Count + 1)).LocationName + "\n";

            default:
                return "Something went wrong, in goto" + "\n";
            }
        }
    }
}
