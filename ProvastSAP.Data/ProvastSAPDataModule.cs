using Autofac;
using ProvastSAP.Data.Infrastructure;
using ProvastSAP.Data.Repositories;
using ProvastSAP.Data.Repositories.EntityRepos;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProvastSAP.Data
{
    public class ProvastSAPDataModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            base.Load(builder);

            builder.RegisterGeneric(typeof(BaseProvastSAPRepository<,>))
               .As(typeof(IBaseProvastSAPRepository<,>))
               .InstancePerLifetimeScope();

            builder.RegisterGeneric(typeof(BaseLogProvastSAPRepository<,,>))
               .As(typeof(IBaseLogProvastSAPRepository<,,>))
               .InstancePerLifetimeScope();

            builder.RegisterType<ProvastSAPUnitOfWork>()
               .As<IProvastSAPUnitOfWork>()
               .InstancePerLifetimeScope();

            builder.RegisterType<FacilityRepository>();
            builder.RegisterType<FlatTypeRepository>();
            builder.RegisterType<FloorRepository>();
            builder.RegisterType<SiteRepository>();
            builder.RegisterType<SiteTypeRepository>();
        }
    }
}
