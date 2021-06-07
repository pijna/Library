using Library.Business.Users.Customer;
using System;
using System.Collections.Generic;
using System.Text;

namespace Library.Business
{
    public class Book : IBook
    {
        public DateTime BorrowDate { get; set; }
        public DateTime ReturnDate { get; set; }
        public string Language { get; set; }
        public string ISBN { get; set; }
        public string PublicationYear { get; set; }
        public string Pages { get; set; }
        public string Title { get; set; }
        public string Category { get; set; }
        public bool Taken { get; set; } = false;

    }
}
