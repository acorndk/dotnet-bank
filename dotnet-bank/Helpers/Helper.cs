using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotnet_bank.Helpers
{
    public static class Helper
    {
        public static void DisplayTitle()
        {
            Console.WriteLine("****************** Dotnet Bank ******************");
            Console.WriteLine("::Login Page::");
        }

        public static void DisplayMainMenu()
        {
            Console.WriteLine("\n::Main Menu::");
            Console.WriteLine("1. Customers");
            Console.WriteLine("2. Accounts");
            Console.WriteLine("3. Funds Transfer");
            Console.WriteLine("4. Funds Transfer Statement");
            Console.WriteLine("5. Account Statement");
            Console.WriteLine("0. Exit");
        }

        public static void DisplayExit()
        {
            Console.WriteLine("Thank you for using dotnet-bank!");
            Console.ReadKey();
        }
    }
}
