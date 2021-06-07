using Library.Business.Users.Customer;
using System;
using System.Collections.Generic;
using System.Text;

namespace Library.Business
{
    public class AudioBook : IAudioBook
    {
        public int LengthInMinutes { get; set; }
        public DateTime BorrowDate { get; set; }
        public DateTime ReturnDate { get; set; }
        public string Language { get; set; }
        public string Title { get; set; }
        public string Category { get; set; }

    }
}
