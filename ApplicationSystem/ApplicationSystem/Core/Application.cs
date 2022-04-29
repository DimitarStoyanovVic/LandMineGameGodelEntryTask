using ApplicationSystem.Interfaces;
using ApplicationSystem.Utilities.Constants;

namespace ApplicationSystem.Core;

public class Application : IApplication
{
    private readonly IApplicationCreator applicationCreator;

    public Application(IApplicationCreator applicationCreator)
    {
        this.applicationCreator = applicationCreator;
    }
    
    public void Run(string? applicationTypeName)
    {
        if (applicationTypeName is null)
        {
            throw new ArgumentException(ConstantsErrorMessages.APPLICATION_APP_TYPE_NAME_CANT_BE_NULL);
        }
        
        IApplicationLauncher applicationType = this.applicationCreator.CreateApplicationType(applicationTypeName);
        Engine engine = new Engine(applicationType);
        engine.Run();
    }
}