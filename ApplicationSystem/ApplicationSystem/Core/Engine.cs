using ApplicationSystem.Interfaces;

namespace ApplicationSystem.Core;

public class Engine
{
    private readonly IApplicationLauncher applicationLauncher;
    
    public Engine(IApplicationLauncher applicationLauncher)
    {
        this.applicationLauncher = applicationLauncher;
    }

    public void Run()
    {
        this.applicationLauncher.LaunchApplication();
    }
}