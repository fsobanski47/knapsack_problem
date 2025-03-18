using Knapsack;

namespace UnitTests
{
    [TestClass]
    public class RepetitionTest
    {
        [TestMethod]
        public void TestMethodRepetition()
        {
            List<int> sizes = [10, 20, 30, 40, 50];
            List<int> capacities = [30, 40, 50, 60, 70];
            foreach (int size in sizes)
            {
                Random random = new();
                Problem problem = new(size, random.Next());
                foreach (int capacity in capacities)
                {
                    Result result = problem.Solve(capacity);
                    foreach (var firstItem in problem.itemList)
                    {
                        int repetitionCount = 0;
                        foreach (var secondItem in problem.itemList)
                        {
                            if (firstItem == secondItem) repetitionCount++;
                        }
                        Assert.IsTrue(repetitionCount == 1);
                    }
                }
            }
        }
    }
}
