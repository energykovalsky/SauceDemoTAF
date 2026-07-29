using SauceDemo.Tests.Business.Models;

namespace SauceDemo.Tests.Business.TestData;

public static class Users
{
    public static readonly User StandardUser = new() { Username = "standard_user", Password = "secret_sauce" };

    public static readonly User LockedOutUser = new() { Username = "locked_out_user", Password = "secret_sauce" };

    public static readonly User ProblemUser = new() { Username = "problem_user", Password = "secret_sauce" };

    public static readonly User PerformanceGlitchUser = new() { Username = "performance_glitch_user", Password = "secret_sauce" };

    public static readonly User ErrorUser = new() { Username = "error_user", Password = "secret_sauce" };

    public static readonly User VisualUser = new() { Username = "visual_user", Password = "secret_sauce" };
}
