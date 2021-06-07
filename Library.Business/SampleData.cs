using System;
using System.Collections.Generic;
using System.Text;

namespace Library.Business
{
    public class SampleData : ISampleData
    {
        private readonly Book _book;
        List<Book> books = new List<Book>();
        public SampleData(Book book)
        {
            _book = book;
        }

        public List<Book> AddSampleBooksData()
        {
            _book.Title = "SampleBook";
            _book.ISBN = "SampleIsbn";
            _book.Language = "SampleLanguage";
            _book.Pages = "SamplePages";
            _book.PublicationYear = "SampleYear";
            _book.Category = "SampleCategory";

            books.Add(_book);
            return books;
        }
    }
}
