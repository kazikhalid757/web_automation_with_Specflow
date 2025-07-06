using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using Tumblr.Support;

namespace Tumblr.PageObjects
{
    public class LoginPage
    {
        private readonly IWebDriver _driver;
        private readonly WebDriverWait _wait;

        // Locators
        private readonly By _loginButton = By.XPath("//span[normalize-space()='Log in']");
        private readonly By _continueWithEmailButton = By.XPath("//button[normalize-space()='Continue with email']");
        private readonly By _emailField = By.XPath("//input[@placeholder='Email']");
        private readonly By _nextButton = By.XPath("//button[@aria-label='Next']");
        private readonly By _passwordField = By.XPath("//input[@placeholder='Password']");
        private readonly By _submitLoginButton = By.XPath("//button[@type='submit']//span[normalize-space()='Log in']");
        private readonly By _homePageNavigation = By.XPath("//nav[@class='NkkDk']");

        public LoginPage(IWebDriver driver, WebDriverWait wait)
        {
            _driver = driver;
            _wait = wait;
        }

        public void NavigateToLoginPage()
        {
            _driver.Navigate().GoToUrl(TestConfiguration.BaseUrl);
        }

        public void ClickLoginButton()
        {
            _wait.Until(driver => driver.FindElement(_loginButton)).Click();
        }

        public void ClickContinueWithEmail()
        {
            _wait.Until(driver => driver.FindElement(_continueWithEmailButton)).Click();
        }

        public void EnterEmail(string email)
        {
            _wait.Until(driver => driver.FindElement(_emailField)).SendKeys(email);
        }

        public void ClickNextButton()
        {
            _wait.Until(driver => driver.FindElement(_nextButton)).Click();
        }

        public void EnterPassword(string password)
        {
            _wait.Until(driver => driver.FindElement(_passwordField)).SendKeys(password);
        }

        public void ClickSubmitLogin()
        {
            _wait.Until(driver => driver.FindElement(_submitLoginButton)).Click();
        }

        public bool IsHomePageDisplayed()
        {
            try
            {
                return _wait.Until(driver => driver.FindElement(_homePageNavigation)).Displayed;
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
                return _wait.Until(driver => driver.FindElement(_continueWithEmailButton)).Displayed;
            }
            catch
            {
                return false;
            }
        }
    }
} 