namespace SauceDemo.Tests.Business.Models;

public class Product
{
    public int Id { get; init; }

    public string Name { get; init; } = string.Empty;

    public decimal? Price { get; init; }

    public string? Description { get; init; }
}
