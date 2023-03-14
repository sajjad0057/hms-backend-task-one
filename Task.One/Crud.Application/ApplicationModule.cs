using Autofac;
using Crud.Application.DbContexts;
using Crud.Application.DTOs;
using Crud.Application.Repositories;
using Crud.Application.Services;
using Crud.Application.UnitOfWorks;

namespace Crud.Application
{
    public class ApplicationModule : Module
    {
        private readonly string _connectingString;
        private readonly string _migrationAssemblyName;

        public ApplicationModule(string connectingString, string migrationAssemblyName)
        {
            _connectingString = connectingString;
            _migrationAssemblyName = migrationAssemblyName;
        }

        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<ApplicationDbContext>().AsSelf()
                .WithParameter("connectingString", _connectingString)
                .WithParameter("migrationAssemblyName", _migrationAssemblyName)
                .InstancePerLifetimeScope();

            builder.RegisterType<ApplicationDbContext>().As<IApplicationDbContext>()
                .WithParameter("connectingString", _connectingString)
                .WithParameter("migrationAssemblyName", _migrationAssemblyName)
                .InstancePerLifetimeScope();

            builder.RegisterType<ApplicationUnitOfWork>().As<IApplicationUnitOfWork>()
                .InstancePerLifetimeScope();

            builder.RegisterType<ProductService>().As<IProductService>()
                .InstancePerLifetimeScope();

            builder.RegisterType<ProductRepository>().As<IProductRepository>()
                .InstancePerLifetimeScope();

            builder.RegisterType<ProductDto>().AsSelf();


            base.Load(builder);
        }
    }
}
