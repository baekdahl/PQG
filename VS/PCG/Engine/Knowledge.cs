using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Knowledge
    {
        private int CallOfKnowledge { get; set; }


        public Knowledge(int callOfKnowledge)
        {
            CallOfKnowledge = callOfKnowledge;
        }

        public string returnMsg()
        {
            switch (CallOfKnowledge + 1)
            {
                case 1:
                    Subquest subquest = new Subquest(0);
                    return "Deliever" + subquest.returnMsg();
                  
                case 2:
                    return "Spy";

                case 3:
                    return "Interview";

                case 4:
                    return "Use Item In Field";

                default:
                    return "Something went wrong, in Knowledge";
            }
        }

    }
}