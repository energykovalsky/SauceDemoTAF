using OpenQA.Selenium;
using SauceDemo.Tests.Core.Waits;

namespace SauceDemo.Tests.Pages;

public class LoginPage : BasePage
{
    #region Locators

    private readonly By _usernameField =
        By.Id("user-name");

    private readonly By _passwordField =
        By.Id("password");

    private readonly By _loginButton =
        By.Id("login-button");

    private readonly By _errorMessage =
        By.CssSelector("[data-test='error']");

    private readonly By _closeErrorButton =
        By.CssSelector("[data-test='error-button']");

    #endregion

    #region Constructor

    public LoginPage(
        IWebDriver driver,
        WaitService wait)
        : base(driver, wait)
    {
    }

    #endregion

    #region Actions

    public void EnterUsername(string username)
    {
        Type(_usernameField, username);
    }

    public void EnterPassword(string password)
    {
        Type(_passwordField, password);
    }

    public void ClearUsername()
    {
        Clear(_usernameField);
    }

    public void ClearPassword()
    {
        IWebElement password = Find(_passwordField);

        password.SendKeys(Keys.Control + "a");
        password.SendKeys(Keys.Delete);

        Find(_usernameField).Click();
    }

    public void ClickLogin()
    {
        Click(_loginButton);
    }

    public void Login(string username, string password)
    {
        EnterUsername(username);
        EnterPassword(password);
        ClickLogin();
    }

    public void CloseErrorMessage()
    {
        Click(_closeErrorButton);
    }

    #endregion

    #region State

    public bool IsErrorDisplayed()
    {
        //return Find(_errorMessage).Displayed;
        return IsDisplayed(_errorMessage);
    }

    #endregion

    #region Getters

    public string GetErrorMessage()
    {
        return GetText(_errorMessage);
    }

    public string GetPasswordValue()
    {
        return Find(_passwordField).GetAttribute("value");
    }

    public string GetCurrentUrl()
    {
        return Driver.Url;
    }

    public string GetPageTitle()
    {
        return Driver.Title;
    }

    public int ErrorElementsCount()
    {
        return Driver.FindElements(_errorMessage).Count;
    }

    #endregion
}