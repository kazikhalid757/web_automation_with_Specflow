using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using Tumblr.Support;

namespace Tumblr.PageObjects
{
    public class LoginPage
    {
        private readonly IWebDriver _driver;
        private readonly WebDriverWait _wait;

        // Updated Locators for rav.ai application
        private readonly By _signInButton = By.XPath("//button[@class='email__button']");
        private readonly By _emailField = By.XPath("//input[@placeholder='Email']");
        private readonly By _passwordField = By.XPath("//input[@placeholder='Password']");
        private readonly By _submitButton = By.XPath("//button[@type='submit']");
        private readonly By _dashboardPage = By.XPath("//span[normalize-space()='Dashboard']");

        public LoginPage(IWebDriver driver, WebDriverWait wait)
        {
            _driver = driver;
            _wait = wait;
        }

        public void NavigateToLoginPage()
        {
            _driver.Navigate().GoToUrl(TestConfiguration.BaseUrl);
        }

        public void ClickSignInButton()
        {
            _wait.Until(driver => driver.FindElement(_signInButton)).Click();
        }

        public void EnterEmail(string email)
        {
            _wait.Until(driver => driver.FindElement(_emailField)).SendKeys(email);
        }

        public void EnterPassword(string password)
        {
            _wait.Until(driver => driver.FindElement(_passwordField)).SendKeys(password);
        }

        public void ClickSubmitButton()
        {
            _wait.Until(driver => driver.FindElement(_submitButton)).Click();
        }

        public bool IsDashboardDisplayed()
        {
            try
            {
                return _wait.Until(driver => driver.FindElement(_dashboardPage)).Displayed;
            }
            catch
            {
                return false;
            }
        }

        public bool IsLoginPageDisplayed()
        {
            try
            {
                return _wait.Until(driver => driver.FindElement(_emailField)).Displayed;
            }
            catch
            {
                return false;
            }
        }
    }
} 