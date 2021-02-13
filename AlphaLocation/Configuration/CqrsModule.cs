using AlphaLocation.Cqrs;
using AlphaLocation.Queries;
using Autofac;
using MediatR;
using System.Reflection;

namespace AlphaLocation.Web.Configuration
{
	public class CqrsModule : Autofac.Module
	{
		private readonly Assembly[] assemblies = new Assembly[]
		{
			AlphaLocationQueries.Assembly,
		};

		protected override void Load(ContainerBuilder builder)
		{
			RegisterMediatR(builder);
			RegisterMediatorWrapper(builder);

			// request & notification handlers
			builder.Register<ServiceFactory>(context =>
			{
				IComponentContext c = context.Resolve<IComponentContext>();
				return t => c.Resolve(t);
			});

			this.RegisterHandlersFromAssemblies(builder);
		}
		private static void RegisterMediatR(ContainerBuilder builder)
		{
			builder
				.RegisterType<Mediator>()
				.As<IMediator>()
				.InstancePerLifetimeScope();
		}
		private static void RegisterMediatorWrapper(ContainerBuilder builder)
		{
			builder
				.RegisterType<MediatorWrapper>()
				.As<IMediatorWrapper>()
				.InstancePerLifetimeScope();
		}
		private void RegisterHandlersFromAssemblies(ContainerBuilder builder)
		{
			// finally register our custom code (individually, or via assembly scanning)
			// - requests & handlers as transient, i.e. InstancePerDependency()
			// - pre/post-processors as scoped/per-request, i.e. InstancePerLifetimeScope()
			// - behaviors as transient, i.e. InstancePerDependency()
			builder
				.RegisterAssemblyTypes(assemblies)
				.Where(t => !t.IsInterface && t.Name.EndsWith("Handler"))
				.AsImplementedInterfaces(); // via assembly scan
		}
	}
}
