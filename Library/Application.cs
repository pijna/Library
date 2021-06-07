namespace Library.UI
{
    public class Application
    {
        private readonly IStart _start;

        public Application(IStart start)
        {
            _start = start;
        }

        public void Run()
        {
            _start.StartProgram();
        }
    }
}
