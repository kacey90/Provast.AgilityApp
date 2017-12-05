using ProvastSAP.Data.Infrastructure;
using ProvastSAP.Data.Repositories;
using ProvastSAP.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProvastSAP.Services.Services
{
    public class FacilityService : BaseProvastSAPService<Facility>
    {
        private readonly FacilityRepository _facilityRepo;

        public FacilityService(FacilityRepository repository, IProvastSAPUnitOfWork uow)
            : base(repository, uow)
        {
            _facilityRepo = repository;
        }
    }
}
