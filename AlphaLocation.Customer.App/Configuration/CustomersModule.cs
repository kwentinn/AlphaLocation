using AlphaLocation.Customers.App.Assemblies;
using AlphaLocation.Customers.Domain.Assemblies;
using AlphaLocation.Customers.Infra.Assemblies;
using Autofac;
using System.Reflection;

namespace AlphaLocation.Customers.App.Configuration
{
    public class CustomersModule : Autofac.Module
    {
        private readonly Assembly[] assemblies = new Assembly[]
        {
            AlphaLocationCustomers_App.Assembly,
            AlphaLocationCustomers_Domain.Assembly,
            AlphaLocationCustomers_Infra.Assembly
        };

        protected override void Load(ContainerBuilder builder)
        {
            builder
                .RegisterAssemblyTypes(assemblies)
                .Where(t => !t.IsInterface && t.Name.EndsWith("Repository"))
                .AsImplementedInterfaces();

            builder
                .RegisterAssemblyTypes(assemblies)
                .Where(t => !t.IsInterface && t.Name == "Store")
                .AsImplementedInterfaces();

            builder
                .RegisterAssemblyTypes(assemblies)
                .Where(t => !t.IsInterface && t.Name.EndsWith("Handler"))
                .AsImplementedInterfaces();
        }
    }
}
