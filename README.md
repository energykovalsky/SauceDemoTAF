# SauceDemo Test Automation Framework

A UI test automation framework for the SauceDemo application built with **C#**, **.NET**, **Selenium WebDriver**, and **NUnit**.

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

- Firefox
- Microsoft Edge
- Google Chrome

The browser is configured in `appsettings.json`.

Example:

```json
"Browser": "Firefox"
```

---

# Project Architecture

The framework follows a layered architecture.

```
Tests
    │
    ▼
Workflows
    │
    ▼
Page Objects
    │
    ▼
Components
    │
    ▼
Framework Services
```

Main principles used:

- Page Object Model (POM)
- Workflow layer for business actions
- Factory pattern
- Configuration-driven execution
- Explicit waits only (Implicit Wait = 0)
- Constructor Dependency Injection

---

# Project Structure

```
Business/
    Models/
    TestData/
    Workflows/

Components/

Configuration/

Core/
    Browsers/
    Driver/
    Factories/
    Waits/

Pages/

Tests/

Utilities/
```

---

# Implemented Test Scenarios

## UC-1

Verify that the application displays an error message when attempting to log in without a password.

## UC-2

Verify successful login with valid credentials and successful navigation to the Inventory page.

## UC-3

Verify that a product can be added to the shopping cart.

---

# Configuration

Framework settings are stored in:

```
appsettings.json
```

Available settings:

- BaseUrl
- Browser
- Headless
- TimeoutSeconds

---

# Running Tests

Run all tests:

```
dotnet test
```

Or execute tests from Visual Studio Test Explorer.

---

# Design Decisions

The framework intentionally uses:

- Explicit waits
- Constructor Dependency Injection
- Page Object Model
- Business Workflows
- Browser Factory
- Configuration Manager

The project avoids unnecessary complexity such as IoC containers or external driver management libraries to keep the solution simple, maintainable, and suitable for a junior-level automation framework.

---

# Future Improvements

Possible future enhancements:

- Parallel cross-browser execution
- CI/CD integration (GitHub Actions or Azure DevOps)
- Reporting (ExtentReports or Allure)
- Logging framework integration
- Screenshot capture on test failure
- Data-driven testing from external sources

---

# Author

Andriy