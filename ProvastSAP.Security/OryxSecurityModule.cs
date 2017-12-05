using Autofac;
using OryxDomainServices;
using ProvastSAP.Security.Infrastructure;
using ProvastSAP.Security.Repositories;
using ProvastSAP.Security.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProvastSAP.Security
{
    public class OryxSecurityModule : Autofac.Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterGeneric(typeof(BaseSecurityRepository<,>))
               .As(typeof(ILogRepository<,>))
               .InstancePerLifetimeScope();

            builder.RegisterGeneric(typeof(BaseSecurityLogRepository<,,>))
               .As(typeof(ILogRepository<,>))
               .InstancePerLifetimeScope();


            builder.RegisterType<SecurityUnitOfWork>()
                .As<ISecurityUnitOfWork>()
                .InstancePerLifetimeScope();

            builder.RegisterType<ActionRepository>();
            builder.RegisterType<SecurityObjectRepository>();
            builder.RegisterType<GroupRepository>();
            builder.RegisterType<UserRepository>();




            builder.RegisterType<SecurityObjectService>();
            builder.RegisterType<ActionService>();
            builder.RegisterType<GroupService>();
            builder.RegisterType<UserService>();


        }
    }
}
