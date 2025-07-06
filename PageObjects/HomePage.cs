using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace Tumblr.PageObjects
{
    public class HomePage
    {
        private readonly IWebDriver _driver;
        private readonly WebDriverWait _wait;

        // Locators
        private readonly By _activityButton = By.XPath("//span[normalize-space()='Activity']");
        private readonly By _exploreButton = By.XPath("//span[normalize-space()='Explore']");
        private readonly By _messagesButton = By.XPath("//span[normalize-space()='Messages']");
        private readonly By _inboxButton = By.XPath("//span[normalize-space()='Inbox']");
        private readonly By _accountButton = By.XPath("//span[normalize-space()='Account']");
        private readonly By _likesButton = By.XPath("//span[normalize-space()='Likes']");
        private readonly By _activityPage = By.XPath("//div[@role='tabpanel']");
        private readonly By _explorePage = By.XPath("//a[@class='wl0Ka sSq2h']");
        private readonly By _messagesBox = By.XPath("//div[@class='DxQ0f AzqQv P4LH6']");
        private readonly By _allMessagesLink = By.XPath("//a[normalize-space()='All Messages']");

        public HomePage(IWebDriver driver, WebDriverWait wait)
        {
            _driver = driver;
            _wait = wait;
        }

        public bool IsActivityButtonDisplayed()
        {
            return IsElementDisplayed(_activityButton);
        }

        public void ClickActivityButton()
        {
            _wait.Until(driver => driver.FindElement(_activityButton)).Click();
        }

        public bool IsActivityPageDisplayed()
        {
            return IsElementDisplayed(_activityPage);
        }

        public bool IsExploreButtonDisplayed()
        {
            return IsElementDisplayed(_exploreButton);
        }

        public void ClickExploreButton()
        {
            _wait.Until(driver => driver.FindElement(_exploreButton)).Click();
        }

        public bool IsExplorePageDisplayed()
        {
            return IsElementDisplayed(_explorePage);
        }

        public bool IsMessagesButtonDisplayed()
        {
            return IsElementDisplayed(_messagesButton);
        }

        public void ClickMessagesButton()
        {
            _wait.Until(driver => driver.FindElement(_messagesButton)).Click();
        }

        public bool IsMessagesBoxDisplayed()
        {
            return IsElementDisplayed(_messagesBox);
        }

        public bool IsInboxButtonDisplayed()
        {
            return IsElementDisplayed(_inboxButton);
        }

        public void ClickInboxButton()
        {
            _wait.Until(driver => driver.FindElement(_inboxButton)).Click();
        }

        public bool IsAllMessagesLinkDisplayed()
        {
            return IsElementDisplayed(_allMessagesLink);
        }

        public bool IsAccountButtonDisplayed()
        {
            return IsElementDisplayed(_accountButton);
        }

        public void ClickAccountButton()
        {
            _wait.Until(driver => driver.FindElement(_accountButton)).Click();
        }

        public bool IsLikesButtonDisplayed()
        {
            return IsElementDisplayed(_likesButton);
        }

        public void ClickLikesButton()
        {
            _wait.Until(driver => driver.FindElement(_likesButton)).Click();
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