namespace ApplicationSystem.Interfaces;

public interface IApplicationCreator
{
    public IApplicationLauncher CreateApplicationType(string? appTypeName);
}