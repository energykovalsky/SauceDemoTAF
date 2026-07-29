using SauceDemo.Tests.Business.Models;

namespace SauceDemo.Tests.Business.TestData;

public static class LoginTestCases
{
    public static IEnumerable<User> ValidUsers()
    {
        yield return Users.StandardUser;

        // Future examples:
        // yield return Users.ProblemUser;
        // yield return Users.PerformanceGlitchUser;
    }
}