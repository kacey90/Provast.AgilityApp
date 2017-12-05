using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProvastSAP.Data
{
    public class ProvastSAPContext : DbContext
    {
        public ProvastSAPContext(DbContextOptions<ProvastSAPContext> options)
        : base(options)
        {
            Database.EnsureCreated();
        }

        #region Entities
        #endregion

        public virtual void Commit()
        {
            base.SaveChanges();
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // make sure the connection string makes sense for your machine
            optionsBuilder.UseSqlServer(@"Server=(local);Database=AgilityDB;Trusted_Connection=True;MultipleActiveResultSets=true;");
        }
    }
}
