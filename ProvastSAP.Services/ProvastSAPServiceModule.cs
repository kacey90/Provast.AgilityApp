using Autofac;
using OryxDomainServices;
using ProvastSAP.Data.Infrastructure;
using ProvastSAP.Data.Repositories;
using ProvastSAP.Security.Services;
using ProvastSAP.Services.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProvastSAP.Services
{
    public class ProvastSAPServiceModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterGeneric(typeof(BaseProvastSAPRepository<,>))
               .As(typeof(ILogRepository<,>))
               .InstancePerLifetimeScope();
            //  .InstancePerBackgroundJob();

            builder.RegisterGeneric(typeof(BaseLogProvastSAPRepository<,,>))
               .As(typeof(ILogRepository<,,>))
               .InstancePerLifetimeScope();
            //.InstancePerBackgroundJob();

            builder.RegisterType<ProvastSAPUnitOfWork>()
                .As<IProvastSAPUnitOfWork>()
                .InstancePerLifetimeScope();
            //.InstancePerBackgroundJob();

            builder.RegisterType<DbFactory>()
                .As<IDbFactory>()
                .InstancePerLifetimeScope();
            //.InstancePerBackgroundJob();

            builder.RegisterType<UserResolverService>()
                .As<IUserResolverService>()
                .InstancePerLifetimeScope();

            //builder.RegisterType<NotificationHub>()
            //    .As<IHubTrackingService>();

            //builder.RegisterType<PurchaseOrderService>();
            builder.RegisterType<FacilityService>();
            builder.RegisterType<FlatTypeService>();
            builder.RegisterType<FloorService>();
            builder.RegisterType<SiteService>();
            builder.RegisterType<SiteTypeService>();
        }
    }
}
