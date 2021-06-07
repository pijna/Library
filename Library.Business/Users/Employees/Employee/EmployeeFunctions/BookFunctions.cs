using System;

namespace Library.Business.Users.Employees
{
    public class BookFunctions : ILibraryItemFunctions<IBook>
    {
        private readonly IInventoryProvider _inventoryProvider;
        private readonly IBook _book;

        public BookFunctions(IInventoryProvider inventoryProvider, IBook book)
        {
            _inventoryProvider = inventoryProvider;
            _book = book;
        }

        public void AddItem(IBook newBook)
        {
            _inventoryProvider.books.Add((Book)newBook);
            _inventoryProvider.SaveBookData(_inventoryProvider.books);
        }

        public IBook GetItem(string title)
        {
            Book tmp = _inventoryProvider.GetBook(title);
            return tmp;
        }

        public void RemoveItem(string title)
        {            
            _inventoryProvider.books.Remove((Book)GetItem(title));
            _inventoryProvider.SaveBookData(_inventoryProvider.books);
        }

        public void PrintItemInfo(string title)
        {
            Book tmp = _inventoryProvider.GetBook(title);
            if (tmp != null)
            {
                Console.WriteLine($"Book title: {tmp.Title} \nBook pages: {tmp.Pages}\n" +
                    $"Category: {tmp.Category}\nLanguage: {tmp.Language}\nPublication year:" +
                    $"{tmp.PublicationYear}\nISBN: {tmp.ISBN}\n");
            }
        }

        public void PrintAllItemInfo()
        {
            foreach (var book in _inventoryProvider.books)
            {
                PrintItemInfo(book.Title);
            }
        }

    }
}
