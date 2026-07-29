using SauceDemo.Tests.Pages;
using SauceDemo.Tests.Utilities;

namespace SauceDemo.Tests.Business.Workflows;

public class CartWorkflow
{
    private readonly CartPage _cartPage;

    public CartWorkflow(CartPage cartPage)
    {
        _cartPage = cartPage;
    }

    #region Actions

    public void ContinueShopping()
    {
        TestLogger.Info("Continuing shopping.");

        _cartPage.ContinueShopping();
    }

    public void Checkout()
    {
        TestLogger.Info("Starting checkout.");

        _cartPage.Checkout();
    }

    #endregion

    #region State

    public bool IsLoaded()
    {
        return _cartPage.IsCheckoutButtonDisplayed()
            && _cartPage.IsContinueShoppingButtonDisplayed();
    }

    #endregion

    #region Getters

    public int GetProductsCount()
    {
        return _cartPage.GetProductsCount();
    }

    #endregion
}