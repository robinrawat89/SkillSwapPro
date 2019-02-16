using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using SpecflowPages;
using SpecflowPages.Pages;
using System;
using TechTalk.SpecFlow;


namespace SpecflowTests.ProfileUpdateTest.StepDefinitions
{
    //Background Steps to Login into the applications
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
            
        }

        //Background Steps End


        //Add Languages to Profile
        [Given(@"User clicked on the '(.*)' tab under Profile page")]
        public void GivenUserClickedOnTheTabUnderProfilePage(string menuLanguage)
        {
            ProfilePage ProfileObject = new ProfilePage();
            ProfileObject.clickMenuOptions(menuLanguage);
        }

        
        [Given(@"User click on Add New button for '(.*)'")]
        public void GivenUserClickOnAddNewButtonFor(string addNew)
        {
            ProfilePage ProfileObject = new ProfilePage();
            ProfileObject.clickAddNew(addNew);
        }



        [When(@"User is able to add a new entry for Language with values (.*) and (.*)")]
        public void WhenUserIsAbleToAddANewEntryForLanguageWithValuesAnd(string language, string level)
        {
            ProfilePage ProfileObject = new ProfilePage();
            ProfileObject.addNewLanguage(language, level);

        }


        [Then(@"that (.*) language should be added to user profile")]
        public void ThenThatLanguageShouldBeAddedToUserProfile(string language)
        {
            ProfilePage ProfileObject = new ProfilePage();
            ProfileObject.countRows(language);
        }

        //New Language Added
    }
}
