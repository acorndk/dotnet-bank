using dotnet_bank.AccountChecker;
using dotnet_bank.Helpers;
using dotnet_bank.Menu;

namespace dotnet_bank
{
    public sealed class Program
    {
        public static void Main()
        {
            Helper.DisplayTitle();
            Execute();
            Helper.DisplayExit();
        }

        private static void Execute()
        {
            var authenticator = new Authenticator();
            var menuManager = new MenuManager();

            if (!authenticator.Authenticate())
            {
                Helper.DisplayExit();
            }

            menuManager.ExecuteMenu();
        }
    }
}
