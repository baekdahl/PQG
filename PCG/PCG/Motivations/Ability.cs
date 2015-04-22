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

        public string returnMsg(out string QuestLog)
        {
            switch (CallOfAbility)
            {
                case 1:
                    QuestLog = "Ability 1: (Assemble tool for new skill) \n"; 
                    return "You assemble some tools for a new skill." + " You Equip the newly crafted skill \n";

                case 2:
                    getPCG get = new getPCG(RandomNumberGenerator.NumberBetween(1, 5));

                    QuestLog = "Ability 2: (Obtain training materials) \n";
                    return get.returnMsg() + "\n" + "You use the materials \n";

                case 3:
                    QuestLog = "Ability 3: (Use excisting tools) \n";
                    return "You use the tools you already had \n" + "\n";

                case 4:
                    QuestLog = "Ability 4: (Practice combat) \n";
                    return "Practice combat \n";

                case 5:
                    QuestLog = "Ability 5: (Practice skill) \n";
                    return "Practice skill \n";

                case 6:
                    getPCG get2 = new getPCG(RandomNumberGenerator.NumberBetween(1, 5));
                    QuestLog = "Ability 6: (Research a skill(1)) \n";
                    return get2.returnMsg() + "\n" + "Use the skill \n";

                case 7:
                    getPCG get3 = new getPCG(RandomNumberGenerator.NumberBetween(1, 5));
                    QuestLog = "Ability 7: (Research a skill(2)) \n";
                    return get3.returnMsg() + "\n" + "Experiment with the skill \n";

                default:
                    QuestLog = "Something went wrong, in Ability";
                    return "Something went wrong, in Ability";
            }
        }
    }
}
