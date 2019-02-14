using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using SpecflowPages;
using SpecflowPages.Pages;
using System;
using TechTalk.SpecFlow;


namespace SpecflowTests.ProfileUpdateTest.StepDefinitions
{
    //Background Steps
    [Binding]
    public class ProfileUpdateTest
    {
        [Given(@"User is using ""(.*)"" browser")]
        public void GivenUserIsUsingBrowser(string browser)
        {
            Driver.DriverInitialize(browser);
        }
        
        [When(@"User navigate to ""(.*)"" url")]
        public void WhenUserNavigateToUrl(string url)
        {
            Driver.webDriver.Navigate().GoToUrl(url);
        }
        
        [When(@"User enter valid credentials ""(.*)"" and ""(.*)""")]
        public void WhenUserEnterValidCredentialsAnd(string userName, string password)
        {
            LoginPage LoginObject = new LoginPage();
            LoginObject.LoginStep(userName, password);

        }
        
        [Then(@"User is able to Login")]
        public void ThenUserIsAbleToLogin()
        {
            Driver.TurnOnWait();
            IWebElement element = Driver.webDriver.FindElement(By.XPath("//*[@class='item']/button"));
           
            Assert.IsTrue(element.Displayed);
            Assert.IsTrue(element.Text.Contains("Sign Out"));
            //Assert.AreEqual(element.Text.ToLower(), "Sign Out".ToLower());
        }

        //Background Steps End


        //Add Languages to Profile
        [Given(@"User clicked on the '(.*)' tab under Profile page")]
        public void GivenUserClickedOnTheTabUnderProfilePage(string menuLanguage)
        {
            ProfilePage ProfileObject = new ProfilePage();
            ProfileObject.clickMenuOptions(menuLanguage);
        }

        //Click on AddNew Button
        [Given(@"User click on Add New button")]
        public void GivenUserClickOnAddNewButton()
        {
            ProfilePage ProfileObject = new ProfilePage();
            ProfileObject.clickAddNew();
        }


        [When(@"User is able to add a new entry for Language with values (.*) and (.*)")]
        public void WhenUserIsAbleToAddANewEntryForLanguageWithValuesAnd(string language, string level)
        {
            ScenarioContext.Current.Pending();
        }


        [Then(@"that language should be displayed on user profile listings")]
        public void ThenThatLanguageShouldBeDisplayedOnUserProfileListings()
        {
            ScenarioContext.Current.Pending();
        }
        //New Language Added
    }
}
