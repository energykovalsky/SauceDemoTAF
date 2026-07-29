using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SauceDemo.Tests.Configuration;

namespace SauceDemo.Tests.Core.Waits;

public class WaitService
{
    private readonly WebDriverWait _wait;

    public WaitService(IWebDriver driver)
    {
        _wait = new WebDriverWait(
            driver,
            TimeSpan.FromSeconds(ConfigurationManager.Settings.TimeoutSeconds));
    }

    #region Wait Methods

    // remove unused methods and add more wait methods as needed
    public IWebElement UntilExists(By locator)
    {
        return _wait.Until(driver =>
        {
            try
            {
                return driver.FindElement(locator);
            }
            catch (NoSuchElementException)
            {
                return null;
            }
        })!;
    }

    public IWebElement UntilVisible(By locator)
    {
        return _wait.Until(driver =>
        {
            try
            {
                IWebElement element = driver.FindElement(locator);

                return element.Displayed
                    ? element
                    : null;
            }
            catch (NoSuchElementException)
            {
                return null;
            }
            catch (StaleElementReferenceException)
            {
                return null;
            }
        })!;
    }

    public IWebElement UntilClickable(By locator)
    {
        return _wait.Until(driver =>
        {
            try
            {
                IWebElement element = driver.FindElement(locator);

                return element.Displayed && element.Enabled
                    ? element
                    : null;
            }
            catch (NoSuchElementException)
            {
                return null;
            }
            catch (StaleElementReferenceException)
            {
                return null;
            }
        })!;
    }

    public bool UntilInvisible(By locator)
    {
        return _wait.Until(driver =>
        {
            try
            {
                return !driver.FindElement(locator).Displayed;
            }
            catch (NoSuchElementException)
            {
                return true;
            }
            catch (StaleElementReferenceException)
            {
                return true;
            }
        });
    }

    #endregion

    #region Helper Methods

    public bool Exists(By locator)
    {
        return _wait.Until(driver =>
            driver.FindElements(locator).Any());
    }

    #endregion
}