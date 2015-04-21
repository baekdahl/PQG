using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCG
{
    public class Ability
    {
        private int CallOfAbility { get; set; }

        public Ability(int callOfAbility)
        {
            CallOfAbility = callOfAbility;
        }

        public string returnMsg()
        {
            switch (CallOfAbility)
            {
                case 1:
                    return "Ability 1: (Assemble tool for new skill) " + "\n" + "You assemble some tools for a new skill." + " You Equip the newly crafted skill \n";

                case 2:
                    getPCG get = new getPCG(RandomNumberGenerator.NumberBetween(1, 5));
                    return "Ability 2: (Obtain training materials) " + "\n" + get.returnMsg() + "\n" + "You use the materials \n";

                case 3:
                    return "Ability 3: (Use excisting tools) \n" + "You use the tools you already had \n" + "\n";

                case 4:
                    return "Ability 4: (Practice combat) \n" + "Practice combat \n";

                case 5:
                    return "Ability 5: (Practice skill) \n" + "Practice skill \n";

                case 6:
                    getPCG get2 = new getPCG(RandomNumberGenerator.NumberBetween(1, 5));
                    return "Ability 6: (Research a skill(1)) \n" + get2.returnMsg() + "\n" + "Use the skill \n";

                case 7:
                    getPCG get3 = new getPCG(RandomNumberGenerator.NumberBetween(1, 5));
                    return "Ability 7: (Research a skill(2)) \n" + get3.returnMsg() + "\n" + "Experiment with the skill \n";

                default:
                    return "Something went wrong, in Ability";
            }
        }
    }
}
