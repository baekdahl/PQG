using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Get
    {
        private int CallOfGet { get; set; }

        public Get(int callOfGet)
        {
            CallOfGet = callOfGet;
        }

        public string returnMsg()
        {
            switch (CallOfGet + 1)
            {
            case 1:
                //Already have it
                return "Get 1: You Already have this Item \n";

            case 2:
                //steal
                steal Steal = new steal(RandomNumberGenerator.NumberBetween(0,1));
                return "Get 2: \n" + Steal.returnMsg();

            case 3:
                //goto
                //"gather"
                GoTo GOTO = new GoTo(RandomNumberGenerator.NumberBetween(0, 2));
                return "Get 3: \n" + GOTO.returnMsg() + "You gather the ITEM" + "\n";

            case 4:
                //goto
                //get
                //goto
                //subquest
                //"exchange"
                GoTo GOTO2 = new GoTo(RandomNumberGenerator.NumberBetween(0, 2));
                Get get = new Get(RandomNumberGenerator.NumberBetween(0, 3));
                GoTo GOTO3 = new GoTo(RandomNumberGenerator.NumberBetween(0, 2));
                Subquest subquest = new Subquest(RandomNumberGenerator.NumberBetween(0, 1));
                return "Get 4: \n" + GOTO2.returnMsg() + get.returnMsg()  + GOTO3.returnMsg() + subquest.returnMsg() + "You exchange ITEMS?" + " \n";

            default:
                return "Something went wrong, in Get";
            }
        }
    }
}
