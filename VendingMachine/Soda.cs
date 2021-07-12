using System;
using System.Collections.Generic;
using System.Text;

namespace VendingMachine
{
    public class Soda : Product 
    {
        private int price = 15;
        public override string Examine()
        {
            return ("Can of soda. Price: 15 kr.");
        }

        public override string Use()
        {
            return ("You drink the soda.");
        }
        public override int GetPrice()
        {
            return price;
        }
    }
}
