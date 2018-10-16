using System.Reflection;
using Autofac;
using SFX.Domain;
using SFX.Infrastructure;
using SFX.Infrastructure.Mappings;
using SFX.Web.Controllers.Asset;
using SFX.Web.Mappings;

namespace SFX.Web.Modules
{
    public class InjectionModule : Autofac.Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterGeneric(typeof(GenericRepository<>)).As(typeof(IGenericRepository<>));

            builder.RegisterAssemblyTypes(Assembly.Load("SFX.Services")).Where(t => t.Name.EndsWith("Service")).AsImplementedInterfaces().InstancePerLifetimeScope();

            builder.RegisterAssemblyTypes(typeof(IOutputConverter).Assembly)
                .AsImplementedInterfaces()
                .InstancePerLifetimeScope();

            builder.RegisterAssemblyTypes(typeof(OutputConverter).Assembly)
                .AsImplementedInterfaces().InstancePerLifetimeScope();

            builder.RegisterAssemblyTypes(typeof(Presenter).Assembly).AsSelf().InstancePerLifetimeScope();
        }
    }
}
