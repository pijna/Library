using System;
using System.Collections.Generic;
using System.Text;

namespace Library.Business.Users.Employees.Employee.EmployeeFunctions
{
    public class DvdFunctions : ILibraryItemFunctions<IDVD>
    {
        private readonly IInventoryProvider _inventoryProvider;

        public DvdFunctions(IInventoryProvider inventoryProvider)
        {
            _inventoryProvider = inventoryProvider;
        }

        public void AddItem(IDVD newDvd)
        {
           _inventoryProvider.dvds.Add((DVD)newDvd);
        }

        public IDVD GetItem(string title)
        {
            throw new NotImplementedException();
        }

        public void PrintAllItemInfo()
        {
            throw new NotImplementedException();
        }

        public void PrintItemInfo(string title)
        {
            throw new NotImplementedException();
        }

        public void RemoveItem(string title)
        {
            throw new NotImplementedException();
        }
    }
}
