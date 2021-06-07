using System;
using System.Collections.Generic;
using System.Text;

namespace Library.Business.Users.Employees
{
    public class EmployeeFunctions : IEmployeeFunctions
    {
        ILibraryItemFunctions<IBook> _addOrRemoveBooks;
        ILibraryItemFunctions<IAudioBook> _addOrRemoveAudioBooks;
        ILibraryItemFunctions<IDVD> _addOrRemoveDvds;

        public EmployeeFunctions(ILibraryItemFunctions<IBook> addOrRemoveBooks, ILibraryItemFunctions<IAudioBook> addOrRemoveAudioBooks, ILibraryItemFunctions<IDVD> addOrRemoveDvds)
        {
            _addOrRemoveBooks = addOrRemoveBooks;
            _addOrRemoveAudioBooks = addOrRemoveAudioBooks;
            _addOrRemoveDvds = addOrRemoveDvds;
        }

        public void AddBook(IBook book)
        {
            _addOrRemoveBooks.AddItem(book);
        }

        public void RemoveBook(string title)
        {
            _addOrRemoveBooks.RemoveItem(title);
        }

        public void AddAudioBook(IAudioBook audioBook)
        {
            _addOrRemoveAudioBooks.AddItem(audioBook);
        }

        public void RemoveAudioBook(string title)
        {
            _addOrRemoveAudioBooks.RemoveItem(title);
        }

        public void AddDvd(IDVD dvd)
        {
            _addOrRemoveDvds.AddItem(dvd);
        }

        public void RemoveDvd(string title)
        {
            _addOrRemoveDvds.RemoveItem(title);
        }

        public void PrintBookInfo(string title)
        {
            _addOrRemoveBooks.PrintItemInfo(title);
        }

        public void PrintAllBookInfo()
        {
            _addOrRemoveBooks.PrintAllItemInfo();
        }
    }
}
