using SpecflowPages.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace SpecflowTests.WebsiteTest
{
    [Binding]
    public class ShareSkill
    {

        [Given(@"User clicked on the '(.*)' button")]
        public void GivenUserClickedOnTheButton(string skillShare)
        {
            ShareSkillPage shareSkillObject = new ShareSkillPage();
            shareSkillObject.clickMainMenuOptions(skillShare);
          
        }

        [When(@"User enter the details (.*),(.*),(.*),(.*),(.*),(.*),(.*), (.*), (.*),(*),(.*),(.*)")]
        public void WhenUserEnterTheDetails(string title, string description, string category,string subCategory, string tags, string serviceType, string locationtype, string skillTrade, string skillExchange,string credit, string workSamples, string active)
        {
            ShareSkillPage shareSkillObject = new ShareSkillPage();
            shareSkillObject.enterDetails(title,description, category,subCategory,tags,serviceType,locationtype,skillTrade,skillExchange,workSamples,active);
            Thread.Sleep(10000);

            
        }

        [When(@"User enter the Available days")]
        public void WhenUserEnterTheAvailableDays()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"that (.*) skill should be added to user Manage Listing page")]
        public void ThenThatSkillShouldBeAddedToUserManageListingPage(string p0)
        {
            ScenarioContext.Current.Pending();
        }

    }
}
