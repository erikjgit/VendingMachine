using System;
using System.Collections.Generic;
using System.Text;

namespace VendingMachine
{
    public abstract class Product
    {
        public abstract string Use();
        public abstract string Examine();

        public abstract int GetPrice();
    }
}
