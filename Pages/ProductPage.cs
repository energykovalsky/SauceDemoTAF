using OpenQA.Selenium;
using SauceDemo.Tests.Components;
using SauceDemo.Tests.Core.Waits;

namespace SauceDemo.Tests.Pages;

public class ProductPage : BasePage
{
    #region Locators

    private readonly By _productContainer = By.CssSelector("[data-test='inventory-item']");

    private readonly By _backButton = By.CssSelector("[data-test='back-to-products']");

    #endregion

    #region Constructor

    public ProductPage(IWebDriver driver, WaitService wait) : base(driver, wait)
    {
    }

    #endregion

    #region Getters

    public ProductDetailsComponent GetProduct()
    {
        return new ProductDetailsComponent(Find(_productContainer));
    }

    #endregion

    #region Actions

    public void BackToProducts()
    {
        Click(_backButton);
    }

    #endregion
}
