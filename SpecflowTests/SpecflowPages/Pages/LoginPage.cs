using OpenQA.Selenium;
using RelevantCodes.ExtentReports;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static SpecflowPages.CommonMethods;

namespace SpecflowPages.Pages
{
  public class LoginPage
    {
        public void LoginStep(string username, string password)
        {
            //Enter Url

            //Click on Login Link
            Driver.webDriver.FindElement(By.XPath("//*[@class='ui secondary menu inverted']/div/a")).Click();
            Driver.TurnOnWait();


            Driver.webDriver.SwitchTo().Window(Driver.webDriver.WindowHandles.Last());

            //Enter Username
            IWebElement UserName = Driver.webDriver.FindElement(By.Name("email"));
            UserName.Click();
            UserName.Clear();
            UserName.SendKeys(username);

            //Enter password
            IWebElement passWord = Driver.webDriver.FindElement(By.Name("password"));
            passWord.Click();
            passWord.Clear();
            passWord.SendKeys(password);
            
            //Click on Login Button
            Driver.webDriver.FindElement(By.XPath("//*[@class='fluid ui teal button']")).Click();


            //string msg = "Add New Job";
            //string Actualmsg = Driver.driver.FindElement(By.XPath("//*[@id='addnewjob']")).Text;

            //if (msg == Actualmsg)
            //{
            //Console.WriteLine("Test Passed");
            //CommonMethods.ExtentReports();
            //Thread.Sleep(500);
            //test = CommonMethods.extent.StartTest("Login with valid data");
            //Thread.Sleep(1000);
            //CommonMethods.test.Log(LogStatus.Pass, "Test Passed");
            //SaveScreenShotClass.SaveScreenshot(Driver.driver, "HomePage");
            //}
            //else
            //{
            //Console.WriteLine("Test Failed");
            //CommonMethods.test.Log(LogStatus.Fail, "Test Failed");
            //}
        }

    }
}
