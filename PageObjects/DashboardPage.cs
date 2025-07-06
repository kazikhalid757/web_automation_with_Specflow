using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using NUnit.Framework;

namespace Tumblr.PageObjects
{
    public class DashboardPage
    {
        private readonly IWebDriver _driver;
        private readonly WebDriverWait _wait;

        // Dashboard locators - you can update these based on actual rav.ai dashboard elements
        private readonly By _dashboardHeader = By.XPath("//h1[contains(text(), 'Dashboard') or contains(text(), 'Welcome')]");
        private readonly By _dashboardMenu = By.XPath("//nav[contains(@class, 'dashboard') or contains(@class, 'menu')]");
        private readonly By _dashboardContent = By.XPath("//div[contains(@class, 'dashboard') or contains(@class, 'content')]");
        private readonly By _userProfile = By.XPath("//div[contains(@class, 'profile') or contains(@class, 'user')]");
        private readonly By _logoutButton = By.XPath("//button[contains(text(), 'Logout') or contains(text(), 'Sign Out')]");

        public DashboardPage(IWebDriver driver, WebDriverWait wait)
        {
            _driver = driver;
            _wait = wait;
        }

        public bool IsDashboardHeaderDisplayed()
        {
            return IsElementDisplayed(_dashboardHeader);
        }

        public bool IsDashboardMenuDisplayed()
        {
            return IsElementDisplayed(_dashboardMenu);
        }

        public bool IsDashboardContentDisplayed()
        {
            return IsElementDisplayed(_dashboardContent);
        }

        public bool IsUserProfileDisplayed()
        {
            return IsElementDisplayed(_userProfile);
        }

        public bool IsLogoutButtonDisplayed()
        {
            return IsElementDisplayed(_logoutButton);
        }

        public void NavigateToDashboardSection()
        {
            // This method can be used to navigate to specific dashboard sections
            // For now, we'll just verify we're on the dashboard
            NUnit.Framework.Assert.IsTrue(IsDashboardHeaderDisplayed(), "Dashboard header should be displayed");
        }

        public bool VerifyDashboardElements()
        {
            // Check if all essential dashboard elements are present
            bool headerPresent = IsDashboardHeaderDisplayed();
            bool menuPresent = IsDashboardMenuDisplayed();
            bool contentPresent = IsDashboardContentDisplayed();
            bool profilePresent = IsUserProfileDisplayed();

            return headerPresent && menuPresent && contentPresent && profilePresent;
        }

        public bool VerifyDashboardFunctionality()
        {
            // This method can be expanded to test specific dashboard functionality
            // For now, we'll just verify basic elements are working
            try
            {
                // Check if we can interact with dashboard elements
                bool canInteract = IsDashboardHeaderDisplayed() && IsDashboardMenuDisplayed();
                
                // You can add more specific functionality tests here
                // For example: clicking menu items, checking data loading, etc.
                
                return canInteract;
            }
            catch
            {
                return false;
            }
        }

        private bool IsElementDisplayed(By locator)
        {
            try
            {
                return _wait.Until(driver => driver.FindElement(locator)).Displayed;
            }
            catch
            {
                return false;
            }
        }
    }
} 