using SauceDemo.Tests.Business.Models;
using SauceDemo.Tests.Pages;
using SauceDemo.Tests.Utilities;

namespace SauceDemo.Tests.Business.Workflows;

public class LoginWorkflow
{
    private readonly LoginPage _loginPage;

    public LoginWorkflow(LoginPage loginPage)
    {
        _loginPage = loginPage;
    }

    #region Actions

    public void Login(User user)
    {
        TestLogger.Info($"Logging in as '{user.Username}'.");

        _loginPage.Login(
            user.Username,
            user.Password);
    }

    public void Login(string username, string password)
    {
        TestLogger.Info($"Logging in as '{username}'.");

        _loginPage.Login(username, password);
    }

    public void LoginWithoutPassword(string username, string password)
    {
        TestLogger.Info(
            $"Attempting login without password for '{username}'.");

        _loginPage.EnterUsername(username);
        _loginPage.EnterPassword(password);
        _loginPage.ClearPassword();
        _loginPage.ClickLogin();
    }

    #endregion

    #region State

    public bool IsErrorDisplayed()
    {
        return _loginPage.IsErrorDisplayed();
    }

    #endregion

    #region Getters

    public string GetErrorMessage()
    {
        return _loginPage.GetErrorMessage();
    }

    #endregion
}