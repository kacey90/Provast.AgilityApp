using OryxDomainServices;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProvastSAP.Security.Infrastructure
{
    public class SecurityUnitOfWork : ISecurityUnitOfWork
    {
        private readonly IDbFactory dbFactory;
        private SecurityContext dbContext;

        public SecurityUnitOfWork(IDbFactory dbFactory)
        {
            this.dbFactory = dbFactory;
        }

        public SecurityContext DbContext
        {

            get { return dbContext ?? (dbContext = dbFactory.Init()); }
        }

        public void Commit()
        {
            DbContext.Commit();
        }
    }

    public interface ISecurityUnitOfWork : IUnitOfWork
    {

    }
}
