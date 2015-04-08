using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Learn
    {
        private int CallOfLearn { get; set; }

        public Learn(int callOfLearn)
        {
            CallOfLearn = callOfLearn;
        }

        public string returnMsg()
        {
            switch (CallOfLearn + 1)
            {
            case 1:
                //Already know it
                return "Learn 1: You Already Know This \n";

            case 2:
                //goto
                //subquest
                //"listen"
                GoTo GOTO = new GoTo(RandomNumberGenerator.NumberBetween(0, 2));
                Subquest subquest = new Subquest(RandomNumberGenerator.NumberBetween(0, 1));

                return "Learn 2: \n" + GOTO.returnMsg() + subquest.returnMsg() + "You listen to NPC" + "\n";

            case 3:
                //goto
                //get
                //"read"
                GoTo GOTO2 = new GoTo(RandomNumberGenerator.NumberBetween(0, 2));
                Get get = new Get(RandomNumberGenerator.NumberBetween(0, 3));
                return "Learn 3: \n" + GOTO2.returnMsg() + get.returnMsg() + "Read what is written \n";
 
            case 4:
                //get
                //subquest
                //"give"
                //"Listen"
                Get get2 = new Get(RandomNumberGenerator.NumberBetween(0, 3));
                Subquest subquest2 = new Subquest(RandomNumberGenerator.NumberBetween(0, 1));

                return "Learn 4: \n" + get2.returnMsg() + subquest2.returnMsg() + "the NPC gave you this INFO" + "\n";

            default:
                return "Something went wrong, in Learn" + "\n";
            }
        }
    }
}
