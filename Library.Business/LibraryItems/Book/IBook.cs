using System;
using System.Collections.Generic;
using System.Text;

namespace Library.Business
{
    public interface IBook : ILibraryItem, ITaken
    {
        string ISBN { get; set; }
        string PublicationYear { get; set; }
        string Pages { get; set; }
    }
}
