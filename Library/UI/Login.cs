using Library.Business.Users;
using Library.Business.Users.Customer;
using System;

namespace Library.UI
{
    public class Login : ILogin
    {
        private readonly IMenu<ICustomer> _customerMenu;
        private readonly IMenu<IEmployee> _employeeMenu;
        public Login(IMenu<ICustomer> customerMenu, IMenu<IEmployee> employeeMenu)
        {
            _customerMenu = customerMenu;
            _employeeMenu = employeeMenu;
        }
        public void LoginToLibrary()
        {
            Console.Clear();
            Console.WriteLine("Login\n");

            Console.WriteLine("1. Customer");
            Console.WriteLine("2. Employee");
            Console.WriteLine("3. Exit");

            switch (Console.ReadLine())
            {
                case "1":
                    _customerMenu.GetMenu();
                    break;
                case "2":
                    _employeeMenu.GetMenu();
                    break;
                case "3":
                    break;
                default:
                    break;
            }
        }
    }
}
