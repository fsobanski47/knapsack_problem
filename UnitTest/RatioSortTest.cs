using Knapsack;

namespace UnitTests
{
    [TestClass]
    public class RatioSortTest
    {
        [TestMethod]
        public void TestMethodIsRatioSorted()
        {
            List<int> sizes = [10, 20, 30, 40, 50];
            int capacity = 35;
            foreach (int size in sizes)
            {
                Random random = new();
                Problem problem = new(size, random.Next());
                Result result = problem.Solve(capacity);
                for (int i = 0; i < size; i++)
                {
                    double ratio1 = (double)problem.itemList[i].Value / problem.itemList[i].Weight;
                    double ratio2 = (double)problem.itemList[i + 1].Value / problem.itemList[i + 1].Weight;
                    Assert.IsTrue(ratio1 >= ratio2);
                }
            }
        }
    }
}
