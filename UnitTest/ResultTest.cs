using Knapsack;

namespace UnitTests
{
    [TestClass]
    public class ResultTest
    {
        [TestMethod]
        public void TestMethodResult()
        {
            int size = 10;
            int seed = 1;
            Problem problem = new(size, seed);
            int capacity = 35;
            Result result = problem.Solve(capacity);
            Assert.IsTrue(result.totalValue == 31 && result.totalWeight == 33);
            bool rightOrder = true;
            if (result.itemNumbers[0] != 0) rightOrder = false;
            if (result.itemNumbers[1] != 2) rightOrder = false;
            if (result.itemNumbers[2] != 7) rightOrder = false;
            if (result.itemNumbers[0] != 9) rightOrder = false;
            if (result.itemNumbers[1] != 1) rightOrder = false;
            if (result.itemNumbers[2] != 5) rightOrder = false;
            Assert.IsTrue(rightOrder);
        } 
    }
}
