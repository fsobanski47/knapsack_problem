using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
[assembly: InternalsVisibleTo("UnitTests")]
namespace Knapsack
{
    class Problem
    {
        private readonly int numberOfItems;
        public List<Item> itemList = [];

        public Problem(int n, int seed)
        {
            numberOfItems = n;
            Random random = new(seed);
            for(int i = 0; i < numberOfItems; i++)
            {
                int value = random.Next(1, 11);
                int weight = random.Next(1, 11);
                itemList.Add(new Item(value, weight, i));
            }
        }

        public override string ToString()
        {
            return string.Join(Environment.NewLine, itemList.Select(item => item.ToString()));
        }

        public Result Solve(int capacity)
        {
            itemList = itemList.OrderByDescending(item => (double)item.Value / item.Weight).ToList();
            int totalWeight = 0;
            int totalValue = 0;

            for(int i = 0; i < itemList.Count; i++)
            {
                if (totalWeight + itemList[i].Weight <= capacity)
                {
                    itemList[i].InsertItem();
                    totalWeight += itemList[i].Weight;
                    totalValue += itemList[i].Value;
                }
                if (totalWeight == capacity) break;
            }

            Result result = new(totalValue, totalWeight);
            for(int i = 0; i < itemList.Count; i++)
            {
                if(itemList[i].Inserted) result.AddItemNumber(itemList[i].Number);
            }
            return result;
        }
    }
}
