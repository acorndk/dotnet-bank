using System;

namespace dotnet_bank.AccountChecker
{
    public sealed class Authenticator
    {
        public readonly string _username = "admin";

        public readonly string _password = "admin";

        public Authenticator() { }

        public bool Authenticate()
        {
            Console.Write("Username: ");
            var username = Console.ReadLine();

            Console.Write("Password: ");
            var password = Console.ReadLine();

            if (username == string.Empty || password == string.Empty)
            {
                Console.WriteLine("You cannot input null values.\n");
                return false;
            }

            if (username != _username || password != _password)
            {
                Console.WriteLine("Invalid Username and/or Password\n");
                return false;
            }

            return true;
        }
    }
}
