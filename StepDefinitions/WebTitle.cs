using NUnit.Framework;
using OpenQA.Selenium;
using TechTalk.SpecFlow;
using Tumblr.Support;

namespace Tumblr.StepDefinitions
{
    [Binding]
    public class WebTitle : BaseTest
    {
        private string? pageTitle;

        [Given(@"I am on the main page")]
        public void GivenIAmOnTheMainPage()
        {
            Driver!.Navigate().GoToUrl(TestConfiguration.BaseUrl);
        }

        [Then(@"verify if the page title should be as it is or not")]
        public void ThenVerifyIfThePageTitleShouldBeAsItIsOrNot()
        {
            pageTitle = Driver!.Title;
            Assert.IsNotNull(pageTitle, "Page title is null");
            Assert.IsFalse(string.IsNullOrWhiteSpace(pageTitle), "Page title is empty or whitespace");

            if (!string.IsNullOrWhiteSpace(pageTitle))
            {
                Console.WriteLine($"Page Title: {pageTitle}");
            }
        }
    }
}