using OryxDomainServices;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProvastSAP.Data.Infrastructure
{
    public class ProvastSAPUnitOfWork : IProvastSAPUnitOfWork
    {
        private readonly IDbFactory dbFactory;
        private ProvastSAPContext dbContext;

        public ProvastSAPUnitOfWork(IDbFactory dbFactory)
        {
            this.dbFactory = dbFactory;
        }

        public ProvastSAPContext DbContext
        {

            get { return dbContext ?? (dbContext = dbFactory.Init()); }
        }

        public void Commit()
        {
            DbContext.Commit();
        }
    }

    public interface IProvastSAPUnitOfWork : IUnitOfWork
    {

    }
}
