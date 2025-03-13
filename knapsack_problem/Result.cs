using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Knapsack
{
    class Result
    {
        public readonly List<int> itemNumbers = [];
        private readonly int totalValue;
        private readonly int totalWeight;

        public Result(int v, int w)
        {
            totalValue = v;
            totalWeight = w;
        }

        public void AddItemNumber(int number)
        {
            itemNumbers.Add(number);
        }

        public override string ToString()
        {
            string itemString = string.Join(" ", itemNumbers);
            itemString = string.Join(" ", "Items:", itemString);
            string valueString = $"Total Value = {totalValue}";
            string weightString = $"Total Weight = {totalWeight}";
            return string.Join(Environment.NewLine, itemString, valueString, weightString);
        }
    }
}
