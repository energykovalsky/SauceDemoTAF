# SauceDemo Test Automation Framework

A UI test automation framework for the **SauceDemo** application built with **C#**, **.NET**, **Selenium WebDriver**, and **NUnit**.

The project was developed as the final assignment for the **Automated Testing in .NET with Selenium WebDriver** course.

---

# Tested Application

https://www.saucedemo.com

---

# Technology Stack

- C#
- .NET 10
- Selenium WebDriver
- NUnit
- FluentAssertions
- Microsoft.Extensions.Configuration

---

# Supported Browsers

- Mozilla Firefox
- Microsoft Edge
- Google Chrome

The browser is configured in **appsettings.json**.

Example:

```json
"Browser": "Firefox"
```

---

# Framework Architecture

```text
                           Tests (NUnit)
                                 │
                                 ▼
                       Business Workflows
                                 │
                                 ▼
                        Page Objects (POM)
                                 │
                                 ▼
                Components & Shared Base Classes
                                 │
                                 ▼
                  Framework Infrastructure
                                 │
                                 ▼
                       Selenium WebDriver


Business Workflows
──────────────────────────────────────────────────────────────
• LoginWorkflow
• InventoryWorkflow
• ProductWorkflow
• CartWorkflow

Page Objects
──────────────────────────────────────────────────────────────
• LoginPage
• InventoryPage
• ProductPage
• CartPage

Components
──────────────────────────────────────────────────────────────
• HeaderComponent
• ProductCardComponent
• BasePage

Framework Infrastructure
──────────────────────────────────────────────────────────────
• DriverManager
• BrowserFactory
• BrowserOptionsFactory
• WaitService
• ConfigurationManager
• PageProvider
```

---

# Design Principles

The framework follows a layered architecture based on the following principles:

- Page Object Model (POM)
- Business Workflow layer
- Factory pattern
- Configuration-driven execution
- Explicit waits only (Implicit Wait = 0)
- Constructor Dependency Injection
- Separation of concerns

---

# Project Structure

```text
Business/
│
├── Models/
├── TestData/
└── Workflows/

Components/

Configuration/

Core/
├── Browsers/
├── Driver/
├── Factories/
└── Waits/

Pages/

Tests/

Utilities/
```

---

# Implemented Test Scenarios

## UC-1

Verify that the application displays an error message when attempting to log in without entering a password.

## UC-2

Verify successful login with valid credentials and successful navigation to the Inventory page.

## UC-3

Verify that a product can be added to the shopping cart.

Additionally, the framework contains several supplementary tests covering shopping cart behavior.

---

# Configuration

Framework settings are stored in:

```text
appsettings.json
```

Available settings:

```json
{
  "BaseUrl": "https://www.saucedemo.com",
  "Browser": "Firefox",
  "Headless": false,
  "TimeoutSeconds": 10
}
```

---

# Running Tests

Run all tests from the command line:

```bash
dotnet test
```

or execute them from **Visual Studio Test Explorer**.

---

# Design Decisions

This framework intentionally uses:

- Explicit waits
- Constructor Dependency Injection
- Page Object Model
- Business Workflows
- Browser Factory
- Configuration Manager
- Fluent Assertions

The project intentionally avoids unnecessary complexity such as IoC containers, external driver management libraries, or reporting frameworks in order to keep the solution simple, readable, maintainable, and appropriate for a junior-level automation framework while still demonstrating good architectural practices.

---

# Future Improvements

Possible enhancements include:

- Parallel cross-browser execution
- GitHub Actions / Azure DevOps CI pipeline
- Test reporting (Allure or ExtentReports)
- Screenshot capture on test failures
- Structured logging (Serilog)
- External test data sources
- Docker execution
- Selenium Grid support

---

# Author

**Andriy**