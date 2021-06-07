using Autofac;
using Library.UI;

namespace Library
{
    class Program
    {
        static void Main(string[] args)
        {
            ContainerConfig.Configure().Resolve<Application>().Run();
        }
    }
}
