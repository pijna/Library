using System;
using System.Collections.Generic;
using System.Text;

namespace Library.Business.Users.Employees
{
    public class AudioBookFunctions : ILibraryItemFunctions<IAudioBook>
    {
        private readonly IInventoryProvider _inventoryProvider;

        public AudioBookFunctions(IInventoryProvider inventoryProvider)
        {
            _inventoryProvider = inventoryProvider;
        }

        public void AddItem(IAudioBook newAudioBook)
        {
            _inventoryProvider.audioBooks.Add((AudioBook)newAudioBook);
        }

        public IAudioBook GetItem(string title)
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
