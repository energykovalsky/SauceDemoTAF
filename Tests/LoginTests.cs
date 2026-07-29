using FluentAssertions;
using SauceDemo.Tests.Business.Models;
using SauceDemo.Tests.Business.TestData;

namespace SauceDemo.Tests.Tests;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class LoginTests : BaseTest
{
    #region UC-1

    [Test]
    public void Login_WithMissingPassword_Should_ShowPasswordRequiredMessage()
    {
        // Act

        Pages.LoginWorkflow.LoginWithoutPassword(
            Users.StandardUser.Username,
            Users.StandardUser.Password);

        // Assert

        Pages.LoginWorkflow
            .IsErrorDisplayed()
            .Should()
            .BeTrue();

        Pages.LoginWorkflow
            .GetErrorMessage()
            .Should()
            .Contain("Password is required");
    }

    #endregion

    #region UC-2

    [Test]
    [TestCaseSource(typeof(LoginTestCases), nameof(LoginTestCases.ValidUsers))]
    public void StandardUser_Should_LoginSuccessfully(User user)
    {
        // Act

        Pages.LoginWorkflow.Login(user);

        // Assert

        Pages.InventoryWorkflow
            .IsMenuButtonDisplayed()
            .Should()
            .BeTrue();

        Pages.InventoryWorkflow
            .IsShoppingCartDisplayed()
            .Should()
            .BeTrue();

        Pages.InventoryWorkflow
            .IsSortingDisplayed()
            .Should()
            .BeTrue();

        Pages.InventoryWorkflow
            .HasProducts()
            .Should()
            .BeTrue();
    }

    #endregion
}