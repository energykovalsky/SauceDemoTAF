using OpenQA.Selenium;
using SauceDemo.Tests.Core.Waits;

namespace SauceDemo.Tests.Pages;

public class CartPage : BasePage
{
    #region Locators

    private readonly By _cartItems = By.CssSelector("[data-test='inventory-item']");

    private readonly By _continueShoppingButton = By.CssSelector("[data-test='continue-shopping']");

    private readonly By _checkoutButton = By.CssSelector("[data-test='checkout']");

    #endregion

    #region Constructor

    public CartPage(IWebDriver driver, WaitService wait) : base(driver, wait)
    {
    }

    #endregion

    #region Getters

    public int GetProductsCount()
    {
        return Driver.FindElements(_cartItems).Count;
    }

    public bool IsCheckoutButtonDisplayed()
    {
        return Find(_checkoutButton).Displayed;
    }

    public bool IsContinueShoppingButtonDisplayed()
    {
        return Find(_continueShoppingButton).Displayed;
    }

    #endregion

    #region Actions

    public void ContinueShopping()
    {
        Click(_continueShoppingButton);
    }

    public void Checkout()
    {
        Click(_checkoutButton);
    }

    #endregion
}
