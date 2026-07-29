namespace SauceDemo.Tests.Configuration;

public class TestSettings
{
    public string BaseUrl { get; set; } = string.Empty;

    public string Browser { get; set; } = string.Empty;

    public bool Headless { get; set; }

    public int TimeoutSeconds { get; set; }
}
