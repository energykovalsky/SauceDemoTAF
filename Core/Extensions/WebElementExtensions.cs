using OpenQA.Selenium;

namespace SauceDemo.Tests.Core.Extensions;

public static class WebElementExtensions
{
    public static void ClearAndType(this IWebElement element, string text)
    {
        element.Clear();
        element.SendKeys(text);
    }
}
