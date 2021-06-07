using Library.Business.Users.Customer;
using System;
using System.Collections.Generic;
using System.Text;

namespace Library.Business.Users.Employees
{
    public class Manager : IManager
    {
        public string Name { get; set; }
        public string LastName { get; set; }

        public void Hire(IEmployee employee)
        {
            throw new NotImplementedException();
        }
    }
}
