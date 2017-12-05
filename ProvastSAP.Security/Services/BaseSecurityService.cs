using OryxDomainServices;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProvastSAP.Security.Services
{
    public abstract class BaseSecurityService<TEntity> : BaseService<TEntity, Guid>
        where TEntity : class, IEntityBase<Guid>, new()
    {
        public BaseSecurityService(ILogRepository<TEntity, Guid> repository, IUnitOfWork unitOfWork)
            : base(repository, unitOfWork)
        {
        }

        public override void Add(TEntity entity)
        {
            if (entity.Id == Guid.Empty)
            {
                entity.Id = Guid.NewGuid();
            }

            base.Add(entity);
        }
    }
}
