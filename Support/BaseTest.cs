using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using TechTalk.SpecFlow;

namespace Tumblr.Support
{
    public abstract class BaseTest
    {
        protected IWebDriver? Driver { get; private set; }
        protected WebDriverWait? Wait { get; private set; }

        [BeforeScenario]
        public virtual void Setup()
        {
            var options = new ChromeOptions();
            options.AddArgument("--no-sandbox");
            options.AddArgument("--disable-dev-shm-usage");
            options.AddArgument("--disable-gpu");
            options.AddArgument("--window-size=1920,1080");
            options.AddArgument("--disable-web-security");
            options.AddArgument("--disable-features=VizDisplayCompositor");
            options.AddArgument("--disable-extensions");
            options.AddArgument("--disable-plugins");
            //options.AddArgument("--headless"); // Run in headless mode for faster execution

            Driver = new ChromeDriver(options);
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(TestConfiguration.ImplicitWait);
            Driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(TestConfiguration.PageLoadTimeout);
            Driver.Manage().Timeouts().AsynchronousJavaScript = TimeSpan.FromSeconds(30);
            Driver.Manage().Window.Maximize();

            Wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(TestConfiguration.ImplicitWait));
        }

        [AfterScenario]
        public void Teardown()
        {
            Driver?.Quit();
            Driver?.Dispose();
        }

        protected IWebElement WaitForElement(By locator)
        {
            return Wait!.Until(driver => driver.FindElement(locator));
        }

        protected bool IsElementDisplayed(By locator)
        {
            try
            {
                return WaitForElement(locator).Displayed;
            }
            catch
            {
                return false;
            }
        }
    }
} 