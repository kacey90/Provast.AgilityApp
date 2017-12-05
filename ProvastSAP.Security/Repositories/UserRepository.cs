using OryxDomainServices;
using ProvastSAP.Security.Entities;
using ProvastSAP.Security.Infrastructure;
using ProvastSAP.Security.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProvastSAP.Security.Repositories
{
    public class UserRepository : BaseSecurityRepository<User, Guid>, ILogRepository<User, Guid>
    {
        public UserRepository(IDbFactory dbFactory, IUserResolverService UserResolverService) : base(dbFactory, UserResolverService)
        {
        }

    }
}
