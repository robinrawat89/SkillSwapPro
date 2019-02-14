using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        //function click on 
        public IWebElement menuBarOptions(string menuOptionLocator)
        {

            var toolMenu = Driver.webDriver.FindElement(By.XPath(menuOptionLocator));
            return toolMenu;

        }
        //Menu links functions

        public void clickAddNew()
        {
            Driver.TurnOnWait();
            //IWebElement addNew = Driver.webDriver.FindElement(By.XPath("//*[@class='right aligned']/div[1][text()[normalize-space(.)='Add New']]"));
            IWebElement addNew = Driver.webDriver.FindElement(By.XPath("//*[contains(@class,'active') and contains(@class, 'tab')]/div/div[2]/div/table/thead/tr/th[3]/div"));
            addNew.Click();
        }
    }
}
