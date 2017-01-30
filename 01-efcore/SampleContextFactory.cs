using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.Extensions.Configuration;
// using MySQL.Data.Entity.Extensions;

namespace Sample
{
    public class SampleContextFactory: IDbContextFactory<SampleContext>
    {
        public IConfigurationRoot Configuration { get; set; }

        public SampleContextFactory()
        {
             var builder = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json", optional: false)
                .AddUserSecrets<SampleContextFactory>();

            Configuration = builder.Build();
        }

        public SampleContext Create(DbContextFactoryOptions options = null)
        {
            var connectionStr = Configuration.GetConnectionString("DataAccessProvider");
            var builder = new DbContextOptionsBuilder<SampleContext>();
            /**
             * MySQL
            builder.UseMySQL(connectionStr);
            */
            builder.UseNpgsql(connectionStr);

            return new SampleContext(builder.Options);
        }
    }
}