using SauceDemo.Tests.Business.Models;

namespace SauceDemo.Tests.Business.TestData;

public static class Products
{
    public static readonly Product Backpack = new() { Id = 4, Name = "Sauce Labs Backpack" };

    public static readonly Product BikeLight = new() { Id = 0, Name = "Sauce Labs Bike Light" };

    public static readonly Product BoltTShirt = new() { Id = 1, Name = "Sauce Labs Bolt T-Shirt" };

    public static readonly Product FleeceJacket = new() { Id = 5, Name = "Sauce Labs Fleece Jacket" };

    public static readonly Product Onesie = new() { Id = 2, Name = "Sauce Labs Onesie" };

    public static readonly Product TestAllTheThingsTShirt = new() { Id = 3, Name = "Test.allTheThings() T-Shirt (Red)" };
}
