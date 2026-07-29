using OpenQA.Selenium;
using SauceDemo.Tests.Components;
using SauceDemo.Tests.Core.Waits;

namespace SauceDemo.Tests.Pages;

public abstract class BasePage
{
    #region Properties

    protected IWebDriver Driver { get; }

    protected WaitService Wait { get; }

    public HeaderComponent Header { get; }

    #endregion

    #region Constructor

    protected BasePage(IWebDriver driver, WaitService wait)
    {
        Driver = driver;
        Wait = wait;

        Header = new HeaderComponent(driver, wait);
    }

    #endregion

    #region Protected Methods

    protected IWebElement Find(By locator)
    {
        return Wait.UntilVisible(locator);
    }

    protected void Click(By locator)
    {
        Wait.UntilClickable(locator).Click();
    }

    protected void Type(By locator, string text)
    {
        IWebElement element = Find(locator);

        //element.Clear();
        element.SendKeys(Keys.Control + "a");
        element.SendKeys(Keys.Delete);
        element.SendKeys(text);

    }

    protected void Clear(By locator)
    {
        //Find(locator).Clear();
        IWebElement element = Find(locator);

        element.SendKeys(Keys.Control + "a");
        element.SendKeys(Keys.Delete);
    }

    protected string GetText(By locator)
    {
        return Find(locator).Text;
    }

    protected bool IsDisplayed(By locator)
    {
        return Find(locator).Displayed;
    }

    #endregion
}
