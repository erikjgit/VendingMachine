using System;
using System.Collections.Generic;
using System.Text;

namespace VendingMachine
{
    //A class to represent an amount of cash, counting the denominators separately
    public class Cash
    {
        int value, ones, fives, tens, twenties, fifties, hundreds, fivehundreds, thousands;
        //Method to get the value of a cash object as a int
        public int ToInt()
        {
            return (value);
        }

        //Constructor that takes an amount of money counted in different denominations 
        public Cash(int thousands, int fivehundreds, int hundreds, int fifties, int twenties, int tens, int fives, int ones)
        {
            this.thousands = thousands;
            this.fivehundreds = fivehundreds;
            this.hundreds = hundreds;
            this.fifties = fifties;
            this.twenties = twenties;
            this.tens = tens;
            this.fives = fives;
            this.ones = ones;
            value = 1000 * thousands + 500 * fivehundreds + 100 * hundreds + 50 * fifties + 20 * twenties + 10 * tens + 5 * fives + ones;
        }
        //Constructor to convert an amount of money stored as an int into a cash object
        public Cash(int input)
        {
            int i = input;
            value = input;
            while (i >= 1000)
            {
                thousands++;
                i -= 1000;
            }
            while (i >= 500)
            {
                fivehundreds++;
                i -= 500;
            }
            while (i >= 100)
            {
                hundreds++;
                i -= 100;
            }
            while (i >= 50)
            {
                fifties++;
                i -= 50;
            }
            while (i >= 20)
            {
               twenties++;
                i -= 20;
            }
            while (i >= 20)
            {
                twenties++;
                i -= 20;
            }
            while (i >= 10)
            {
                tens++;
                i -= 10;
            }
            while (i >= 5)
            {
                fives++;
                i -= 5;
            }
            while (i >= 1)
            {
                ones++;
                i -= 1;
            }

        }
    }
}
