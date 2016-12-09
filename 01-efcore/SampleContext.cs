using System;
using Microsoft.EntityFrameworkCore;

namespace Sample
{
    public class SampleContext: DbContext
    {
        public DbSet<Person> Persons { get; set; }

        public SampleContext(DbContextOptions<SampleContext> options)
            : base(options)
        {}
    }
}