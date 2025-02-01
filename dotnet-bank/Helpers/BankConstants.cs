namespace dotnet_bank.Helpers
{
    public sealed class BankConstants
    {
        public const int DefaultChoice = -1;
        public const int ExitChoice = 0;

        //MainMenu
        public const int CustomersChoice = 1;
        public const int AccountsChoice = 2;
        public const int FundsTransferChoice = 3;
        public const int FundsStatementChoice = 4;
        public const int AccountStatementChoice = 5;

        //CustomersMenu
        public const int AddCustomerChoice = 1;
        public const int DeleteCustomerChoice = 2;
        public const int UpdateCustomerChoice = 3;
        public const int ViewCustomersChoice = 4;

        //AccountsMenu
        public const int AddAccountChoice = 1;
        public const int DeleteAccountChoice = 2;
        public const int UpdateAccountChoice = 3;
        public const int ViewAccountsChoice = 4;
    }
}
