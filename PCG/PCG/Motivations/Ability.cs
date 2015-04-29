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
                    QuestLog = "Ability 1: (Assemble tool for new skill) \n" + "Go craft a new set of tools, with your newly acquired skills."; 
                    return "You assemble some tools for a new skill." + " You Equip the newly crafted skill \n";

                case 2:
                    getPCG get = new getPCG(RandomNumberGenerator.NumberBetween(1, 5));

                    QuestLog = "Ability 2: (Obtain training materials) \n" + "To improve your skills, you will need to get some <item:materials> to practice with.";
                    return get.returnMsg() + "\n" + "You use the materials \n";

                case 3:
                    QuestLog = "Ability 3: (Use excisting tools) \n" + "You need to craft up some valuables, luckily you already have the required tools.";
                    return "You use the tools you already had \n" + "\n";

                case 4:
                    QuestLog = "Ability 4: (Practice combat) \n" + "You need to practice your skill at arms, go to the nearst target dummy and hit it a few times.";
                    return "Practice combat \n";

                case 5:
                    QuestLog = "Ability 5: (Practice skill) \n" + "To get better at your current skill, you must use some of the training materials you have.";
                    return "Practice skill \n";

                case 6:
                    getPCG get2 = new getPCG(RandomNumberGenerator.NumberBetween(1, 5));
                    QuestLog = "Ability 6: (Research a skill(1)) \n" + "To learn a new skill you must research it. Go get something, and use it to acquire its skill.";
                    return get2.returnMsg() + "\n" + "Use the skill \n";

                case 7:
                    getPCG get3 = new getPCG(RandomNumberGenerator.NumberBetween(1, 5));
                    QuestLog = "Ability 7: (Research a skill(2)) \n" + "To learn a new skill you must research it. Go get something, and experiment with it, until you figure out it purpose.";
                    return get3.returnMsg() + "\n" + "Experiment with the skill \n";

                default:
                    QuestLog = "Something went wrong, in Ability";
                    return "Something went wrong, in Ability";
            }
        }
    }
}
