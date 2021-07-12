using System;
using System.Collections.Generic;
using System.Text;

namespace VendingMachine
{
    class Chocolate : Product
    {
        private int price = 20;
        public override string Examine()
        {
            return ("Bar of chocolate. Price: 20 kr.");
        }

        public override string Use()
        {
            return ("You eat the chocolate.");
        }
        public override int GetPrice()
        {
            return price;
        }
    }
}
