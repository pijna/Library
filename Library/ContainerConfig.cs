using Autofac;
using Library.Business;
using Library.Business.Users;
using Library.Business.Users.Customer;
using Library.Business.Users.Employees;
using Library.Business.Users.Employees.Employee;
using Library.Business.Users.Employees.Employee.EmployeeFunctions;
using Library.Data;
using Library.UI.UI;
using Library.UI.UI.Book;

namespace Library.UI
{
    public static class ContainerConfig
    {
        public static IContainer Configure()
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<Application>();

            // Business layer
            builder.RegisterType<InventoryProvider>().As<IInventoryProvider>();
            builder.RegisterType<EmployeeFunctions>().As<IEmployeeFunctions>();
            builder.RegisterType<Employee>().As<IEmployee>();
            builder.RegisterType<Customer>().As<ICustomer>();
            builder.RegisterType<SampleData>().As<ISampleData>();
            builder.RegisterType<Book>().As<IBook>();
            builder.RegisterType<Book>().As<Book>();
            builder.RegisterType<BookFunctions>().As<ILibraryItemFunctions<IBook>>();
            builder.RegisterType<AudioBookFunctions>().As<ILibraryItemFunctions<IAudioBook>>();
            builder.RegisterType<DvdFunctions>().As<ILibraryItemFunctions<IDVD>>();
            builder.RegisterType<SaveLoadData<Book>>().As<ISaveLoadData<Book>>();


            // UI layer
            builder.RegisterType<Start>().As<IStart>();
            builder.RegisterType<Login>().As<ILogin>();
            builder.RegisterType<BookActions>().As<IItemActions<IBook>>();
            builder.RegisterType<EmployeeMenu>().As<IMenu<IEmployee>>();
            builder.RegisterType<CustomerMenu>().As<IMenu<ICustomer>>();

            return builder.Build();
        }
    }
}
