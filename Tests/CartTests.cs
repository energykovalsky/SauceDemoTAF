using FluentAssertions;
using SauceDemo.Tests.Business.TestData;

namespace SauceDemo.Tests.Tests;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class CartTests : BaseTest
{
    #region Cart 
    // helper cart behavior tests

    [Test]
    public void AddedProduct_Should_AppearInShoppingCart()
    {
        // Arrange

        Pages.LoginWorkflow.Login(
            Users.StandardUser);

        // Act

        Pages.InventoryWorkflow.AddProductToCart(
            Products.Backpack);

        Pages.InventoryWorkflow.OpenCart();

        // Assert

        Pages.CartWorkflow
            .GetProductsCount()
            .Should()
            .Be(1);
    }

    [Test]
    public void ContinueShopping_Should_ReturnToInventory()
    {
        // Arrange

        Pages.LoginWorkflow.Login(
            Users.StandardUser);

        Pages.InventoryWorkflow.AddProductToCart(
            Products.Backpack);

        Pages.InventoryWorkflow.OpenCart();

        // Act

        Pages.CartWorkflow.ContinueShopping();

        // Assert

        Pages.InventoryWorkflow
            .IsLoaded()
            .Should()
            .BeTrue();
    }

    #endregion

    #region UC-3
    // final task test

    [Test]
    public void Product_Should_BeAddedToShoppingCart()
    {
        // Arrange

        Pages.LoginWorkflow.Login(
            Users.StandardUser);

        // Act

        Pages.InventoryWorkflow.OpenProduct(
            Products.Backpack);

        Pages.ProductWorkflow.AddToCart();

        // Assert

        Pages.ProductWorkflow
            .GetCartItemsCount()
            .Should()
            .Be(1);
    }

    #endregion
}