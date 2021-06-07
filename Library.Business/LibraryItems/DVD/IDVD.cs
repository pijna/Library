using System;
using System.Collections.Generic;
using System.Text;

namespace Library.Business
{
    public interface IDVD : ILibraryItem, ITaken
    {
        List<string> Actors { get; set; }
    }
}
