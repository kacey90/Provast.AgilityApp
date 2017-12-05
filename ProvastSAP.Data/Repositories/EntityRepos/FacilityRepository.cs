using OryxDomainServices;
using ProvastSAP.Data.Infrastructure;
using ProvastSAP.Entities;
using ProvastSAP.Security.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProvastSAP.Data.Repositories
{
    public class FacilityRepository : BaseLogProvastSAPRepository<Facility, FacilityLog, Guid>, ILogRepository<Facility, Guid>
    {
        public FacilityRepository(IDbFactory dbFactory, IUserResolverService userResolverService)
            : base(dbFactory, userResolverService)
        {

        }
    }
}
