using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.Extensions.Configuration;
using MySQL.Data.EntityFrameworkCore.Extensions;

namespace Sample
{
    public class SampleContextFactory: IDbContextFactory<SampleContext>
    {
        public IConfigurationRoot Configuration { get; set; }

        public SampleContextFactory()
        {
             var builder = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
 
            Configuration = builder.Build();
        }

        public SampleContext Create(DbContextFactoryOptions options = null)
        {
            var connectionStr = Configuration.GetConnectionString("DataAccessMySqlProvider");
            var builder = new DbContextOptionsBuilder<SampleContext>();
            builder.UseMySQL(connectionStr);

            return new SampleContext(builder.Options);
        }
    }
}