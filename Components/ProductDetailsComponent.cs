using OpenQA.Selenium;

namespace SauceDemo.Tests.Components;

public class ProductDetailsComponent
{
    private readonly IWebElement _root;

    public ProductDetailsComponent(IWebElement root)
    {
        _root = root;
    }

    #region Locators

    private By NameLocator => By.CssSelector("[data-test='inventory-item-name']");

    private By DescriptionLocator => By.CssSelector("[data-test='inventory-item-desc']");

    private By PriceLocator => By.CssSelector("[data-test='inventory-item-price']");

    private By ButtonLocator => By.CssSelector("button");

    #endregion

    #region Properties

    public string Name => _root.FindElement(NameLocator).Text;

    public string Description => _root.FindElement(DescriptionLocator).Text;

    public decimal Price => decimal.Parse(_root.FindElement(PriceLocator).Text.Replace("$", ""));

    public bool IsInCart => _root.FindElement(ButtonLocator).Text == "Remove";

    #endregion

    #region Actions

    public void AddToCart()
    {
        if (!IsInCart)
        {
            _root.FindElement(ButtonLocator).Click();
        }
    }

    public void RemoveFromCart()
    {
        if (IsInCart)
        {
            _root.FindElement(ButtonLocator).Click();
        }
    }

    #endregion
}
