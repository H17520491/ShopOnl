using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace shopOnl.Data.EF
{
    public class shopOnlDBContextFactory : IDesignTimeDbContextFactory<shopOnlDBcontext>
    {
        public shopOnlDBcontext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var connectionString = configuration.GetConnectionString("shopOnlManagementDb");

            var optionsBuilder = new DbContextOptionsBuilder<shopOnlDBcontext>();
            optionsBuilder.UseSqlServer(connectionString);

            return new shopOnlDBcontext(optionsBuilder.Options);
        }
    }
}
