using System;
using System.Collections.Generic;
using System.Text;

namespace Library.Business
{
    public interface IAudioBook : ILibraryItem
    {
        int LengthInMinutes { get; set; }
    }
}
