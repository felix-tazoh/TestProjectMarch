using System;
using System.Threading;
using TechTalk.SpecFlow;
using TestProjectApril2021.PageObject;

namespace TestProjectApril2021.StepDefinition
{
    [Binding]
    public class DataDrivenWithParameterSteps
    {
        DataDrivenWithParameterPage dataDrivenWithParameterPage;

        public DataDrivenWithParameterSteps()
        {
            dataDrivenWithParameterPage = new DataDrivenWithParameterPage();
        }

          
        
        
        
        
        
        [Given(@"I navigate to ""(.*)""")]
        public void GivenINavigateTo(string url)
        {
            dataDrivenWithParameterPage.NavigateToUrl(url);
        }
        
        [Given(@"I enter username ""(.*)""")]
        public void GivenIEnterUsername(string Username)
        {
            dataDrivenWithParameterPage.EnterUsername(Username);
        }
        
        [Given(@"I enter Email ""(.*)""")]
        public void GivenIEnterEmail(string Email)
        {
            dataDrivenWithParameterPage.EnterEmail(Email);
        }
        
        [Given(@"I enter password ""(.*)""")]
        public void GivenIEnterPassword(string Password)
        {
            Thread.Sleep(9000);
            dataDrivenWithParameterPage.EnterPassword(Password);
        }
    }
}
