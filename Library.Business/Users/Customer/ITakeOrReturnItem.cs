using System;
using System.Collections.Generic;
using System.Text;

namespace Library.Business.Users.Customer
{
    public interface ITakeOrReturnItem<LibraryItem>
    {
        void TakeItem(LibraryItem item);
        void ReturnItem(LibraryItem libraryItem);
    }
}
