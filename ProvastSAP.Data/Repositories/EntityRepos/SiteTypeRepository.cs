using OryxDomainServices;
using ProvastSAP.Data.Infrastructure;
using ProvastSAP.Entities;
using ProvastSAP.Security.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProvastSAP.Data.Repositories.EntityRepos
{
    public class SiteTypeRepository : BaseLogProvastSAPRepository<SiteType, SiteTypeLog, Guid>, ILogRepository<SiteType, Guid>
    {
        public SiteTypeRepository(IDbFactory dbFactory, IUserResolverService userResolverService)
            : base(dbFactory, userResolverService)
        {

        }
    }
}
