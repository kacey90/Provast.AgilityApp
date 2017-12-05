using ProvastSAP.Data.Infrastructure;
using ProvastSAP.Data.Repositories.EntityRepos;
using ProvastSAP.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProvastSAP.Services.Services
{
    public class FloorService : BaseProvastSAPService<Floor>
    {
        private readonly FloorRepository _repository;

        public FloorService(FloorRepository repository, IProvastSAPUnitOfWork uow)
            : base(repository, uow)
        {
            _repository = repository;
        }
    }
}
