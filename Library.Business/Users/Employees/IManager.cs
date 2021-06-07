using Library.Business.Users.Customer;
using System;
using System.Collections.Generic;
using System.Text;

namespace Library.Business.Users
{
    public interface IManager : IPerson
    {
        void Hire(IEmployee employee);
    }
}
