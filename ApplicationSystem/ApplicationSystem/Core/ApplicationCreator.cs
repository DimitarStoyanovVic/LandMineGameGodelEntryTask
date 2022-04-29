using ApplicationSystem.Interfaces;
using ApplicationSystem.Utilities.Constants;

namespace ApplicationSystem.Core;

public class ApplicationCreator : IApplicationCreator
{
    public IApplicationLauncher CreateApplicationType(string? appTypeName)
    {
        if (appTypeName is null)
        {
            throw new ArgumentException(ConstantsErrorMessages.APPLICATION_CREATOR_APP_TYPE_NAME_CANT_BE_NULL);
        }
        
        var type = System.Reflection.Assembly.GetExecutingAssembly().ExportedTypes.FirstOrDefault(x => x.Name.Contains($"{appTypeName}Game"));
        return (IApplicationLauncher) Activator.CreateInstance(type);
    }
}