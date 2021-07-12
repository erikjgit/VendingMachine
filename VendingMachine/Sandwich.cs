using System;
using System.Collections.Generic;
using System.Text;

namespace VendingMachine
{
    public class Sandwich : Product
    {
        private int price = 25;
        public override string Examine()
        {
            return ("A sandwich with cheese. Price: 25 kr.");
        }

        public override string Use()
        {
            return ("You eat the sandwich.");
        }
        public override int GetPrice()
        {
            return price;
        }
    }
}
