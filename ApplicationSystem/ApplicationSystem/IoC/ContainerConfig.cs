using System.Reflection;
using ApplicationSystem.Core;
using ApplicationSystem.Interfaces;
using Autofac;

namespace ApplicationSystem.IoC;

public static class ContainerConfig
{
    public static IContainer Configure()
    {
        var builder = new ContainerBuilder();

        builder.RegisterType<Application>().As<IApplication>();
        builder.RegisterType<ApplicationCreator>().As<IApplicationCreator>();

        builder.RegisterAssemblyTypes(Assembly.Load(nameof(ApplicationSystem)))
            .Where(t => t.Namespace.Contains("Interfaces"))
            .As(t => t.GetInterfaces().FirstOrDefault(i => i.Name == "I" + t.Name));
        
        return builder.Build();
    }
}