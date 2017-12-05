using OryxDomainServices;
using ProvastSAP.Data.Infrastructure;
using ProvastSAP.Entities;
using ProvastSAP.Security.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProvastSAP.Data.Repositories.EntityRepos
{
    public class FlatTypeRepository : BaseLogProvastSAPRepository<FlatType, FlatTypeLog, Guid>, ILogRepository<FlatType, Guid>
    {
        public FlatTypeRepository(IDbFactory dbFactory, IUserResolverService userResolverService)
            : base(dbFactory, userResolverService)
        {

        }
    }
}
