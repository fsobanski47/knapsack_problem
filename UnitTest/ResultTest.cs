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
            var resultChecklist = new List<int> {0, 2, 7, 9, 1, 5};
            Assert.IsTrue(Enumerable.SequenceEqual(resultChecklist, result.itemNumbers));
        } 
    }
}
