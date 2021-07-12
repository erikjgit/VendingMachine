using System;
using System.Collections.Generic;
using System.Text;

namespace VendingMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] deposit;
            string selectionString;
            int selectionInt;
            string input;
            bool running = true;
            List<Product> purchasedProducts = new List<Product>();
            VendingMachine vendingMachine = new VendingMachine();
            Console.WriteLine("Welcome to the vending machine. Please make a deposit to start.");
            deposit = makeDeposit();
            vendingMachine.InsertMoney(new Cash(deposit[0], deposit[1], deposit[2], deposit[3], deposit[4], deposit[5], deposit[6], deposit[7]));
            while (running)
            {
                Console.WriteLine("\nChoose what you want to do by choosing a number. \n1 See all products. \n2 Choose a product to buy.\n3 Insert money.\n4 Use one of your products. \n5 End the transaction and recieve your change. ");
                selectionString = Console.ReadLine();
                switch (selectionString)
                {
                    case "1":
                        foreach(string s in vendingMachine.ShowAll())
                        {
                            Console.WriteLine(s);
                        }
                        Console.ReadKey();
                        break;
                    case "2":
                        Console.WriteLine("Enter the corresponding number to choose the product. \n1: Water 2: Soda 3: Chocolate 4: Sandwich");
                        input = Console.ReadLine();
                        while (!(Int32.TryParse(input, out selectionInt)))
                        {
                            Console.WriteLine("That was not an integer. Please Try again.");
                            input = Console.ReadLine();
                        }
                        if(selectionInt<5 && selectionInt > 0)
                        {
                            if(vendingMachine.GetBalance()< vendingMachine.Purchase(selectionInt).GetPrice())
                            {
                                Console.WriteLine("Not enough money.");
                                break;
                            }
                            purchasedProducts.Add(vendingMachine.Purchase(selectionInt));
                        }
                        else
                        {
                            Console.WriteLine("Invalid selection.");
                        }
                        Console.ReadKey();
                        break;
                    case "3":
                        deposit = makeDeposit();
                        vendingMachine.InsertMoney(new Cash(deposit[0], deposit[1], deposit[2], deposit[3], deposit[4], deposit[5], deposit[6], deposit[7]));
                        Console.ReadKey();
                        break;
                    case "4":
                        Console.WriteLine("You currently have: ");
                        foreach(Product p in purchasedProducts)
                        {
                            Console.WriteLine(p.Examine());
                        }
                        Console.ReadKey();
                        break;
                    case "5":
                        Console.WriteLine("You recieve " + vendingMachine.EndTransaction().ToInt() + " kr");
                        running = false;
                        Console.ReadKey();
                        break;
                    default:
                        Console.WriteLine("Invalid operation.");
                        Console.ReadKey();
                        break;
                }
            }
            while(purchasedProducts.Count > 0)
            {
                Console.WriteLine("You have the following products: ");
                for(int i=0; i<purchasedProducts.Count; i++)
                {
                    Console.WriteLine((i + 1) + ": " + purchasedProducts[i]);
                }
                Console.WriteLine("Enter the number of a product to use it. Enter 0 to exit");
                input = Console.ReadLine();
                while (!(Int32.TryParse(input, out selectionInt)))
                {
                    Console.WriteLine("That was not an integer. Please Try again.");
                    input = Console.ReadLine();
                }
                if(selectionInt == 0)
                {
                    break;
                }
                else if (selectionInt > 0 && selectionInt < 5)
                {
                    Console.WriteLine(purchasedProducts[selectionInt - 1].Use());
                    purchasedProducts.RemoveAt(selectionInt - 1);
                }
            }
        }

        static int[] makeDeposit()
        {
            string input;
            int[] result = new int[8];
            Console.Write("Enter number of 1000 kr bills: ");
            input = Console.ReadLine();
            while (!(Int32.TryParse(input, out result[0])))
            {
                Console.WriteLine("That was not an integer. Please Try again.");
                input = Console.ReadLine();
            }
            Console.Write("Enter number of 500 kr bills: ");
            input = Console.ReadLine();
            while (!(Int32.TryParse(input, out result[1])))
            {
                Console.WriteLine("That was not an integer. Please Try again.");
                input = Console.ReadLine();
            }
            Console.Write("Enter number of 100 kr bills: ");
            input = Console.ReadLine();
            while (!(Int32.TryParse(input, out result[2])))
            {
                Console.WriteLine("That was not an integer. Please Try again.");
                input = Console.ReadLine();
            }
            Console.Write("Enter number of 50 kr bills: ");
            input = Console.ReadLine();
            while (!(Int32.TryParse(input, out result[3])))
            {
                Console.WriteLine("That was not an integer. Please Try again.");
                input = Console.ReadLine();
            }
            Console.Write("Enter number of 20 kr bills: ");
            input = Console.ReadLine();
            while (!(Int32.TryParse(input, out result[4])))
            {
                Console.WriteLine("That was not an integer. Please Try again.");
                input = Console.ReadLine();
            }
            Console.Write("Enter number of 10 kr coins: ");
            input = Console.ReadLine();
            while (!(Int32.TryParse(input, out result[5])))
            {
                Console.WriteLine("That was not an integer. Please Try again.");
                input = Console.ReadLine();
            }
            Console.Write("Enter number of 5 kr coins: ");
            input = Console.ReadLine();
            while (!(Int32.TryParse(input, out result[6])))
            {
                Console.WriteLine("That was not an integer. Please Try again.");
                input = Console.ReadLine();
            }
            Console.Write("Enter number of 1 kr coins: ");
            input = Console.ReadLine();
            while (!(Int32.TryParse(input, out result[7])))
            {
                Console.WriteLine("That was not an integer. Please Try again.");
                input = Console.ReadLine();
            }
            return result;
        }
    }
}
