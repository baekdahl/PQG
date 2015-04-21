using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCG
{
    public class getPCG
    {
        private int CallOfGet { get; set; }

        public getPCG(int callOfGet)
        {
            CallOfGet = callOfGet;
        }

        public string returnMsg()
        {
            switch (CallOfGet)
            {
            case 1:
                //Already have it
                return "Get 1: You already have it";

            case 2:
                //steal
                stealPCG Steal = new stealPCG(RandomNumberGenerator.NumberBetween(1, 3));
                return "Get 2: Steal it from somebody \n" + Steal.returnMsg();

            case 3:
                //goto
                //"gather"
                gotoPCG GOTO = new gotoPCG(RandomNumberGenerator.NumberBetween(1, 4));
                return "Get 3: Go someplace and pick something up that’s lying around there. \n" + GOTO.returnMsg();

            case 4:
                //goto
                //get
                //goto
                //subquest
                //"exchange"
                gotoPCG GOTO2 = new gotoPCG(RandomNumberGenerator.NumberBetween(1, 4));
                getPCG get = new getPCG(RandomNumberGenerator.NumberBetween(1, 5));
                gotoPCG GOTO3 = new gotoPCG(RandomNumberGenerator.NumberBetween(1, 4));
                subQuestPCG subquest = new subQuestPCG(RandomNumberGenerator.NumberBetween(1, 3));
                return "Get 4: Go someplace, get something, do a subquest for somebody return and exchange. \n" + GOTO2.returnMsg() + get.returnMsg()  + GOTO3.returnMsg() + subquest.returnMsg();

            default:
                return "Something went wrong, in Get";
            }
        }
    }
}
