using dotnet_bank.AccountChecker;
using dotnet_bank.Helpers;
using dotnet_bank.Menu;
using System;
using System.Runtime.InteropServices;

namespace dotnet_bank
{
    public sealed class Program
    {
        public static void Main(string[] args)
        {
            var authenticator = new Authenticator();
            var menuManager = new MenuManager();

            Helper.DisplayTitle();

            if (!authenticator.Authenticate())
            {
                Helper.DisplayExit();
            }



            Helper.DisplayExit();
        }
    }
}
