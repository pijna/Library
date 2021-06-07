using System;
using System.Collections.Generic;
using System.Text;

namespace Library.Business.Users.Customer
{
    public interface ICustomer : IPerson
    {
        int ItemsQuantityCounter { get; set; }
        void TakeItem();
        void ReturnItem();
    }
}
