using Microsoft.Extensions.Configuration;

namespace SauceDemo.Tests.Configuration;

public static class ConfigurationManager
{
    private static readonly Lazy<TestSettings> _settings = new(() =>
    {
        IConfiguration configuration = new ConfigurationBuilder()
            .SetBasePath(AppContext.BaseDirectory)
            .AddJsonFile("appsettings.json", optional: false)
            .Build();

        return configuration
            .GetSection("TestSettings")
            .Get<TestSettings>()!;
    });

    public static TestSettings Settings => _settings.Value;
}
