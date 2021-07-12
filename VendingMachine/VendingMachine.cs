using System;
using System.Collections.Generic;
using System.Text;

namespace VendingMachine
{
    public interface IVending
    {
        public Product Purchase(int selection);
        public string[] ShowAll();
        public void InsertMoney(int deposit);
        public Cash EndTransaction();
        
    }
    public class VendingMachine : IVending
    {
        private int balance;
        private Dictionary<int, Func<Product>> inventory;
        public VendingMachine()
        {
            inventory = new Dictionary<int, Func<Product>>();
            inventory.Add(1, () => new Water());
            inventory.Add(2, () => new Soda());
            inventory.Add(3, () => new Chocolate());
            inventory.Add(4, () => new Sandwich());
        }
        public Product Purchase(int selection)
        {
            Product result = inventory[selection]();
            balance -= result.GetPrice();
            return result;
        }
        public string[] ShowAll()
        {
            string[] result = new string[4];//inventory.Length];
            for(int i = 0; i<4; i++)
            {
                result[i] = inventory[i+1]().Examine();
            }
            return (result);
        }
        public void InsertMoney(int deposit)
        {
            balance += deposit;
        }
        public void InsertMoney(Cash deposit)
        {
            balance += deposit.ToInt();
        }
        public Cash EndTransaction()
        {
            Cash result = (new Cash(balance));
            balance = 0;
            return result;
        }
        public int GetBalance()
        {
            return balance;
        }
    }
}
