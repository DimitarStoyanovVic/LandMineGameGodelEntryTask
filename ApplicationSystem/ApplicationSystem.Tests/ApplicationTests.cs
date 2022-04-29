using ApplicationSystem.Core;
using ApplicationSystem.Interfaces;
using ApplicationSystem.IoC;
using ApplicationSystem.Utilities.Constants;
using Autofac;
using Xunit;

namespace ApplicationSystem.Tests;

public class ApplicationTests
{
    private readonly IContainer container = ContainerConfig.Configure();
    
    [Fact]
    public void Creating_Application_Returns_Object()
    {
        // Arrange
        using ILifetimeScope scope = container.BeginLifetimeScope();
        IApplication app = scope.Resolve<IApplication>();
        
        // Act
        Assert.NotNull(app);
    }

    [Fact]
    public void Creating_Application_Returns_Correct_Object()
    {
        // Arrange
        using ILifetimeScope scope = container.BeginLifetimeScope();
        IApplication app = scope.Resolve<IApplication>();

        string expectedObjectName = nameof(Application); 
        
        // Act
        Assert.Equal(expectedObjectName, app.GetType().Name);
    }

    [Fact]
    public void Creating_Application_Returns_Correct_Exception_Type()
    {
        // Arrange
        using ILifetimeScope scope = container.BeginLifetimeScope();
        IApplication app = scope.Resolve<IApplication>();

        string expectedArgumentExceptionType = nameof(ArgumentException);

        // Act
        string actualArgumentExceptionType = "";
        try
        {
            app.Run(null);
        }
        catch (Exception ex)
        {
            actualArgumentExceptionType = ex.GetType().Name;
        }

        // Assert
        Assert.Equal(expectedArgumentExceptionType, actualArgumentExceptionType);
    }

    [Fact]
    public void Creating_Application_Returns_Correct_Exception_Message()
    {
        // Arrange
        using ILifetimeScope scope = container.BeginLifetimeScope();
        IApplication app = scope.Resolve<IApplication>();
        
        // Act
        string actualArgumentExceptionMessage = "";
        try
        {
            app.Run(null);
        }
        catch (Exception ex)
        {
            actualArgumentExceptionMessage = ex.Message;
        }
        
        // Assert
        Assert.Equal(ConstantsErrorMessages.APPLICATION_APP_TYPE_NAME_CANT_BE_NULL, actualArgumentExceptionMessage);
    }
}