﻿using OryxDomainServices;
using ProvastSAP.Security.Entities;
using ProvastSAP.Security.Infrastructure;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProvastSAP.Security.Services
{
    public class UserService : BaseSecurityService<User>
    {
        public UserService(ILogRepository<User, Guid> repository, ISecurityUnitOfWork unitOfWork) : base(repository, unitOfWork)
        {
        }

        public override void Update(User entity)
        {

        }
    }
}
