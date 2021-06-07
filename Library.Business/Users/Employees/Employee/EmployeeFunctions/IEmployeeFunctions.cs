namespace Library.Business.Users.Employees
{
    public interface IEmployeeFunctions
    {
        void AddBook(IBook book);
        void RemoveBook(string title);
        void PrintBookInfo(string title);
        void PrintAllBookInfo();
        void AddAudioBook(IAudioBook audioBook);
        void RemoveAudioBook(string title);
        void AddDvd(IDVD dvd);
        void RemoveDvd(string title);
    }
}