using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    internal class Account
    {
        public int id;
        public Client holder;
        public string type;
        public double balance;
        private static int accountCount = 0;

        public Account( Client holder, string type, double balance)
        {
            accountCount += 1;
            this.id = accountCount;
            this.holder = holder;
            this.type = type;
            this.balance = balance;
        }

        public void DiplayBalance()
        {
            Console.WriteLine("Balance of account #{0} :", this.id);
            Console.WriteLine("{0} Euro", this.balance);
        }

        public void DepositsFunds()
        {
            double funds = GetFundsFromInput("How much would you like to deposit?");
            if (funds > 0)
            {
                this.balance += funds;
                Console.WriteLine("Transaction: +{0}euros at {1} Current Balance: {2}euros", funds, DateTime.Now, this.balance);
            }
            else
            {
                DepositsFunds();
            }
            
           
        }
        public void WithdrawFunds()
        {
            double funds = GetFundsFromInput("How much would you like to withdraw?");
            if (funds > this.balance)
            {
                Console.WriteLine("Insufficient funds");
                WithdrawFunds();
            }
            else if (funds > 0)
            {
                this.balance -= funds;
                Console.WriteLine("Transaction: -{0}euros at {1} Current Balance: {2}euros", funds, DateTime.Now, this.balance);
            }
            else
            {
                WithdrawFunds();
            }
        }

        public static double GetFundsFromInput(string consoleMessage) 
        {
            Console.WriteLine(consoleMessage);
            string? input = Console.ReadLine();
            try
            {         
                double result = Convert.ToDouble(input);
                if (result > 0d)
                {                    
                    return result;
                }
                else
                {
                    Console.WriteLine("Please imput a value strictly superior to 0");
                    return -1d;
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Unable to convert '{0}' to a Double.", input);
                return -1d;
            }
            catch (OverflowException)
            {
                Console.WriteLine("'{0}' is outside the range of a Double.", input);
                return -1d;
            }
        }
    }
}
