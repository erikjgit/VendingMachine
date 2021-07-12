using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using VendingMachine;

namespace VendingMachine.Tests
{
    public class VendingMachineTests
    {
        [Fact]
        public void ShowAllTest()
        {
            string expectedWater = "Bottle of water. Price: 10 kr.";
            string expectedSoda = "Can of soda. Price: 15 kr.";
            string expectedChocolate = "Bar of chocolate. Price: 20 kr.";
            string expectedSandwich = "A sandwich with cheese. Price: 25 kr.";
            VendingMachine testVendingMachine = new VendingMachine();

            string[] inventory = testVendingMachine.ShowAll();

            Assert.Equal(expectedWater, inventory[0]);
            Assert.Equal(expectedSoda, inventory[1]);
            Assert.Equal(expectedChocolate, inventory[2]);
            Assert.Equal(expectedSandwich, inventory[3]);
        }
        [Fact]
        public void PurchaseTest()
        {
            Product testProduct;
            VendingMachine testVendingMachine = new VendingMachine();

            testProduct = testVendingMachine.Purchase(2);

            Assert.IsType<Soda>(testProduct);
        }
    }
}
