using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotnet_bank.Menu
{
    public sealed class MenuManager
    {
        public int MenuChoice;

        public MenuContext Context { get; set; }

        public MenuManager() 
        {
            MenuChoice = -1;
            Context = MenuContext.None;
        }

        public void SetMenuChoice()
        {
            Console.Write("Enter choice");
            MenuChoice = int.Parse(Console.ReadLine());
        }

        public void ExecuteChoice(MenuContext context)
        {
            switch (context) 
            {
                case MenuContext.MainMenu:
                    ExecuteMainMenuChoice();
                    break;
                default:
                    Console.WriteLine("Menu context does not exist.");
                    break;
            }
        }

        private void ExecuteMainMenuChoice()
        {
            switch (MenuChoice)
            {
                case 1:
                    break;
                case 2:
                    break;
                case 3:
                    break;
                case 4:
                    break;
                case 5:
                    break;
                case 0:
                    break;
                default:
                    Console.WriteLine($"Menu choice {MenuChoice} in the main menu does not exist.");
                    break;
            }
        }
    }
}
