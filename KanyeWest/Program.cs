using System;
using System.Net.Http;
using Newtonsoft.Json.Linq;

namespace KanyeWest
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 5; i++)
            {
                var swansonQuote = GetQuote.SwansonQuote();

                var kanyeQuote = GetQuote.SwansonQuote();

                Console.WriteLine($"Kanye says: {kanyeQuote}");

                Console.WriteLine($"Ron says: {swansonQuote}");
            }
        }
    }
}
