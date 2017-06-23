using NbuBookLibrary.Contracts;

namespace NbuBookLibrary.Services
{
    public class FirstService : IFirstService
    {
        public string HelloServices()
        {
            return "Hello from first service!";
        }
    }
}