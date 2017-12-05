using ProvastSAP.Data.Infrastructure;
using ProvastSAP.Data.Repositories.EntityRepos;
using ProvastSAP.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProvastSAP.Services.Services
{
    public class SiteService : BaseProvastSAPService<Site>
    {
        private readonly SiteRepository _repository;

        public SiteService(SiteRepository repository, IProvastSAPUnitOfWork uow)
            : base(repository, uow)
        {
            _repository = repository;
        }
    }
}
