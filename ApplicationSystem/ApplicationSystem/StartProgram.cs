using ApplicationSystem.Interfaces;
using ApplicationSystem.IoC;
using Autofac;

namespace ApplicationSystem;

public static class StartProgram
{
    public static void Main()
    {
        Console.Write("Please write the name of game you wish to play: ");
        string? applicationTypeName = Console.ReadLine();
        Console.WriteLine("Thank you for selecting your game!");
    
        IContainer container = ContainerConfig.Configure();
    
        using ILifetimeScope scope = container.BeginLifetimeScope();
        IApplication app = scope.Resolve<IApplication>();
        app.Run(applicationTypeName);
    }
}