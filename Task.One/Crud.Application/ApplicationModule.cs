using Autofac;
using Crud.Application.Commands;
using Crud.Application.DbContexts;
using Crud.Application.DTOs;
using Crud.Application.Handlers;
using Crud.Application.Queries;
using Crud.Application.Repositories;
using Crud.Application.Services;
using Crud.Application.UnitOfWorks;
using Crud.Domain.Entities;
using MediatR;

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

            builder.RegisterType<AddProductHandler>()
                .As<IRequestHandler<AddProductCommand>>()
                .InstancePerLifetimeScope();

            builder.RegisterType<UpdateProductHandler>()
                .As<IRequestHandler<UpdateProductCommand>>()
                .InstancePerLifetimeScope();

            builder.RegisterType<GetProductsHandler>()
                .As<IRequestHandler<GetProductsQuery, IList<ProductDto>>>()
                .InstancePerLifetimeScope();

            builder.RegisterType<RemoveProductHandler>()
                .As<IRequestHandler<RemoveProductCommand>>()
                .InstancePerLifetimeScope();

            base.Load(builder);
        }
    }
}
