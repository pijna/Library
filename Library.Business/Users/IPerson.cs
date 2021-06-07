using System;
using System.Collections.Generic;
using System.Text;

namespace Library.Business.Users
{
    public interface IPerson
    {
        string Name { get; set; }
        string LastName { get; set; }
    }
}
