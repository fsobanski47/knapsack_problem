using Knapsack;

namespace UnitTests
{
    [TestClass]
    public class RestrictionTest
    {
        [TestMethod]
        public void TestMethodRestrictions()
        {
            List<int> sizes = [10, 20, 30, 40, 50];
            List<int> capacities = [30, 40, 50, 60, 70];
            foreach(int size in sizes)
            {
                Random random = new();
                Problem problem = new(size, random.Next());
                
                foreach(int capacity in capacities)
                {
                    Result result = problem.Solve(capacity);
                    bool doesFit = false;
                    foreach(var item in problem.itemList)
                    {
                        if(item.Weight <= capacity)
                        {
                            doesFit = true;
                            break;
                        }
                    }
                    Assert.IsTrue(doesFit && (result.itemNumbers.Count != 0) || (!doesFit && (result.itemNumbers.Count == 0)));
                }

            }
        }
    }
}
