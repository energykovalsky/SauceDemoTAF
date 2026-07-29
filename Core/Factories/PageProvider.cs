using OpenQA.Selenium;
using SauceDemo.Tests.Business.Workflows;
using SauceDemo.Tests.Core.Waits;
using SauceDemo.Tests.Pages;

namespace SauceDemo.Tests.Core.Factories;

public class PageProvider
{
    private readonly IWebDriver _driver;
    private readonly WaitService _wait;

    private LoginPage? _login;
    private InventoryPage? _inventory;
    private ProductPage? _product;
    private CartPage? _cart;

    private LoginWorkflow? _loginWorkflow;
    private InventoryWorkflow? _inventoryWorkflow;
    private ProductWorkflow? _productWorkflow;
    private CartWorkflow? _cartWorkflow;

    public PageProvider(
        IWebDriver driver,
        WaitService wait)
    {
        _driver = driver;
        _wait = wait;
    }

    #region Pages

    public LoginPage Login =>
        _login ??= new LoginPage(_driver, _wait);

    public InventoryPage Inventory =>
        _inventory ??= new InventoryPage(_driver, _wait);

    public ProductPage Product =>
        _product ??= new ProductPage(_driver, _wait);

    public CartPage Cart =>
        _cart ??= new CartPage(_driver, _wait);

    #endregion

    #region Workflows

    public LoginWorkflow LoginWorkflow =>
        _loginWorkflow ??= new LoginWorkflow(Login);

    public InventoryWorkflow InventoryWorkflow =>
        _inventoryWorkflow ??= new InventoryWorkflow(Inventory);

    public ProductWorkflow ProductWorkflow =>
        _productWorkflow ??= new ProductWorkflow(Product);

    public CartWorkflow CartWorkflow =>
        _cartWorkflow ??= new CartWorkflow(Cart);

    #endregion
}

//using OpenQA.Selenium;
//using SauceDemo.Tests.Business.Workflows;
//using SauceDemo.Tests.Core.Waits;
//using SauceDemo.Tests.Pages;

//namespace SauceDemo.Tests.Core.Factories;

//public class PageProvider
//{
//    private readonly IWebDriver _driver;
//    private readonly WaitService _wait;

//    public PageProvider(IWebDriver driver, WaitService wait)
//    {
//        _driver = driver;
//        _wait = wait;
//    }

//    #region Pages

//    public LoginPage Login => new(_driver, _wait);

//    public InventoryPage Inventory => new(_driver, _wait);

//    public ProductPage Product => new(_driver, _wait);

//    public CartPage Cart => new(_driver, _wait);

//    #endregion

//    #region Workflows

//    public LoginWorkflow LoginWorkflow => new(Login);

//    public InventoryWorkflow InventoryWorkflow => new(Inventory);

//    public ProductWorkflow ProductWorkflow => new(Product);

//    public CartWorkflow CartWorkflow => new(Cart);

//    #endregion
//}
