using SauceDemo.Tests.Business.Models;
using SauceDemo.Tests.Pages;
using SauceDemo.Tests.Utilities;

namespace SauceDemo.Tests.Business.Workflows;

public class InventoryWorkflow
{
    private readonly InventoryPage _inventoryPage;

    public InventoryWorkflow(InventoryPage inventoryPage)
    {
        _inventoryPage = inventoryPage;
    }

    #region Actions

    public void AddProductToCart(Product product)
    {
        TestLogger.Info($"Adding '{product.Name}' to the shopping cart.");

        _inventoryPage
            .GetProduct(product)
            .AddToCart();
    }

    public void RemoveProductFromCart(Product product)
    {
        TestLogger.Info($"Removing '{product.Name}' from the shopping cart.");

        _inventoryPage
            .GetProduct(product)
            .RemoveFromCart();
    }

    public void OpenProduct(Product product)
    {
        TestLogger.Info($"Opening product '{product.Name}'.");

        _inventoryPage
            .GetProduct(product)
            .Open();
    }

    public void OpenCart()
    {
        TestLogger.Info("Opening shopping cart.");

        _inventoryPage.Header.OpenCart();
    }

    public void OpenMenu()
    {
        TestLogger.Info("Opening navigation menu.");

        _inventoryPage.Header.OpenMenu();
    }

    #endregion

    #region State

    public bool IsLoaded()
    {
        return _inventoryPage.IsLoaded();
    }

    public bool IsMenuButtonDisplayed()
    {
        return _inventoryPage.Header.IsMenuButtonDisplayed();
    }

    public bool IsShoppingCartDisplayed()
    {
        return _inventoryPage.Header.IsCartDisplayed();
    }

    public bool IsSortingDisplayed()
    {
        return _inventoryPage.IsSortingDisplayed();
    }

    public bool HasProducts()
    {
        return _inventoryPage.HasProducts();
    }

    #endregion

    #region Getters

    public int GetProductsCount()
    {
        return _inventoryPage.GetProductsCount();
    }

    #endregion
}