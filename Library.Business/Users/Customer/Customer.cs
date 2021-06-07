using Library.Business.Users;
using Library.Business.Users.Customer;
using System;

namespace Library.Business
{
    public class Customer : ICustomer

    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public int ItemsQuantityCounter { get; set; } = 0;

        public void TakeItem()
        {
            throw new NotImplementedException();
        }

        public void ReturnItem()
        {
            throw new NotImplementedException();
        }

    }
}