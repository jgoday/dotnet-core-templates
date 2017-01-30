using System;
using System.Linq;

namespace Sample
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var contextFactory = new SampleContextFactory();
            using (var ctx = contextFactory.Create())
            {
                Console.WriteLine($"persons: {ctx.Persons.Count()}");
            }
        }
    }
}