using NUnit.Framework;
using OpenQA.Selenium;
using SauceDemo.Tests.Configuration;
using SauceDemo.Tests.Core.Driver;
using SauceDemo.Tests.Core.Factories;
using SauceDemo.Tests.Core.Waits;
using SauceDemo.Tests.Utilities;

namespace SauceDemo.Tests.Tests;

public abstract class BaseTest
{
    private DriverManager? _driverManager;

    protected IWebDriver Driver => _driverManager!.Driver;

    protected WaitService Wait = null!;

    protected PageProvider Pages = null!;

    [SetUp]
    public virtual void SetUp()
    {
        TestLogger.Info(
            $"===== START: {TestContext.CurrentContext.Test.Name} =====");

        _driverManager = new DriverManager();

        Wait = new WaitService(Driver);

        Pages = new PageProvider(
            Driver,
            Wait);

        Driver.Navigate()
            .GoToUrl(ConfigurationManager.Settings.BaseUrl);
    }

    [TearDown]
    public virtual void TearDown()
    {
        TestLogger.Info(
            $"===== END: {TestContext.CurrentContext.Test.Name} ({TestContext.CurrentContext.Result.Outcome.Status}) =====");

        _driverManager?.Quit();
    }
}