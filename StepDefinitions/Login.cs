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
        private HomePage? _homePage;

        [BeforeScenario]
        public override void Setup()
        {
            // Call base Setup to initialize WebDriver
            base.Setup();
            // Then initialize page objects
            _loginPage = new LoginPage(Driver!, Wait!);
            _homePage = new HomePage(Driver!, Wait!);
        }

        [Given(@"Check login button is available below")]
        public void GivenCheckLoginButtonIsAvailableBelow()
        {
            _loginPage!.NavigateToLoginPage();
        }

        [When(@"Click On Login button")]
        public void WhenClickOnLoginButton()
        {
            _loginPage!.ClickSignInButton();
        }

        [Then(@"User should see the continue with email option")]
        public void ThenUserShouldSeeTheContinueWithEmailOption()
        {
            Assert.IsTrue(_loginPage!.IsLoginPageDisplayed(), "Login page should be displayed");
        }

        [Then(@"Enter Email in Email text field")]
        public void ThenEnterEmailInEmailTextField()
        {
            _loginPage!.EnterEmail(TestConfiguration.TestEmail);
        }

        [Then(@"Input The Password in Password field")]
        public void ThenInputThePasswordInPasswordField()
        {
            _loginPage!.EnterPassword(TestConfiguration.TestPassword);
        }

        [When(@"Click on Log in button")]
        public void WhenClickOnLogInButton()
        {
            _loginPage!.ClickSubmitButton();
        }

        [Then(@"Show the Home Page is available in Display")]
        public void ThenShowTheHomePageIsAvailableInDisplay()
        {
            Assert.IsTrue(_loginPage!.IsDashboardDisplayed(), "Dashboard should be displayed after login");
        }
    }
}
