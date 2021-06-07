namespace Library.Business
{
    public interface ILibraryItem
    {
        string Language { get; set; }
        string Title { get; set; }
        string Category { get; set; }
    }
}