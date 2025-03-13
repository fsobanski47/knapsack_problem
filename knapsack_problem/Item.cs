using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Knapsack
{
    class Item
    {
        public int Value { get; private set; }
        public int Weight { get; private set; }
        public bool Inserted { get; private set; }

        public int Number { get; private set; }
        
        public Item(int v, int w, int n)
        {
            Number = n;
            Value = v;
            Weight = w;
            Inserted = false;
        }

        public override string ToString()
        {
            return $"Item {Number}: Value = {Value}, Weight = {Weight}";
        }

        public void InsertItem()
        {
            Inserted = true;
        }
    }
}
