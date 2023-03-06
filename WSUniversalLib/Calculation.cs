using static System.Convert;
using static System.Math;

namespace WSUniversalLib
{
    public class Calculation
    {
        private readonly float[] agentTypes = { 1.8F, 3.2F, 4.1F };
        private readonly float[] experiences = { 0.5F, 0.7F, 0.9F };
        private readonly float[] young = { 0.1F, 0.17F, 0.26F };

        public int GetPriorityForAgent(int agentType, float age, float experience)
        {
            float priority;

            if (experience >= age)
            {
                return -1;
            }

            switch (agentType)
            {
                case 1:
                    priority = agentTypes[0];
                    break;
                case 2:
                    priority = agentTypes[1];
                    break;
                case 3:
                    priority = agentTypes[2];
                    break;
                default:
                    return -1;
            }

            if (experience > 40)
            {
                priority += experiences[0];
            }
            else if (experience > 20)
            {
                priority += experiences[0];
            }
            else if (experience > 10)
            {
                priority += experiences[0];
            }

            if (age <= 25 && experience <= 3)
            {
                switch (agentType)
                {
                    case 1:
                        priority += young[0];
                        break;
                    case 2:
                        priority += young[1];
                        break;
                    case 3:
                        priority += young[2];
                        break;
                }
            }

            priority *= experience;

            return ToInt32(Round(priority));
        }
    }
}