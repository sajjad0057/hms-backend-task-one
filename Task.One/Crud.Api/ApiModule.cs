using Autofac;
using Crud.Api.Models;

namespace Crud.Api
{
    public class ApiModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {

            builder.RegisterType<ProductModel>().AsSelf();

            base.Load(builder);
        }
    }
}
