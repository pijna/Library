using Library.Business;
using Library.Business.Users;
using Library.UI.UI;
using System;

namespace Library.UI
{
    public class EmployeeMenu : IMenu<IEmployee>
    {
        private readonly IItemActions<IBook> _bookActions;

        public EmployeeMenu(IItemActions<IBook> bookActions)
        {
            _bookActions = bookActions;
        }
        public void GetMenu()
        {
            Console.Clear();
            Console.WriteLine("Menu\n");
            Console.WriteLine("1. Add new book");
            Console.WriteLine("2. Delete book");
            Console.WriteLine("3. Print book info");
            Console.WriteLine("4. Print all book info");
            Console.WriteLine("5. Exit");

            switch (Console.ReadLine())
            {
                case "1":
                    _bookActions.AddNewItem();
                    break;
                case "2":
                    _bookActions.RemoveItem();
                    break;
                case "3":
                    _bookActions.PrintItemInfo();
                    Continue();
                    break;
                case "4":
                    _bookActions.PrintAllItemsInfo();
                    Continue();
                    break;
                case "5":
                    break;
                default:
                    break;
            }
        }

        public void Continue()
        {
            Console.WriteLine("1. Continue?");
            Console.WriteLine("2. Exit");

            switch (Console.ReadLine())
            {
                case "1":
                    GetMenu();
                    break;
                case "2":
                    break;
                default:
                    break;
            }
        }
    }
}
