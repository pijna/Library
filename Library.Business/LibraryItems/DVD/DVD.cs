using Library.Business.Users.Customer;
using System;
using System.Collections.Generic;
using System.Text;

namespace Library.Business
{
    public class DVD : IDVD
    {
        public DateTime BorrowDate { get; set; }
        public DateTime ReturnDate { get; set; }
        public List<string> Actors { get; set; }
        public string Language { get; set; }
        public string Title { get; set; }
        public string Category { get; set; }
        public bool Taken { get; set; }

    }
}
