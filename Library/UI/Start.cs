using System;

namespace Library.UI
{
    public class Start : IStart
    {
        private readonly ILogin _login;
        public Start(ILogin login)
        {
            _login = login;
        }
        public void StartProgram()
        {
            Console.Clear();
            Console.WriteLine("Library\n");

            Console.WriteLine("1. Login");
            Console.WriteLine("2. Exit");

            switch (Console.ReadLine())
            {
                case "1":
                    _login.LoginToLibrary();
                    break;
                case "2":
                    break;
                default:
                    break;
            }
        }
    }
}
