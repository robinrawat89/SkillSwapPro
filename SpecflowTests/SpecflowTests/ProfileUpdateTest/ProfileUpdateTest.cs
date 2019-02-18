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
            
            //by using CommonMethods
            //CommonMethods.ElementVisible(Driver.webDriver, "XPath", "//*[@class='item']/button");

            //by using assertion
            IWebElement element = Driver.webDriver.FindElement(By.XPath("//*[@class='item']/button"));
            Assert.IsTrue(element.Displayed);
            Assert.IsTrue(element.Text.Contains("Sign Out"));

        }

        //Background Steps End

        //Add Languages to Profile
        [Given(@"User clicked on the '(.*)' tab under Profile page")]
        public void GivenUserClickedOnTheTabUnderProfilePage(string menuLanguage)
        {
            ProfilePage languageObject = new ProfilePage();
            languageObject.clickMenuOptions(menuLanguage);
        }

        
        [Given(@"User click on Add New button for '(.*)'")]
        public void GivenUserClickOnAddNewButtonFor(string addNew)
        {
            ProfilePage languageObject = new ProfilePage();
            languageObject.clickAddNew(addNew);
        }



        [When(@"User is able to add a new entry for Language with values (.*) and (.*)")]
        public void WhenUserIsAbleToAddANewEntryForLanguageWithValuesAnd(string language, string level)
        {
            ProfilePage languageObject = new ProfilePage();
            languageObject.addNewLanguage(language, level);

        }


        [Then(@"that (.*) language should be added to user profile")]
        public void ThenThatLanguageShouldBeAddedToUserProfile(string language)
        {
            ProfilePage languageObject = new ProfilePage();
            languageObject.rowPresent(language);
        }

        
        //Adding a New Skill

        [When(@"User add a new skill (.*) and (.*)")]
        public void WhenUserAddANewSkillAnd(string skill, string skillLevel)
        {
            ProfilePage skillObject = new ProfilePage();
            skillObject.addNewSkill(skill,skillLevel);
        }

        [Then(@"that (.*) skill should be added to user profile")]
        public void ThenThatSkillShouldBeAddedToUserProfile(string skill)
        {
            ProfilePage skillObject = new ProfilePage();
            skillObject.rowSkillPresent(skill);
        }

        //Adding New Education

        
        [When(@"User add a Education (.*), (.*),(.*),(.*) and (.*)")]
        public void WhenUserAddAEducationAnd(string college, string country, string title, string degree, string year)
        {
            ProfilePage educationObject = new ProfilePage();
            educationObject.addNewEducation(college, country, title, degree, year);
        }



        [Then(@"that (.*),(.*) education should be added to user profile")]
        public void ThenThatEducationShouldBeAddedToUserProfile(string college, string country)
        {
            ProfilePage educationObject = new ProfilePage();
            educationObject.rowEducationPresent(college, country);
            
        }

        //Adding new Certificate
        [When(@"User add a new (.*), (.*) and (.*)")]
        public void WhenUserAddANewAnd(string certificate, string certificateFrom, string year)
        {
            ProfilePage certificateObject = new ProfilePage();
            certificateObject.addNewCertificate(certificate, certificateFrom, year);
        }

        [Then(@"that (.*) certificate should be added to user profile")]
        public void ThenThatCertificateShouldBeAddedToUserProfile(string certificate)
        {
            ProfilePage certificateObject = new ProfilePage();
            certificateObject.rowCertificatePresent(certificate);
        }


    }
}
