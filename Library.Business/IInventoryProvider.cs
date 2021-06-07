using System.Collections.Generic;

namespace Library.Business
{
    public interface IInventoryProvider
    {
        List<AudioBook> audioBooks { get; set; }
        List<Book> books { get; set; }
        List<DVD> dvds { get; set; }
        void SaveBookData(List<Book> books);
        Book GetBook(string title);
    }
}