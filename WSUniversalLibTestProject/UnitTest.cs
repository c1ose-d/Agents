using WSUniversalLib;
using static System.Math;

namespace WSUniversalLibTestProject
{
    [TestClass]
    public class UnitTest
    {
        private Calculation Calculation { get; } = new();

        [TestMethod]
        public void CalculationTest_ZeroAgentType()
        {
            int expected = -1, actual, agentType = 0;
            float age = 23, expirience = 1.5F;

            actual = Calculation.GetPriorityForAgent(agentType, age, expirience);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CalculationTest_ZeroAge()
        {
            int expected = -1, actual, agentType = 2;
            float age = 0, expirience = 1.5F;

            actual = Calculation.GetPriorityForAgent(agentType, age, expirience);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CalculationTest_ZeroExpirience()
        {
            int expected = 0, actual, agentType = 2;
            float age = 23, expirience = 0;

            actual = Calculation.GetPriorityForAgent(agentType, age, expirience);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CalculationTest_DefaultValues()
        {
            int expected = 5, actual, agentType = 2;
            float age = 23, expirience = 1.5F;

            actual = Calculation.GetPriorityForAgent(agentType, age, expirience);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CalculationTest_NotDefaultValues()
        {
            int expected = 20, actual, agentType = 3;
            float age = 28, expirience = 5;

            actual = Calculation.GetPriorityForAgent(agentType, age, expirience);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CalculationTest_FloatAgentTypeInInt32Represent()
        {
            int expected = 3, actual;
            float agentType = 1.5F, age = 23, expirience = 1.5F;

            actual = Calculation.GetPriorityForAgent((int)agentType, age, expirience);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CalculationTest_ZeroAllValues()
        {
            int expected = -1, actual, agentType = 0;
            float age = 0, expirience = 0;

            actual = Calculation.GetPriorityForAgent(agentType, age, expirience);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CalculationTest_MoreAgentType()
        {
            int expected = -1, actual, agentType = 4;
            float age = 23, expirience = 1.5F;

            actual = Calculation.GetPriorityForAgent(agentType, age, expirience);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CalculationTest_ExpirienceMoreThanAge()
        {
            int expected = -1, actual, agentType = 2;
            float age = 1.5F, expirience = 23;

            actual = Calculation.GetPriorityForAgent(agentType, age, expirience);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CalculationTest_PriorityMoreThenZero()
        {
            int expected = 0, actual, agentType = 2;
            float age = 23, expirience = 1.5F;

            actual = Calculation.GetPriorityForAgent(agentType, age, expirience);

            Assert.IsTrue(expected < actual);
        }

        [TestMethod]
        public void CalculationTest_PriorityDevidedByEcxpirienceAreNotEqualExpirience()
        {
            int agentType = 2;
            float age = 23, expirience = 1.5F, expected = expirience, actual;

            actual = Calculation.GetPriorityForAgent(agentType, age, expirience);
            actual /= expirience;

            Assert.AreNotEqual(expected, actual);
        }

        [TestMethod]
        public void CalculationTest_RoundedPriorityDevidedByEcxpirienceAreNotEqualExpirience()
        {
            int agentType = 2;
            float age = 23, expirience = 1.5F, expected = expirience, actual;

            actual = Calculation.GetPriorityForAgent(agentType, age, expirience);
            actual /= expirience;
            actual = (float)Round(actual);

            Assert.AreNotEqual(expected, actual);
        }

        [TestMethod]
        public void CalculationTest_RoundedPriorityDevidedByEcxpirienceMoreThanExpirience()
        {
            int agentType = 2;
            float age = 23, expirience = 1.5F, expected = expirience, actual;

            actual = Calculation.GetPriorityForAgent(agentType, age, expirience);
            actual /= expirience;
            actual = (float)Round(actual, 1);

            Assert.IsFalse(expected > actual);
        }

        [TestMethod]
        public void CalculationTest_RoundedPriorityDevidedByEcxpirienceMoreThanZero()
        {
            int agentType = 2;
            float age = 23, expirience = 1.5F, expected = 0, actual;

            actual = Calculation.GetPriorityForAgent(agentType, age, expirience);
            actual /= expirience;
            actual = (float)Round(actual, 1);

            Assert.IsFalse(expected > actual);
        }

        [TestMethod]
        public void CalculationTest_OneAllValues()
        {
            int expected = -1, actual, agentType = 1;
            float age = 1, expirience = 1;

            actual = Calculation.GetPriorityForAgent(agentType, age, expirience);

            Assert.AreEqual(expected, actual);
        }
    }
}