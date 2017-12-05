﻿using AutoMapper;
using OryxDomainServices;
using ProvastSAP.Security.Infrastructure;
using ProvastSAP.Security.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProvastSAP.Security.Repositories
{
    public class BaseSecurityLogRepository<TEntity, TLogEntity, TId> : BaseSecurityRepository<TEntity, TId>, ILogRepository<TEntity, TLogEntity, TId>
        where TEntity : class, IEntityBase<TId>, new() where TLogEntity : class, ILogEntityBase<TId>, new()
    {
        private MapperConfiguration config;

        public BaseSecurityLogRepository(IDbFactory dbFactory, IUserResolverService UserResolverService)
            : base(dbFactory, UserResolverService)
        {
            config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap(typeof(TEntity), typeof(TLogEntity)).ReverseMap();
            });


        }

        public override void Add(TEntity entity)
        {
            base.Add(entity);
            IMapper mapper = config.CreateMapper();
            var logEntity = mapper.Map<TLogEntity>(entity);
            logEntity.Id = entity.Id;
            dataContext.Add(logEntity);
        }

        public override void Update(TEntity entity)
        {
            base.Update(entity);
            IMapper mapper = config.CreateMapper();
            var logEntity = mapper.Map<TLogEntity>(entity);
            dataContext.Add(logEntity);
        }


    }
}
