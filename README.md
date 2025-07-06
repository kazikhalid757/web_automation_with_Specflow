# Tumblr Web Automation Testing Project

This project contains automated tests for the Tumblr website using SpecFlow, Selenium WebDriver, and NUnit.

## Project Structure

```
Specflow_webautomation--branch-main/
├── Features/                 # Gherkin feature files
│   └── Login.feature        # Login and navigation test scenarios
├── StepDefinitions/         # Step definition implementations
│   ├── Login.cs            # Login and navigation step definitions
│   └── WebTitle.cs         # Page title verification steps
├── PageObjects/            # Page Object Model classes
│   ├── LoginPage.cs        # Login page elements and actions
│   └── HomePage.cs         # Home page elements and actions
├── Support/                # Support classes and utilities
│   ├── BaseTest.cs         # Base test class with WebDriver setup
│   └── TestConfiguration.cs # Configuration management
├── appsettings.json        # Test configuration and data
├── allureConfig.json       # Allure reporting configuration
├── specflow.json           # SpecFlow configuration
├── Tumblr.csproj           # Project file
└── README.md               # This file
```

## Prerequisites

- .NET 6.0 SDK
- Visual Studio 2022 or VS Code
- Chrome browser (for Selenium WebDriver)

## Setup Instructions

1. **Clone the repository**
   ```bash
   git clone <repository-url>
   cd Specflow_webautomation--branch-main
   ```

2. **Restore NuGet packages**
   ```bash
   dotnet restore
   ```

3. **Update test credentials**
   - Open `appsettings.json`
   - Update the `TestData` section with your test credentials:
   ```json
   {
     "TestData": {
       "Email": "your-test-email@example.com",
       "Password": "your-test-password"
     }
   }
   ```

4. **Build the project**
   ```bash
   dotnet build
   ```

## Running Tests

### Run all tests
```bash
dotnet test
```

### Run specific test
```bash
dotnet test --filter "FullyQualifiedName~Login"
```

### Run with Allure reporting
```bash
dotnet test --logger "Allure"
```

## Test Scenarios

The project includes the following test scenarios:

1. **Login Verification**
   - Navigate to Tumblr
   - Click login button
   - Continue with email
   - Enter credentials
   - Verify successful login

2. **Navigation Tests**
   - Activity page navigation
   - Explore page navigation
   - Messages functionality
   - Inbox functionality
   - Account menu navigation
   - Likes page navigation

3. **Page Title Verification**
   - Verify page title is not null or empty

## Key Features

### Page Object Model
- **LoginPage**: Handles login form interactions
- **HomePage**: Manages post-login navigation and functionality

### Configuration Management
- Centralized configuration in `appsettings.json`
- Environment-specific settings support
- Secure credential management

### Base Test Class
- Automatic WebDriver setup and teardown
- Common wait utilities
- Chrome browser configuration

### Reporting
- Allure integration for detailed test reports
- SpecFlow LivingDoc support

## Best Practices Implemented

1. **Security**: No hardcoded credentials in source code
2. **Maintainability**: Page Object Model pattern
3. **Reliability**: Explicit waits and proper element handling
4. **Configuration**: External configuration management
5. **Clean Code**: Proper separation of concerns

## Troubleshooting

### Common Issues

1. **ChromeDriver not found**
   - Ensure Chrome browser is installed
   - Selenium WebDriver Manager will automatically download the appropriate driver

2. **Element not found errors**
   - Check if the XPath selectors are still valid
   - Tumblr may have updated their UI

3. **Test failures due to timing**
   - Adjust wait times in `appsettings.json`
   - Check network connectivity

### Debug Mode
To run tests in debug mode with slower execution:
```bash
dotnet test --logger "console;verbosity=detailed"
```

## Contributing

1. Follow the existing code structure
2. Use Page Object Model for new page interactions
3. Add appropriate wait conditions
4. Update configuration files for new test data
5. Add meaningful assertions with descriptive messages

## Dependencies

- **SpecFlow**: BDD framework
- **Selenium WebDriver**: Browser automation
- **NUnit**: Testing framework
- **Allure**: Test reporting
- **FluentAssertions**: Readable assertions
- **Microsoft.Extensions.Configuration**: Configuration management

## License

This project is for educational and testing purposes only. 