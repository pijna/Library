using System;
using System.Collections.Generic;
using System.Text;

namespace Library.Business.Users.Employees
{
    public interface ILibraryItemFunctions<LibraryItem>
    {
        void AddItem(LibraryItem libraryItem);
        LibraryItem GetItem(string title);
        void RemoveItem(string title);
        void PrintItemInfo(string title);
        void PrintAllItemInfo();
    }
}
