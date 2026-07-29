using SauceDemo.Tests.Business.Models;

namespace SauceDemo.Tests.Business.ExpectedData;

public static class ProductCatalog
{
    public static readonly Product Backpack = new()
    {
        Id = 4,
        Name = "Sauce Labs Backpack",
        Price = 29.99m,
        Description = "carry.allTheThings() with the sleek, streamlined Sly Pack that melds uncompromising style with unequaled laptop and tablet protection."
    };

    public static readonly Product BikeLight = new()
    {
        Id = 0,
        Name = "Sauce Labs Bike Light",
        Price = 9.99m,
        Description = "A red light isn't the desired state in testing but it sure helps when riding your bike at night. Water-resistant with 3 lighting modes, 1 AAA battery included."
    };

    public static readonly Product BoltTShirt = new()
    {
        Id = 1,
        Name = "Sauce Labs Bolt T-Shirt",
        Price = 15.99m,
        Description = "Get your testing superhero on with the Sauce Labs bolt T-shirt. From American Apparel, 100% ringspun combed cotton, heather gray with red bolt."
    };

    public static readonly Product FleeceJacket = new()
    {
        Id = 5,
        Name = "Sauce Labs Fleece Jacket",
        Price = 49.99m,
        Description = "It's not every day that you come across a midweight quarter-zip fleece jacket capable of handling everything from a relaxing day outdoors to a busy day at the office."
    };

    public static readonly Product Onesie = new()
    {
        Id = 2,
        Name = "Sauce Labs Onesie",
        Price = 7.99m,
        Description = "Rib snap infant onesie for the junior automation engineer in development. Reinforced 3-snap bottom closure, two-needle hemmed sleeved and bottom won't unravel."
    };

    public static readonly Product TestAllTheThingsTShirt = new()
    {
        Id = 3,
        Name = "Test.allTheThings() T-Shirt (Red)",
        Price = 15.99m,
        Description = "This classic Sauce Labs t-shirt is perfect to wear when cozying up to your keyboard to automate a few tests. Super-soft and comfy ringspun combed cotton."
    };
}
