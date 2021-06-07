using Library.Business.Users.Employees;
using Library.Data;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Library.Business
{
    public class InventoryProvider : IInventoryProvider
    {
        private readonly ISaveLoadData<Book> _saveLoadBookData;
        private readonly ISampleData _sampleData;
        public List<Book> books { get; set; }
        public List<AudioBook> audioBooks { get; set; }
        public List<DVD> dvds { get; set; }

        public InventoryProvider(ISaveLoadData<Book> saveLoadBookData, ISampleData sampleData)
        {
            _saveLoadBookData = saveLoadBookData;
            _sampleData = sampleData;

            try
            {
                books = _saveLoadBookData.LoadBookDataFromJson();
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine("Error info: " + e.Message);
                books = _sampleData.AddSampleBooksData();
                _saveLoadBookData.SaveBookDataToJson(books);
            }
        }

        public void SaveBookData(List<Book> books)
        {
            _saveLoadBookData.SaveBookDataToJson(books);
        }

        public Book GetBook(string title)
        {
            Book booktmp = books.Find(x => x.Title == title);
            if (booktmp != null)
            {
                return booktmp;
            }
            else
            {
                Console.WriteLine($"Sorry, {title} doesnt exist.");
                return null;
            }
        }
    }
}
