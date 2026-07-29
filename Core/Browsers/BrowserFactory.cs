using OpenQA.Selenium;

namespace SauceDemo.Tests.Core.Browsers;

public static class BrowserFactory
{
    public static IWebDriver Create(BrowserType browserType)
    {
        return browserType switch
        {
            BrowserType.Firefox => BrowserOptionsFactory.CreateFirefox(),
            BrowserType.Edge => BrowserOptionsFactory.CreateEdge(),
            BrowserType.Chrome => BrowserOptionsFactory.CreateChrome(),
            _ => throw new ArgumentOutOfRangeException(nameof(browserType))
        };
    }
}
