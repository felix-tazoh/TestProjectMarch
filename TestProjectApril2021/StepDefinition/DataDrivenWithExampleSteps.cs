using System;
using TechTalk.SpecFlow;
using TestProjectApril2021.PageObject;

namespace TestProjectApril2021.StepDefinition
{
    [Binding]
    public class DataDrivenWithExampleSteps
    {

        DataDrivenWithExamplePage dataDrivenWithExamplePage;

        public DataDrivenWithExampleSteps()
        {
            dataDrivenWithExamplePage = new DataDrivenWithExamplePage();
        }





        [Given(@"the user enter Username ""(.*)""")]
        public void GivenTheUserEnterUsername(string Username)
        {
            dataDrivenWithExamplePage.EnterUsername(Username);
        }
        
        [Given(@"the user enter Email ""(.*)""")]
        public void GivenTheUserEnterEmail(string Email)
        {
            dataDrivenWithExamplePage.EnterEmail(Email);
        }
        
        [Given(@"the user enter password ""(.*)""")]
        public void GivenTheUserEnterPassword(string Password)
        {
            dataDrivenWithExamplePage.EnterPassword(Password);
        }
    }
}
