using System.Collections.Generic;

namespace Library.Data
{
    public interface ISaveLoadData<LibraryItem>
    {
        List<LibraryItem> books { get; set; }
        List<LibraryItem> audioBooks { get; set; }
        List<LibraryItem> dvds { get; set; }
        List<LibraryItem> LoadBookDataFromJson();
        void SaveBookDataToJson(List<LibraryItem> books);
    }
}