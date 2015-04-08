using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class GoTo
    {
        private int CallofGoto { get; set; }

        public GoTo(int callOfGoto)
        {
            CallofGoto = callOfGoto;

            switch (CallofGoto + 1)
            {
            case 1:
                Console.WriteLine("You are already at this LOCATION");
                break;
            
            case 2:
                Console.WriteLine("You wander around the world, exploring until you stumble upon your LOCATION");
                break;
            
            case 3:
                //learn
                //go there (goto)
                break;

            default:
                Console.WriteLine("Something went wrong, in goto");
                break;
            }
        }
    }
}