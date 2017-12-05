using OryxDomainServices;
using ProvastSAP.Data.Infrastructure;
using ProvastSAP.Entities;
using ProvastSAP.Security.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProvastSAP.Data.Repositories.EntityRepos
{
    public class FloorRepository : BaseLogProvastSAPRepository<Floor, FloorLog, Guid>, ILogRepository<Floor, Guid>
    {
        public FloorRepository(IDbFactory dbFactory, IUserResolverService userResolverService)
            : base(dbFactory, userResolverService)
        {

        }
    }
}
