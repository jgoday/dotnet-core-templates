using System;
using System.Linq;

namespace Sample
{
    class Program
    {
        static void Main(string[] args)
        {
            var contextFactory = new SampleContextFactory();
            using (var ctx = contextFactory.Create())
            {
                Console.WriteLine($"persons: {ctx.Persons.Count()}");
            }
        }
    }
}