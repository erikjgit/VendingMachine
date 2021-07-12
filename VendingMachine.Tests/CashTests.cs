using System;
using Xunit;
using VendingMachine;

namespace VendingMachine.Tests
{
    public class CashTests
    {
        [Fact]
        public void ConstructorTest()
        {
            int thousands = 1;
            int fivehundreds = 1;
            int hundreds = 1;
            int fifties = 1;
            int twenties = 1;
            int tens = 1;
            int fives = 1;
            int ones = 1;
            int value = 1686;

            Cash testCash = new Cash(thousands, fivehundreds, hundreds, fifties, twenties, tens, fives, ones);

            Assert.Equal(value, testCash.ToInt());
        }
    }
}
