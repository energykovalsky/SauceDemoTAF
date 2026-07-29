using SauceDemo.Tests.Pages;
using SauceDemo.Tests.Utilities;

namespace SauceDemo.Tests.Business.Workflows;

public class ProductWorkflow
{
    private readonly ProductPage _productPage;

    public ProductWorkflow(ProductPage productPage)
    {
        _productPage = productPage;
    }

    #region Actions

    public void AddToCart()
    {
        TestLogger.Info("Adding current product to the shopping cart.");

        _productPage
            .GetProduct()
            .AddToCart();
    }

    public void RemoveFromCart()
    {
        TestLogger.Info("Removing current product from the shopping cart.");

        _productPage
            .GetProduct()
            .RemoveFromCart();
    }

    public void BackToProducts()
    {
        TestLogger.Info("Returning to the inventory page.");

        _productPage.BackToProducts();
    }

    public void OpenCart()
    {
        TestLogger.Info("Opening shopping cart.");

        _productPage.Header.OpenCart();
    }

    #endregion

    #region State

    public bool IsLoaded()
    {
        return _productPage.GetProduct() != null;
    }

    #endregion

    #region Getters

    public int GetCartItemsCount()
    {
        return _productPage.Header.GetCartItemsCount();
    }

    #endregion
}