using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cents_To_Change
{
    //Please write a method to take cents as a parameter and return * an equal amount in dollars and coins using the minimum number of * coins possible. 
    //For example: 164 cents = 1 dollar, 2 quarters, 1 dime * and 4 cents. Return null if the parameter is negative
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the cents");
            int cents = Convert.ToInt32(Console.ReadLine());
            Change answer = new Change();
            answer = getChange(cents);
            Console.WriteLine("Change is {0} dollars and {1} quarters and {2} dimes and {3} nickels and {4} pennies",answer.dollars,answer.quarters,answer.dimes,answer.nickels,answer.pennies);
            Console.Read();
        }

        private static Change getChange(int cents)
        {
            Change answer = new Change();
            int remCents = 0;
            answer.dollars = cents / 100;
            remCents = cents - (answer.dollars * 100);
            answer.quarters = remCents / 25;
            remCents = remCents - (answer.quarters * 25);
            answer.dimes = remCents / 10;
            remCents = remCents - (answer.dimes * 10);
            answer.nickels = remCents / 5;
            answer.pennies = remCents - (answer.nickels * 5);
            return answer;
        }
    }
    public class Change
    {
        public int dollars { get; set; }
        public int quarters { get; set; }
        public int dimes { get; set; }
        public int nickels { get; set; }
        public int pennies { get; set; }
    }
}
