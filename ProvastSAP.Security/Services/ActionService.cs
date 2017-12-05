using OryxDomainServices;
using ProvastSAP.Security.Infrastructure;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProvastSAP.Security.Services
{
    public class ActionService : BaseSecurityService<Entities.Action>
    {
        public ActionService(ILogRepository<Entities.Action, Guid> repository, ISecurityUnitOfWork unitOfWork) : base(repository, unitOfWork)
        {
        }

        public override void Update(Entities.Action entity)
        {

        }
    }
}
