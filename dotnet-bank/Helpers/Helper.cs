using dotnet_bank.Menu;
using System;

namespace dotnet_bank.Helpers
{
    public static class Helper
    {
        public static void DisplayTitle()
        {
            Console.WriteLine("****************** Dotnet Bank ******************");
            Console.WriteLine("::Login Page::");
        }

        public static void DisplayExit()
        {
            Console.WriteLine("Thank you for using dotnet-bank!");
            Console.ReadKey();
        }

        public static void DisplayMenu(MenuContext context)
        {
            switch (context)
            {
                case MenuContext.MainMenu:
                    DisplayMainMenu();
                    break;
                case MenuContext.Customers:
                    DisplayCustomersMenu();
                    break;
                case MenuContext.Accounts:
                    DisplayAccountsMenu();
                    break;
            }
        }

        private static void DisplayMainMenu()
        {
            Console.WriteLine("\n::Main Menu::");
            Console.WriteLine("1. Customers");
            Console.WriteLine("2. Accounts");
            Console.WriteLine("3. Funds Transfer");
            Console.WriteLine("4. Funds Transfer Statement");
            Console.WriteLine("5. Account Statement");
            Console.WriteLine("0. Exit");
        }
        
        private static void DisplayCustomersMenu()
        {
            Console.WriteLine("\n::Customers Menu::");
            Console.WriteLine("1. Add Customer");
            Console.WriteLine("2. Delete Customer");
            Console.WriteLine("3. Update Customer");
            Console.WriteLine("4. View Customers");
            Console.WriteLine("0. Back to Main Menu");
        }

        private static void DisplayAccountsMenu()
        {
            Console.WriteLine("\n::Accounts Menu::");
            Console.WriteLine("1. Add Account");
            Console.WriteLine("2. Delete Account");
            Console.WriteLine("3. Update Account");
            Console.WriteLine("4. View Accounts");
            Console.WriteLine("0. Back to Main Menu");
        }
    }
}
