using WSUniversalLib;
using static System.Console;
using static System.Convert;

namespace Agents
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Calculation calculation = new();
            int agentType, priority;
            float age, experience;

            try
            {
                Write("Введите тип агента: ");
                agentType = ToInt32(ReadLine());
                Write("Введите возраст агента: ");
                age = (float)ToDecimal(ReadLine());
                Write("Введите опыт работы агента: ");
                experience = (float)ToDecimal(ReadLine());
            }
            catch
            {
                agentType = 0;
                age = 0;
                experience = 0;
            }

            priority = calculation.GetPriorityForAgent(agentType, age, experience);
            WriteLine($"Приоритет агента: {priority}");
        }
    }
}