using OryxDomainServices;
using ProvastSAP.Security.Infrastructure;
using ProvastSAP.Security.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProvastSAP.Security.Repositories
{
    public class ActionRepository : BaseSecurityRepository<Entities.Action, Guid>, ILogRepository<Entities.Action, Guid>
    {
        public ActionRepository(IDbFactory dbFactory, IUserResolverService UserResolverService) : base(dbFactory, UserResolverService)
        {
        }

    }
}
