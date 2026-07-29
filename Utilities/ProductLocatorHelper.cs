namespace SauceDemo.Tests.Utilities;

public static class ProductLocatorHelper
{
    public static string NormalizeProductName(string productName)
    {
        return productName
            .ToLowerInvariant()
            .Replace(".", string.Empty)
            .Replace("(", string.Empty)
            .Replace(")", string.Empty)
            .Replace(" ", "-");
    }

    public static string AddToCartDataTest(string productName)
    {
        return $"add-to-cart-{NormalizeProductName(productName)}";
    }

    public static string RemoveDataTest(string productName)
    {
        return $"remove-{NormalizeProductName(productName)}";
    }
}
