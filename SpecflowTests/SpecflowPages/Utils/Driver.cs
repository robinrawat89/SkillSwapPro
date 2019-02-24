using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecflowPages
{
    public class Driver
    {
        //Initialize the browser
        public static IWebDriver webDriver { get; set; }

        public static void DriverInitialize(string browser)
        {
            switch (browser)
            {
                case "Chrome":
                    webDriver = new ChromeDriver();
                    break;
                case "IE":
                    webDriver = new InternetExplorerDriver();
                    break;
                case "Firefox":
                    webDriver = new FirefoxDriver();
                    break;
            }
            //Maximise the window
            webDriver.Manage().Window.Maximize();
            TurnOnWait();
        }

        public static string BaseUrl
        {
            get{ return ConstantUtils.Url; }
        }
           
        
        //Implicit Wait
        public static void TurnOnWait()
        {
            webDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

        }

        //Navigate to Website URL
        public static void NavigateUrl(string url)
        {
            webDriver.Navigate().GoToUrl(url);
        }

        //Close the browser
        public static void Close()
        {
            webDriver.Close();
        }

    }
}
