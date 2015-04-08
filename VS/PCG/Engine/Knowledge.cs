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
            
            
            switch (CallOfKnowledge + 1)
            {
            case 1:
                Console.WriteLine("Deliever");
                Subquest subquest = new Subquest(0);
                break;
            
            case 2:
                Console.WriteLine("Spy");
                break;
            
            case 3:
                Console.WriteLine("Interview");
                break;
            
            case 4:
                Console.WriteLine("Use Item In Field");
                break;
            
            default:
                Console.WriteLine("Something went wrong, in Knowledge");
                break;
            }
        }

    }
}