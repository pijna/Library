using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Library.Data
{
    public class SaveLoadData<LibraryItem> : ISaveLoadData<LibraryItem>
    {
        public List<LibraryItem> books { get; set; }
        public List<LibraryItem> audioBooks { get; set; }
        public List<LibraryItem> dvds { get; set; }

        public void SaveBookDataToJson(List<LibraryItem> books)
        {
            string str = JsonConvert.SerializeObject(books, Formatting.Indented);
            File.WriteAllText(@"books.txt", str);
        }

        public List<LibraryItem> LoadBookDataFromJson()
        {
            string str = File.ReadAllText(@"books.txt");
            var books = JsonConvert.DeserializeObject<List<LibraryItem>>(str);
            return books;
        }
    }
}
