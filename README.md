# SauceDemo Test Automation Framework

A UI test automation framework for the **SauceDemo** application built with **C#**, **.NET 10**, **Selenium WebDriver**, and **NUnit**.

The project was developed as the final assignment for the **Automated Testing in .NET with Selenium WebDriver** course.

---

## Tested Application

https://www.saucedemo.com

---

## Technology Stack

- C#
- .NET 10
- Selenium WebDriver
- NUnit
- FluentAssertions
- Microsoft.Extensions.Configuration

---

## Supported Browsers

- Mozilla Firefox
- Microsoft Edge
- Google Chrome

The browser is configured in **appsettings.json**.

Example:

```json
{
  "TestSettings": {
    "Browser": "Firefox"
  }
}
```

---

## Framework Architecture

```text
+-----------------------------------------------------------+
|                       Tests (NUnit)                        |
+----------------------------+------------------------------+
                             │
                             ▼
+-----------------------------------------------------------+
|                    Business Workflows                      |
| LoginWorkflow | InventoryWorkflow | ProductWorkflow | Cart |
+----------------------------+------------------------------+
                             │
                             ▼
+-----------------------------------------------------------+
|                     Page Objects (POM)                     |
| LoginPage | InventoryPage | ProductPage | CartPage        |
+----------------------------+------------------------------+
                             │
                             ▼
+-----------------------------------------------------------+
|                 Components & BasePage                      |
| HeaderComponent | BasePage                                |
+----------------------------+------------------------------+
                             │
                             ▼
+-----------------------------------------------------------+
|                  Framework Infrastructure                  |
| WaitService | DriverManager | BrowserFactory              |
| BrowserOptionsFactory | ConfigurationManager              |
+----------------------------+------------------------------+
                             │
                             ▼
+-----------------------------------------------------------+
|                  Selenium WebDriver                        |
+-----------------------------------------------------------+
```

### Design Principles

The framework follows a layered architecture and applies the following design principles:

- Page Object Model (POM)
- Business Workflow layer
- Factory Pattern
- Configuration-driven execution
- Explicit waits only (Implicit Wait = 0)
- Constructor Dependency Injection
- Separation of Concerns

---

## Project Structure

```text
SauceDemo.Tests
│
├── Business
│   ├── Models
│   ├── TestData
│   └── Workflows
│
├── Components
│
├── Configuration
│
├── Core
│   ├── Browsers
│   ├── Driver
│   ├── Factories
│   └── Waits
│
├── Pages
│
├── Tests
│
└── Utilities
```

---

## Implemented Test Scenarios

### UC-1 – Login Validation

Verify that an error message is displayed when attempting to log in without entering a password.

### UC-2 – Successful Login

Verify that a standard user can successfully log in and that the Inventory page is displayed with the required UI elements.

The test verifies:

- Burger menu button
- "Swag Labs" application title
- Shopping cart icon
- Product sorting dropdown
- Product list

### UC-3 – Add Product to Shopping Cart

Verify that a product can be added to the shopping cart.

---

## Configuration

Framework settings are stored in:

```text
appsettings.json
```

Available settings:

| Setting | Description |
|---------|-------------|
| BaseUrl | Application URL |
| Browser | Firefox / Edge / Chrome |
| Headless | Run browser without UI |
| TimeoutSeconds | Explicit wait timeout |

Example:

```json
{
  "TestSettings": {
    "BaseUrl": "https://www.saucedemo.com",
    "Browser": "Firefox",
    "Headless": false,
    "TimeoutSeconds": 10
  }
}
```

---

## Running Tests

Run all tests from the command line:

```bash
dotnet test
```

Or execute tests using **Visual Studio Test Explorer**.

To run the tests in another browser, update the **Browser** value in **appsettings.json**.

---

## Design Decisions

The framework intentionally uses:

- Page Object Model
- Business Workflows
- Explicit waits only
- Constructor Dependency Injection
- Factory Pattern for browser creation
- Configuration-driven browser selection
- Centralized page initialization through `PageProvider`

The project intentionally avoids unnecessary complexity such as IoC containers, external driver management libraries, and reporting frameworks to keep the solution simple, maintainable, and appropriate for a junior-level automation framework while remaining extensible.

---

## Future Improvements

Possible future enhancements include:

- Parallel cross-browser execution
- CI/CD integration (GitHub Actions or Azure DevOps)
- Allure or ExtentReports integration
- Structured logging (Serilog / NLog)
- Automatic screenshots on test failures
- External data-driven testing
- Command-line browser selection
- Docker support

---

## Repository

```text
git clone https://github.com/<your-github-username>/SauceDemoTAF.git
```

---

## Author

**Andriy**