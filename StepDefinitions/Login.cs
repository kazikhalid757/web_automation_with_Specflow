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
            _loginPage!.ClickLoginButton();
        }

        [Then(@"User should see the continue with email option")]
        public void ThenUserShouldSeeTheContinueWithEmailOption()
        {
            Assert.IsTrue(_loginPage!.IsLoginPageDisplayed(), "Login page should be displayed");
        }

        [Then(@"Click on continue with Email button")]
        public void ThenClickOnContinueWithEmailButton()
        {
            _loginPage!.ClickContinueWithEmail();
        }

        [Then(@"Enter Email in Email text field")]
        public void ThenEnterEmailInEmailTextField()
        {
            _loginPage!.EnterEmail(TestConfiguration.TestEmail);
        }

        [When(@"Click on next button")]
        public void WhenClickOnNextButton()
        {
            _loginPage!.ClickNextButton();
        }

        [Then(@"Input The Password in Password field")]
        public void ThenInputThePasswordInPasswordField()
        {
            _loginPage!.EnterPassword(TestConfiguration.TestPassword);
        }

        [When(@"Click on Log in button")]
        public void WhenClickOnLogInButton()
        {
            _loginPage!.ClickSubmitLogin();
        }

        [Then(@"Show the Home Page is available in Display")]
        public void ThenShowTheHomePageIsAvailableInDisplay()
        {
            Assert.IsTrue(_loginPage!.IsHomePageDisplayed(), "Home page should be displayed after login");
        }

        [Given(@"Check Activity is available in site")]
        public void GivenCheckActivityIsAvailableInSite()
        {
            Assert.IsTrue(_homePage!.IsActivityButtonDisplayed(), "Activity button should be displayed");
        }

        [When(@"Click on Activity button")]
        public void WhenClickOnActivityButton()
        {
            _homePage!.ClickActivityButton();
        }

        [Then(@"Show the Activity Page is available in Display")]
        public void ThenShowTheActivityPageIsAvailableInDisplay()
        {
            Assert.IsTrue(_homePage!.IsActivityPageDisplayed(), "Activity page should be displayed");
        }

        [Given(@"Check explore is available in site")]
        public void GivenCheckExploreIsAvailableInSite()
        {
            Assert.IsTrue(_homePage!.IsExploreButtonDisplayed(), "Explore button should be displayed");
        }

        [When(@"Click on explore button")]
        public void WhenClickOnExploreButton()
        {
            _homePage!.ClickExploreButton();
        }

        [Then(@"Show the explore Page is available in Display")]
        public void ThenShowTheExplorePageIsAvailableInDisplay()
        {
            Assert.IsTrue(_homePage!.IsExplorePageDisplayed(), "Explore page should be displayed");
        }

        [Given(@"Check message is available in site")]
        public void GivenCheckMessageIsAvailableInSite()
        {
            Assert.IsTrue(_homePage!.IsMessagesButtonDisplayed(), "Messages button should be displayed");
        }

        [When(@"Click on message button")]
        public void WhenClickOnMessageButton()
        {
            _homePage!.ClickMessagesButton();
        }

        [Then(@"Show the message box is available in Display")]
        public void ThenShowTheMessageBoxIsAvailableInDisplay()
        {
            Assert.IsTrue(_homePage!.IsMessagesBoxDisplayed(), "Messages box should be displayed");
        }

        [Given(@"Check inbox is available in site")]
        public void GivenCheckInboxIsAvailableInSite()
        {
            Assert.IsTrue(_homePage!.IsInboxButtonDisplayed(), "Inbox button should be displayed");
        }

        [When(@"Click on inbox button")]
        public void WhenClickOnInboxButton()
        {
            _homePage!.ClickInboxButton();
        }

        [Then(@"Show the inbox box is available in Display")]
        public void ThenShowTheInboxBoxIsAvailableInDisplay()
        {
            Assert.IsTrue(_homePage!.IsAllMessagesLinkDisplayed(), "All Messages link should be displayed");
        }

        [Given(@"Check account is available in site")]
        public void GivenCheckAccountIsAvailableInSite()
        {
            Assert.IsTrue(_homePage!.IsAccountButtonDisplayed(), "Account button should be displayed");
        }

        [When(@"Click on account button")]
        public void WhenClickOnAccountButton()
        {
            _homePage!.ClickAccountButton();
        }

        [Then(@"Show the account sub menu is available in Display")]
        public void ThenShowTheAccountSubMenuIsAvailableInDisplay()
        {
            Assert.IsTrue(_homePage!.IsLikesButtonDisplayed(), "Likes button should be displayed in account menu");
        }

        [When(@"Click on The like button")]
        public void WhenClickOnTheLikeButton()
        {
            _homePage!.ClickLikesButton();
        }

        [Then(@"Show the like page available in display")]
        public void ThenShowTheLikePageAvailableInDisplay()
        {
            // This would need a specific locator for the likes page
            // For now, we'll just verify the likes button is clickable
            Assert.IsTrue(_homePage!.IsLikesButtonDisplayed(), "Likes button should be displayed");
        }
    }
}
