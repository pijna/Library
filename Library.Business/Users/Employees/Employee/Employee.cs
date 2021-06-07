using System;
using System.Collections.Generic;
using System.Text;

namespace Library.Business.Users.Employees.Employee
{
    public class Employee : IEmployee
    {
        IEmployeeFunctions _employeeFunctions;
        public string Name { get; set; }
        public string LastName { get; set; }

        public Employee(IEmployeeFunctions employeeFunctions)
        {
            _employeeFunctions = employeeFunctions;
        }

        public void AddBook(IBook book)
        {
            _employeeFunctions.AddBook(book);
        }

        public void RemoveBook(string title)
        {
            _employeeFunctions.RemoveBook(title);
        }

        public void AddAudioBook(IAudioBook audioBook)
        {
            _employeeFunctions.AddAudioBook(audioBook);
        }
        public void RemoveAudioBook(string title)
        {
            _employeeFunctions.RemoveAudioBook(title);
        }

        public void AddDvd(IDVD dvd)
        {
            _employeeFunctions.AddDvd(dvd);
        }

        public void RemoveDvd(string title)
        {
            _employeeFunctions.RemoveDvd(title);
        }

        public void PrintBookInfo(string title)
        {
            _employeeFunctions.PrintBookInfo(title);
        }

        public void PrintAllBookInfo()
        {
            _employeeFunctions.PrintAllBookInfo();
        }
    }

}
