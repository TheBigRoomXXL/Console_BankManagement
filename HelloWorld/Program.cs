using System;

namespace Bank
{
    /*
     Include the following features:
        - View Account Holder Information - such as the account holder's name and account number.
        - View Checking account balance
        - View Savings account balance
        - Deposit funds into Checking
        - Deposit funds into Savings
        - Withdraw funds from Checking
        - Withdraw funds from Savings.
        - Exit
    */
    public class BankManagement
    {
        /// <summary>
        /// This is where the program starts
        /// </summary>
        public static void Main(string[] args)
        {
            Client JonhDoe = new("Jonh", "Doe", "jonh.doe@gmail.com");
            Account accountChecking = new (JonhDoe, "Checking", 200d);
            Account accountSaving = new (JonhDoe, "Saving", 1500d);

            UI.MainMenu(JonhDoe, accountChecking, accountSaving);
        }


    }
}