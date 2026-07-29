namespace SauceDemo.Tests.Utilities;

public static class TestLogger
{
    public static void Info(string message)
    {
        TestContext.Progress.WriteLine(
            $"[{DateTime.Now:HH:mm:ss}] {message}");
    }
}