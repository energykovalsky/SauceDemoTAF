using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using SauceDemo.Tests.Configuration;

namespace SauceDemo.Tests.Core.Browsers;

public static class BrowserOptionsFactory
{
    public static IWebDriver CreateFirefox()
    {
        FirefoxOptions options = new();

        if (ConfigurationManager.Settings.Headless)
            options.AddArgument("--headless");

        return new FirefoxDriver(options);
    }

    public static IWebDriver CreateEdge()
    {
        EdgeOptions options = new();

        if (ConfigurationManager.Settings.Headless)
            options.AddArgument("--headless=new");

        return new EdgeDriver(options);
    }

    public static IWebDriver CreateChrome()
    {
        ChromeOptions options = new();

        if (ConfigurationManager.Settings.Headless)
            options.AddArgument("--headless=new");

        options.AddExcludedArgument("enable-automation");

        options.AddUserProfilePreference(
            "credentials_enable_service", false);

        options.AddUserProfilePreference(
            "profile.password_manager_enabled", false);

        options.AddUserProfilePreference(
            "profile.password_manager_leak_detection", false);

        options.AddUserProfilePreference(
            "autofill.profile_enabled", false);

        options.AddUserProfilePreference(
            "autofill.credit_card_enabled", false);

        return new ChromeDriver(options);
    }
}
