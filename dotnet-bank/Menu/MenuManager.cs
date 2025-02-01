using dotnet_bank.Helpers;
using System;

namespace dotnet_bank.Menu
{
    public sealed class MenuManager
    {
        public int MenuChoice { get; set; }

        public MenuContext Context { get; set; }

        public MenuManager() 
        {
            MenuChoice = -1;
            Context = MenuContext.None;
        }

        public void ExecuteMenu()
        {
            var repeatMenu = true;

            do
            {
                Helper.DisplayMenu(MenuContext.MainMenu);

                if (IsMenuChoiceValid(MenuContext.MainMenu, GetMenuChoice()))
                {
                    ExecuteChoice();
                    repeatMenu = MenuChoice != BankConstants.ExitChoice;
                }
            }
            while (repeatMenu);
        }
        
        public int GetMenuChoice()
        {
            Console.Write("Enter choice: ");
            return int.Parse(Console.ReadLine());
        }

        public bool IsMenuChoiceValid(MenuContext context, int menuChoice)
        {
            if (context == MenuContext.MainMenu && menuChoice >= 0 && menuChoice <= 5)
            {
                MenuChoice = menuChoice;
                Context = context;
                return true;
            }
            else if (context == MenuContext.Customers && menuChoice >= 0 && menuChoice <= 4)
            {
                MenuChoice = menuChoice;
                return true;
            }
            else if (context == MenuContext.Accounts && menuChoice >= 0 && menuChoice <= 4)
            {
                MenuChoice = menuChoice;
                return true;
            }

            Console.WriteLine($"The Menu Context {context} does not contain menu choice {menuChoice}.");
            return false;
        }

        public void ExecuteChoice()
        {
            if (Context == MenuContext.MainMenu)
            {
                switch (MenuChoice)
                {
                    case BankConstants.CustomersChoice:
                        Context = MenuContext.Customers;
                        ExecuteChoice();
                        break;
                    case BankConstants.AccountsChoice:
                        Context = MenuContext.Accounts;
                        ExecuteChoice();
                        break;
                    case BankConstants.FundsTransferChoice:
                        //To-do
                        break;
                    case BankConstants.FundsStatementChoice:
                        //To-do
                        break;
                    case BankConstants.AccountStatementChoice:
                        //To-do
                        break;
                    case BankConstants.ExitChoice:
                        Console.WriteLine("\nExiting Application.");
                        break;
                }
            }
            else
            {
                ExecuteMainMenuChoice();
            }
        }

        private void ExecuteMainMenuChoice()
        {
            var repeatMenu = true;

            do
            {
                Helper.DisplayMenu(Context);

                if (IsMenuChoiceValid(Context, GetMenuChoice()))
                {
                    ExecuteInnerChoice();

                    if (MenuChoice == BankConstants.ExitChoice)
                    {
                        repeatMenu = false;
                        MenuChoice = BankConstants.DefaultChoice;
                    }
                }
            }
            while (repeatMenu);
        }

        private void ExecuteInnerChoice()
        {
            if (Context == MenuContext.Customers)
            {
                switch (MenuChoice)
                {
                    case BankConstants.AddCustomerChoice:
                        Console.WriteLine("Doing something.");
                        break;
                    case BankConstants.DeleteCustomerChoice:
                        //To-do
                        break;
                    case BankConstants.UpdateCustomerChoice:
                        //To-do
                        break;
                    case BankConstants.ViewCustomersChoice:
                        //To-do
                        break;
                    case BankConstants.ExitChoice:
                        Console.WriteLine("Exiting Customers Menu");
                        break;
                    default:
                        Console.WriteLine($"Menu choice {MenuChoice} in the customers menu does not exist.");
                        break;
                }
            }
            else if (Context == MenuContext.Accounts)
            {
                switch (MenuChoice)
                {
                    case BankConstants.AddAccountChoice:
                        //To-do
                        break;
                    case BankConstants.DeleteAccountChoice:
                        //To-do
                        break;
                    case BankConstants.UpdateAccountChoice:
                        //To-do
                        break;
                    case BankConstants.ViewAccountsChoice:
                        //To-do
                        break;
                    case BankConstants.ExitChoice:
                        Console.WriteLine("Exiting Accounts Menu");
                        break;
                    default:
                        Console.WriteLine($"Menu choice {MenuChoice} in the accounts menu does not exist.");
                        break;
                }
            }
        }
    }
}
