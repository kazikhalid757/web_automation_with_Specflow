using OpenQA.Selenium;
using TechTalk.SpecFlow;
using NUnit.Framework;
using Tumblr.Support;
using Tumblr.PageObjects;

namespace Tumblr.StepDefinitions
{
    [Binding]
    public class Login : BaseTest
    {
        private LoginPage? _loginPage;
        private DashboardPage? _dashboardPage;

        private void InitializePages()
        {
            if (_loginPage == null)
            {
                _loginPage = new LoginPage(Driver!, Wait!);
                _dashboardPage = new DashboardPage(Driver!, Wait!);
            }
        }

        [Given(@"Check login button is available below")]
        public void GivenCheckLoginButtonIsAvailableBelow()
        {
            InitializePages();
            _loginPage!.NavigateToLoginPage();
        }

        [When(@"Click On Login button")]
        public void WhenClickOnLoginButton()
        {
            InitializePages();
            _loginPage!.ClickSignInButton();
        }

        [Then(@"User should see the continue with email option")]
        public void ThenUserShouldSeeTheContinueWithEmailOption()
        {
            InitializePages();
            Assert.IsTrue(_loginPage!.IsLoginPageDisplayed(), "Login page should be displayed");
        }

        [Then(@"Enter Email in Email text field")]
        public void ThenEnterEmailInEmailTextField()
        {
            InitializePages();
            _loginPage!.EnterEmail(TestConfiguration.TestEmail);
        }

        [Then(@"Input The Password in Password field")]
        public void ThenInputThePasswordInPasswordField()
        {
            InitializePages();
            _loginPage!.EnterPassword(TestConfiguration.TestPassword);
        }

        [When(@"Click on Log in button")]
        public void WhenClickOnLogInButton()
        {
            InitializePages();
            _loginPage!.ClickSubmitButton();
        }

        [Then(@"Show the Home Page is available in Display")]
        public void ThenShowTheHomePageIsAvailableInDisplay()
        {
            InitializePages();
            Assert.IsTrue(_loginPage!.IsDashboardDisplayed(), "Dashboard should be displayed after login");
        }

        [Given(@"Check dashboard page is loaded properly")]
        public void GivenCheckDashboardPageIsLoadedProperly()
        {
            InitializePages();
            Assert.IsTrue(_dashboardPage!.IsDashboardHeaderDisplayed(), "Dashboard page should be loaded properly");
        }

        [When(@"Navigate to dashboard section")]
        public void WhenNavigateToDashboardSection()
        {
            InitializePages();
            _dashboardPage!.NavigateToDashboardSection();
        }

        [Then(@"Verify dashboard elements are displayed")]
        public void ThenVerifyDashboardElementsAreDisplayed()
        {
            InitializePages();
            Assert.IsTrue(_dashboardPage!.VerifyDashboardElements(), "Dashboard elements should be displayed");
        }

        [Then(@"Verify dashboard functionality works correctly")]
        public void ThenVerifyDashboardFunctionalityWorksCorrectly()
        {
            InitializePages();
            Assert.IsTrue(_dashboardPage!.VerifyDashboardFunctionality(), "Dashboard functionality should work correctly");
        }
    }
}
