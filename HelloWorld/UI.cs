using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    internal class UI
    {
        static public void MainMenu(Client client, Account accountChecking, Account accountSaving)
        {
            DiplayMenu();

            string? input = Console.ReadLine();

            switch (input)
            {
                case "I":
                    client.DiplayInfo();
                    break;

                case "CB":
                    accountChecking.DiplayBalance();
                    break;

                case "CD":
                    accountChecking.DepositsFunds();
                    break;

                case "CW":
                    accountChecking.WithdrawFunds();
                    break;

                case "SB":
                    accountSaving.DiplayBalance();
                    break;

                case "SD":
                    accountSaving.DepositsFunds();
                    break;

                case "SW":
                    accountSaving.WithdrawFunds();
                    break;

                case "X":
                    System.Environment.Exit(1);
                    break;

                default:
                    Console.WriteLine("Input not recognised");
                    break;
            }

            MainMenu(client, accountChecking, accountSaving);
        }

        static public void DiplayMenu()
        {
            Console.WriteLine("");
            Console.WriteLine("=======================================");
            Console.WriteLine("Please select an option below:");
            Console.WriteLine("[I] View Account Holder Information");
            Console.WriteLine("[CB] Checking - View Balance");
            Console.WriteLine("[CD] Checking - Deposit Funds");
            Console.WriteLine("[CW] Checking - Withdraw Funds");
            Console.WriteLine("[SB] Savings - View Balance");
            Console.WriteLine("[SD] Savings - Deposit Funds");
            Console.WriteLine("[SW] Savings - Withdraw Funds");
            Console.WriteLine("[X] Exit");
        }
    }
}
