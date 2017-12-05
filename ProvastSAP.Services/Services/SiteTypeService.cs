using ProvastSAP.Data.Infrastructure;
using ProvastSAP.Data.Repositories.EntityRepos;
using ProvastSAP.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProvastSAP.Services.Services
{
    public class SiteTypeService : BaseProvastSAPService<SiteType>
    {
        private readonly SiteTypeRepository _repository;

        public SiteTypeService(SiteTypeRepository repository, IProvastSAPUnitOfWork uow)
            : base(repository, uow)
        {
            _repository = repository;
        }
    }
}
