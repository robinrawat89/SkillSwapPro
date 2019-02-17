using OpenQA.Selenium;
using RelevantCodes.ExtentReports;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static SpecflowPages.CommonMethods;

namespace SpecflowPages.Pages
{
    public class ProfilePage
    {
        //click on the Menu links
        public void clickMenuOptions(string menuOptions)
        {
            var clickMenu = new ProfilePage();
            var barXpath = "//*[@class='ui top attached tabular menu']/a[text()[normalize-space(.)='" + menuOptions + "']]";
            IWebElement _menuClickoption = clickMenu.menuBarOptions(barXpath);
            _menuClickoption.Click();

        }

        //function to find menu options 
        public IWebElement menuBarOptions(string menuOptionLocator)
        {

            var toolMenu = Driver.webDriver.FindElement(By.XPath(menuOptionLocator));
            return toolMenu;

        }
        //Menu links functions

        //Click on Add New button yo enter the item into profile
        public void clickAddNew(string addNewItem)
        {
            switch (addNewItem)
            {
                case "Languages":
                case "Skills":
                    Driver.TurnOnWait();
                    IWebElement addNew = Driver.webDriver.FindElement(By.XPath("//*[contains(@class,'active') and contains(@class, 'tab')]/div/div[2]/div/table/thead/tr/th[3]/div"));
                    addNew.Click();
                    break;

                case "Education":
                    Driver.TurnOnWait();
                    IWebElement addNewEducation = Driver.webDriver.FindElement(By.XPath("//*[contains(@class,'active') and contains(@class, 'tab')]/div/div[2]/div/table/thead/tr/th[6]/div"));
                    addNewEducation.Click();
                    break;

                case "Certifications":
                    Driver.TurnOnWait();
                    IWebElement addNewCertifications = Driver.webDriver.FindElement(By.XPath("//*[contains(@class,'active') and contains(@class, 'tab')]/div/div[2]/div/table/thead/tr/th[4]/div"));
                    addNewCertifications.Click();

                    break;

            }

        }

        public void addNewLanguage(string language, string languageLevel)
        {
            //Enter value in Add Language field
            IWebElement addLanguageName = Driver.webDriver.FindElement(By.XPath("//*[contains(@class,'active') and contains(@class, 'tab')]/div/div[2]/div/div/div[1]/input"));
            addLanguageName.Clear();
            addLanguageName.Click();
            addLanguageName.SendKeys(language);

            //Select value for level
            IWebElement DropDownList = Driver.webDriver.FindElement(By.XPath("//*[contains(@class,'active') and contains(@class, 'tab')]/div/div[2]/div/div/div[2]//select"));
            IList<IWebElement> options = DropDownList.FindElements(By.TagName("option"));
            int optionCount = options.Count();
            for (int i = 0; i < optionCount; i++)
            {
                if (options[i].Text == languageLevel)
                {
                    options[i].Click();
                }
            }

            //Click Add Button after enter lanaguage and language level
            IWebElement clickAdd = Driver.webDriver.FindElement(By.XPath("//*[@class='six wide field']/input[1]"));
            clickAdd.Click();


        }

        public void rowPresent(string language)
        {

            bool languageFound = false;
            IWebElement tableElement = Driver.webDriver.FindElement(By.XPath("//*[contains(@class,'active') and contains(@class, 'tab')]/div/div[2]/div/table"));
            IList<IWebElement> tableRow = tableElement.FindElements(By.TagName("td"));

            foreach (IWebElement row in tableRow)
            {
                var p = row.Text;
                if (row.Text.Contains(language))
                {
                    languageFound = true;
                    SaveScreenShotClass.SaveScreenshot(Driver.webDriver, "LanguageAdded");
                    //CommonMethods.test.Log(LogStatus.Pass, "Test Passed, Added a Language Successfully");

                    break;
                }
                else;

                languageFound = false;
                SaveScreenShotClass.SaveScreenshot(Driver.webDriver, "LanguageNotAdded");
                //CommonMethods.test.Log(LogStatus.Fail, "Test Failed, Failed to Add a Language Successfully");


            }

        }

        public void addNewSkill(string skill, string skillLevel)
        {
            //Enter value in Add Language field
            IWebElement addSkill = Driver.webDriver.FindElement(By.XPath("//*[contains(@class,'active') and contains(@class, 'tab')]/div/div[2]/div/div/div[1]/input"));
            addSkill.Clear();
            addSkill.Click();
            addSkill.SendKeys(skill);

            //Select value for level
            IWebElement DropDownList = Driver.webDriver.FindElement(By.XPath("//*[contains(@class,'active') and contains(@class, 'tab')]/div/div[2]/div/div/div[2]//select"));
            IList<IWebElement> options = DropDownList.FindElements(By.TagName("option"));
            int optionCount = options.Count();
            for (int i = 0; i < optionCount; i++)
            {
                if (options[i].Text == skillLevel)
                {
                    options[i].Click();
                }

            }

            //Click Add Button after enter skill and skill level
            IWebElement clickAdd = Driver.webDriver.FindElement(By.XPath("//*[@class='buttons-wrapper']/input[1]"));
            clickAdd.Click();
        }

        //Verify Skill is added
        public void rowSkillPresent(string skill)
        {

            bool skillPresent = false;
            IWebElement tableElement = Driver.webDriver.FindElement(By.XPath("//*[contains(@class,'active') and contains(@class, 'tab')]/div/div[2]/div/table"));
            IList<IWebElement> tableRow = tableElement.FindElements(By.TagName("td"));

            foreach (IWebElement row in tableRow)
            {
                var p = row.Text;
                if (row.Text.Contains(skill))
                {
                    skillPresent = true;
                    SaveScreenShotClass.SaveScreenshot(Driver.webDriver, "SkillAdded");
                    //CommonMethods.test.Log(LogStatus.Pass, "Test Passed, Added a Language Successfully");

                    break;
                }
                else;

                skillPresent = false;
                SaveScreenShotClass.SaveScreenshot(Driver.webDriver, "SkillNotAdded");
                //CommonMethods.test.Log(LogStatus.Fail, "Test Failed, Failed to Add a Language Successfully");


            }

        }


    }
}
