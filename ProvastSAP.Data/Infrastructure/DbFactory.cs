
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using OryxDomainServices;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProvastSAP.Data.Infrastructure
{
    public class DbFactory : Disposable, IDbFactory
    {
        ProvastSAPContext dbContext;

        DbContextOptions<ProvastSAPContext> _options;
        IConfigurationRoot Configuration { get; set; }

        public DbFactory(DbContextOptions<ProvastSAPContext> options)
        {
            _options = options;
        }
        public ProvastSAPContext Init()
        {
            //var optionsBuilder = new DbContextOptionsBuilder<OryxMCIContext>();

            //string connString = "Server = localhost; Database = MCI; Trusted_Connection = true; MultipleActiveResultSets = true";
            ////Configuration["Data:DefaultConnection:OryxMCIConnectionString"];
            //optionsBuilder.UseSqlServer(connString);

            return dbContext ?? (dbContext = new ProvastSAPContext(_options));
        }

        protected override void DisposeCore()
        {
            if (dbContext != null)
                dbContext.Dispose();
        }
    }
}
