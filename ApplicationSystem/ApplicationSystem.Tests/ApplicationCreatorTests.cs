using ApplicationSystem.Core;
using ApplicationSystem.Interfaces;
using ApplicationSystem.Models.BoardGames.Landmine;
using ApplicationSystem.Utilities.Constants;
using Xunit;

namespace ApplicationSystem.Tests;

public class ApplicationCreatorTests
{
    [Fact]
    public void ApplicationCreator_CreatingApplicationType_Returns_Object()
    {
        // Arrange
        ApplicationCreator applicationCreator = new ApplicationCreator();

        // Act
        IApplicationLauncher applicationType = applicationCreator.CreateApplicationType("Landmine");

        // Assert
        Assert.NotNull(applicationType);
    }
    
    [Fact]
    public void ApplicationCreator_CreatingApplicationType_Returns_Landmine_Object()
    {
        // Arrange
        ApplicationCreator applicationCreator = new ApplicationCreator();

        string expectedObject = nameof(LandmineGame);
        
        // Act
        IApplicationLauncher applicationType = applicationCreator.CreateApplicationType("Landmine");

        // Assert
        Assert.Equal(expectedObject, applicationType.GetType().Name);
    }
    
    [Fact]
    public void ApplicationCreator_CreatingApplicationType_Returns_Correct_Exception_Type()
    {
        // Arrange
        ApplicationCreator applicationCreator = new ApplicationCreator();

        string expectedArgumentExceptionType = nameof(ArgumentException);
        
        // Act
        string actualArgumentExceptionType = "";
        try
        {
            applicationCreator.CreateApplicationType(null);
        }
        catch (Exception ex)
        {
            actualArgumentExceptionType = ex.GetType().Name;
        }

        // Assert
        Assert.Equal(expectedArgumentExceptionType, actualArgumentExceptionType);
    }
    
    [Fact]
    public void ApplicationCreator_CreatingApplicationType_Returns_Correct_Exception_Message()
    {
        // Arrange
        ApplicationCreator applicationCreator = new ApplicationCreator();

        // Act
        string actualArgumentExceptionMessage = "";
        try
        {
            applicationCreator.CreateApplicationType(null);
        }
        catch (Exception ex)
        {
            actualArgumentExceptionMessage = ex.Message;
        }

        // Assert
        Assert.Equal(ConstantsErrorMessages.APPLICATION_CREATOR_APP_TYPE_NAME_CANT_BE_NULL, actualArgumentExceptionMessage);
    }
}