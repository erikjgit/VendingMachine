using System;
using System.Collections.Generic;
using System.Text;

namespace VendingMachine
{
    public class Water : Product
    {
        private int price = 10;
        public override string Examine()
        {
            return("Bottle of water. Price: 10 kr.");
        }

        public override string Use()
        {
            return ("You drink the water.");
        }
        public override int GetPrice()
        {
            return price;
        }
    }
}
