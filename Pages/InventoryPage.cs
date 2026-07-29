using OpenQA.Selenium;
using SauceDemo.Tests.Business.Models;
using SauceDemo.Tests.Components;
using SauceDemo.Tests.Core.Waits;

namespace SauceDemo.Tests.Pages;

public class InventoryPage : BasePage
{
    #region Locators

    private readonly By _title =
        By.CssSelector("[data-test='title']");

    private readonly By _sortingDropdown =
        By.CssSelector("[data-test='product-sort-container']");

    private readonly By _inventoryItems =
        By.CssSelector("[data-test='inventory-item']");

    #endregion

    #region Constructor

    public InventoryPage(
        IWebDriver driver,
        WaitService wait)
        : base(driver, wait)
    {
    }

    #endregion

    #region State

    public bool IsLoaded()
    {
        Wait.UntilVisible(_title);
        Wait.UntilVisible(_sortingDropdown);
        Wait.UntilVisible(_inventoryItems);

        return
            IsTitleDisplayed() &&
            Header.IsMenuButtonDisplayed() &&
            Header.IsCartDisplayed() &&
            IsSortingDisplayed() &&
            HasProducts();
    }

    public bool IsTitleDisplayed()
    {
        return Find(_title).Displayed;
    }

    public bool IsSortingDisplayed()
    {
        return Find(_sortingDropdown).Displayed;
    }

    public bool HasProducts()
    {
        Wait.UntilVisible(_inventoryItems);
        return GetProductsCount() > 0;
    }

    #endregion

    #region Getters

    public string GetPageTitle()
    {
        return GetText(_title);
    }

    public int GetProductsCount()
    {
        Wait.UntilVisible(_inventoryItems);
        return Driver.FindElements(_inventoryItems).Count;
    }

    public IReadOnlyCollection<ProductCardComponent> GetProducts()
    {
        Wait.UntilVisible(_inventoryItems);

        return Driver
            .FindElements(_inventoryItems)
            .Select(item => new ProductCardComponent(item))
            .ToList();
    }

    public ProductCardComponent GetProduct(Product product)
    {
        return GetProducts()
            .First(card => card.Name == product.Name);
    }

    #endregion
}