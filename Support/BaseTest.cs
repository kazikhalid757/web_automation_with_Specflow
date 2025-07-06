using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using TechTalk.SpecFlow;

namespace Tumblr.Support
{
    public abstract class BaseTest
    {
        private static IWebDriver? _sharedDriver;
        private static WebDriverWait? _sharedWait;
        private static bool _isInitialized = false;

        protected IWebDriver? Driver => _sharedDriver;
        protected WebDriverWait? Wait => _sharedWait;

        [BeforeScenario]
        public virtual void Setup()
        {
            if (!_isInitialized)
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

                _sharedDriver = new ChromeDriver(options);
                _sharedDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(TestConfiguration.ImplicitWait);
                _sharedDriver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(TestConfiguration.PageLoadTimeout);
                _sharedDriver.Manage().Timeouts().AsynchronousJavaScript = TimeSpan.FromSeconds(30);
                _sharedDriver.Manage().Window.Maximize();

                _sharedWait = new WebDriverWait(_sharedDriver, TimeSpan.FromSeconds(TestConfiguration.ImplicitWait));
                _isInitialized = true;
            }
        }

        [AfterScenario]
        public void Teardown()
        {
            if (_isInitialized && _sharedDriver != null)
            {
                _sharedDriver.Quit();
                _sharedDriver.Dispose();
                _sharedDriver = null;
                _sharedWait = null;
                _isInitialized = false;
            }
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