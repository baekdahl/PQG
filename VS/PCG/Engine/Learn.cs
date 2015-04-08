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

            switch (CallOfLearn + 1)
            {
            case 1:
                Console.WriteLine("You Already Know This");
                break;

            case 2:
                break;

            default:
                Console.WriteLine("Something went wrong, in Learn");
                break;
            }
        }
    }
}
