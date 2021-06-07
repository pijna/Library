using Library.Business;
using Library.Business.Users;
using System;

namespace Library.UI.UI.Book
{
    public class BookActions : IItemActions<IBook>
    {
        private readonly IEmployee _employee;
        private readonly IBook _book;
        public BookActions(IEmployee employee, IBook book)
        {
            _employee = employee;
            _book = book;
        }
        public void AddNewItem()
        {
            Console.Clear();
            Console.WriteLine("Enter book info\n");
            Console.WriteLine("Enter pages");
            _book.Pages = Console.ReadLine();
            Console.WriteLine("Enter title");
            _book.Title = Console.ReadLine();
            Console.WriteLine("Enter category");
            _book.Category = Console.ReadLine();
            Console.WriteLine("Enter language");
            _book.Language = Console.ReadLine();
            Console.WriteLine("Enter publication year");
            _book.PublicationYear = Console.ReadLine();
            Console.WriteLine("Enter isbn");
            _book.ISBN = Console.ReadLine();

            _employee.AddBook(_book);

            Console.WriteLine($"\nBook {_book.Title} added");
        }

        public void RemoveItem()
        {
            Console.Clear();
            Console.WriteLine("Enter book title");
            string title = Console.ReadLine();
            _employee.RemoveBook(title);
        }

        public void PrintItemInfo()
        {
            Console.Clear();
            Console.WriteLine("Enter book title");
            string title = Console.ReadLine();
            _employee.PrintBookInfo(title);
        }

        public void PrintAllItemsInfo()
        {
            Console.Clear();
            _employee.PrintAllBookInfo();
        }
    }
}
