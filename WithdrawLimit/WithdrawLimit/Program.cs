using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WithdrawLimit
{
    internal class Program
    {
        // Main method
        private static void Main(string[] args)
        {
            // Create a new instance of the WithdrawLimit class
            WithdrawLimit withdrawLimit = new WithdrawLimit();

            // Call the Withdraw method with the amount to withdraw
            withdrawLimit.Withdraw(1000);
        }
    }
}
