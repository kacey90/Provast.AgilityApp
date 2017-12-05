using OryxDomainServices;
using ProvastSAP.Data.Infrastructure;
using ProvastSAP.Entities;
using ProvastSAP.Security.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProvastSAP.Data.Repositories.EntityRepos
{
    public class SiteRepository : BaseLogProvastSAPRepository<Site, SiteLog, Guid>, ILogRepository<Site, Guid>
    {
        public SiteRepository(IDbFactory dbFactory, IUserResolverService userResolverService)
            : base(dbFactory, userResolverService)
        {

        }
    }
}
