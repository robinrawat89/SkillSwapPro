﻿using RelevantCodes.ExtentReports;
using SpecflowPages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using static SpecflowPages.CommonMethods;

namespace SpecflowTests.Utils
{
    public class Start : Driver
    {
        [BeforeScenario]
        public void SetUp()
        {
                  
                      
        }

        [AfterScenario]
        public void TearDown()
        {
            

            Thread.Sleep(500);
            // Screenshot
            string img = SaveScreenShotClass.SaveScreenshot(Driver.webDriver, "Report");
            test.Log(LogStatus.Info, "Snapshot below: " + test.AddScreenCapture(img));

            // end test. (Reports)
            CommonMethods.extent.EndTest(CommonMethods.test);

            // calling Flush writes everything to the log file (Reports)
            CommonMethods.extent.Flush();

            //Close the browser
            Close();

            Driver.webDriver.Close();
        }

    }
}