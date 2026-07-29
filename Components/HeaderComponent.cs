using OpenQA.Selenium;
using SauceDemo.Tests.Core.Waits;

namespace SauceDemo.Tests.Components;

public class HeaderComponent
{
    #region Locators

    private readonly By _menuButton =
        By.CssSelector("[data-test='open-menu']");

    private readonly By _cartButton =
        By.CssSelector("[data-test='shopping-cart-link']");

    private readonly By _cartBadge =
        By.CssSelector("[data-test='shopping-cart-badge']");

    #endregion

    #region Fields

    private readonly IWebDriver _driver;
    private readonly WaitService _wait;

    #endregion

    #region Constructor

    public HeaderComponent(IWebDriver driver, WaitService wait)
    {
        _driver = driver;
        _wait = wait;
    }

    #endregion

    #region Actions

    public void OpenMenu()
    {
        _wait.UntilClickable(_menuButton).Click();
    }

    public void OpenCart()
    {
        _wait.UntilClickable(_cartButton).Click();
    }

    #endregion

    #region State

    public bool IsMenuButtonDisplayed()
    {
        return _wait.UntilVisible(_menuButton).Displayed;
    }

    public bool IsCartDisplayed()
    {
        return _wait.UntilVisible(_cartButton).Displayed;
    }

    #endregion

    #region Getters

    public int GetCartItemsCount()
    {
        IReadOnlyCollection<IWebElement> badges =
            _driver.FindElements(_cartBadge);

        if (badges.Count == 0)
            return 0;

        return int.Parse(badges.First().Text);
    }

    #endregion
}