using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SpecflowPages.Pages
{
    public class ShareSkillPage
    {       
            //click on the Main Menu links // Click ShareSkill button
            public void clickMainMenuOptions(string menuMainOptions)
            {
                var clickMenu = new ShareSkillPage();
                var barXpath = "//*[@class='nav-secondary']//a[text()[normalize-space(.)='" + menuMainOptions + "']]";
                IWebElement _menuClickoption = clickMenu.menuBarSkillShareOptions(barXpath);
                _menuClickoption.Click();

            }

            //function to find menu options 
            public IWebElement menuBarSkillShareOptions(string menuOptionLocator)
            {

                var toolMenu = Driver.webDriver.FindElement(By.XPath(menuOptionLocator));
                return toolMenu;

            }       

        public void clickTitleBox()
        {
            IWebElement titleBox = Driver.webDriver.FindElement(By.XPath("//*[@name='title']"));
            titleBox.Clear();
            titleBox.Click();
        }

        public void enterDetails(string title, string description, string category, string subCategory, string tags, string serviceType, string locationType, string skilltrade, string skillExchange,string credit, string workSamples, string active)
        {
            //Enter title
            IWebElement titleBox = Driver.webDriver.FindElement(By.XPath("//*[@name='title']"));
            titleBox.Click();
            titleBox.Clear();
            titleBox.SendKeys(title);

            //Enter Description
            IWebElement descriptionBox = Driver.webDriver.FindElement(By.XPath("//*[@name='description']"));
            descriptionBox.Click();
            descriptionBox.Clear();
            descriptionBox.SendKeys(title);

            //Select Category
            IWebElement categoryList = Driver.webDriver.FindElement(By.XPath("//*[@name='categoryId']"));
            IList<IWebElement> optionsCategory = categoryList.FindElements(By.TagName("option"));
            int optionCount = optionsCategory.Count();
            for (int i = 0; i < optionCount; i++)
            {
                if (optionsCategory[i].Text == category)
                {
                    optionsCategory[i].Click();
                }
            }
            //Select Subcategory
            IWebElement subCategoryList = Driver.webDriver.FindElement(By.XPath("//*[@name='subcategoryId']"));
            IList<IWebElement> optionsSubCategory = subCategoryList.FindElements(By.TagName("option"));
            int optionsSubCategoryCount = optionsSubCategory.Count();
            for (int i = 0; i < optionsSubCategoryCount; i++)
            {
                if (optionsSubCategory[i].Text == subCategory)
                {
                    optionsSubCategory[i].Click();
                }
            }

            //Enter tag
            IWebElement tagsBox = Driver.webDriver.FindElement(By.XPath("//*[@class='form-wrapper field  ']/div/div/div/input"));
            tagsBox.Click();
            tagsBox.Clear();
            tagsBox.SendKeys(tags);
            Driver.webDriver.FindElement(By.XPath("//*[@class='form-wrapper field  ']/div/div/div/input")).SendKeys(Keys.Enter);
           

            //Select Servicetype

            switch (serviceType)
            {
                case "Hourly basis service":

                    var radioST = Driver.webDriver.FindElement(By.XPath("//*[@class='ui form']/div[5]/div[2]/div[1]/div[1]/div/input"));
                    radioST.Click();
                    break;
                case "One-off service":
                    var radioST2 = Driver.webDriver.FindElement(By.XPath("//*[@class='ui form']/div[5]/div[2]/div[1]/div[2]/div/input"));
                    radioST2.Click();
                    break;
            }

            //Select Location type
            switch (locationType)
            {
                case "On-site":
                    var radioLT = Driver.webDriver.FindElement(By.XPath("//*[@class='ui form']/div[6]/div[2]/div/div[1]/div/input"));
                    radioLT.Click();
                    break;
                case "Online":
                    var radioLT2 = Driver.webDriver.FindElement(By.XPath("//*[@class='ui form']/div[6]/div[2]/div/div[2]/div/input"));
                    radioLT2.Click();
                    break;
            }

            //Select Skill Trade
            switch (skilltrade)
            {
                case "Skill-exchange":
                    var radioST = Driver.webDriver.FindElement(By.XPath("//*[@class='ui form']/div[8]/div[2]/div/div[1]/div/input"));
                    radioST.Click();
                    //Enter Skill Exchange
                    IWebElement skillExch = Driver.webDriver.FindElement(By.XPath("//*[@class='field error ']/div/div/div/div/input"));
                    skillExch.Click();
                    skillExch.Clear();
                    skillExch.SendKeys(skillExchange);
                    Driver.webDriver.FindElement(By.XPath("//*[@class='field error ']/div/div/div/div/input")).SendKeys(Keys.Enter);
                    break;
                case "Credit":
                    var radioST2 = Driver.webDriver.FindElement(By.XPath("//*[@class='ui form']/div[8]/div[2]/div/div[2]/div/input"));
                    radioST2.Click();
                    IWebElement creditEnter = Driver.webDriver.FindElement(By.XPath("//*[@class='field error ']/div/div/div/div/input"));
                    creditEnter.Click();
                    creditEnter.Clear();
                    creditEnter.SendKeys(credit);

                    break;
            }

            //Upload Work Samples
            string a = "C:\\Users\\Dell\\Desktop\\";
            string b = workSamples;

            Process.Start(a + "" + b);
            //Process.Start("C:\\Users\\Dell\\Desktop\\FileUpload.exe");

            //Select Active


            switch (active)
            {
                case "Active":
                    var radioA = Driver.webDriver.FindElement(By.XPath("//*[@class='ui form']/div[10]/div[2]/div/div[1]/div/input"));
                    radioA.Click();
                    break;
                case "Hidden":
                    var radioH = Driver.webDriver.FindElement(By.XPath("//*[@class='ui form']/div[10]/div[2]/div/div[2]/div/input"));
                    radioH.Click();
                    break;
            }
        }
            
    }
}
