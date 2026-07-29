using OpenQA.Selenium;
using SauceDemo.Tests.Configuration;
using SauceDemo.Tests.Core.Browsers;

namespace SauceDemo.Tests.Core.Driver;

public class DriverManager
{
    public IWebDriver Driver { get; }

    public DriverManager()
    {
        BrowserType browser = Enum.Parse<BrowserType>(
            ConfigurationManager.Settings.Browser,
            ignoreCase: true);

        Driver = BrowserFactory.Create(browser);

        Driver.Manage().Window.Maximize();

        Driver.Manage().Timeouts().ImplicitWait = TimeSpan.Zero;
    }

    public void Quit()
    {
        try
        {
            Driver.Quit();
        }
        catch (WebDriverException)
        {
            // Ignore if the browser has already been closed.
        }
        finally
        {
            Driver.Dispose();
        }
    }
}