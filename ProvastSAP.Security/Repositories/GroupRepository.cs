using OryxDomainServices;
using ProvastSAP.Security.Entities;
using ProvastSAP.Security.Infrastructure;
using ProvastSAP.Security.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProvastSAP.Security.Repositories
{
    public class GroupRepository : BaseSecurityRepository<Group, Guid>, ILogRepository<Group, Guid>
    {
        public GroupRepository(IDbFactory dbFactory, IUserResolverService UserResolverService) : base(dbFactory, UserResolverService)
        {
        }

    }
}
