using ProvastSAP.Data.Infrastructure;
using ProvastSAP.Data.Repositories.EntityRepos;
using ProvastSAP.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProvastSAP.Services.Services
{
    public class FlatTypeService : BaseProvastSAPService<FlatType>
    {
        private readonly FlatTypeRepository _repository;

        public FlatTypeService(FlatTypeRepository repository, IProvastSAPUnitOfWork uow)
            : base(repository, uow)
        {
            _repository = repository;
        }
    }
}
