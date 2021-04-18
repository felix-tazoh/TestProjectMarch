using System;
using TechTalk.SpecFlow;
using TestProjectApril2021.PageObject;
using System.Threading;
using NUnit.Framework;

namespace TestProjectApril2021.StepDefinition
{
    [Binding]
    public class RegistrationSteps
    {
        RegistrationPage registrationPage;

        public RegistrationSteps()
        {
            registrationPage = new RegistrationPage();
        }









        [Given(@"I navigate to website")]
        public void GivenINavigateToWebsite()
        {
            registrationPage.NavigateToWebsite();

        }
        
        [Given(@"I click on sign up button")]
        public void GivenIClickOnSignUpButton()
        {
            //Thread.Sleep(5000);
            registrationPage.ClickOnSignUpButton();
        }
        
        [Given(@"I enter username")]
        public void GivenIEnterUsername()
        {
            //Thread.Sleep(7000);
            registrationPage.EnterUsername();
        }
        
        [Given(@"I enter Email")]
        public void GivenIEnterEmail()
        {
            registrationPage.EnterEmail();
        }
        
        [Given(@"I enter password")]
        public void GivenIEnterPassword()
        {
            registrationPage.EnterPassword();
        }
                
        [When(@"I click on Sign up")]
        public void WhenIClickOnSignUp()
        {
            //Thread.Sleep(5000);
            registrationPage.ClickOnSignUp();
        }

        [Then(@"I should be able to sign up successfully")]
        public void ThenIShouldBeAbleToSignUpSuccessfully()
        {
            Thread.Sleep(9000);
            Assert.That(registrationPage.IsGlobalFeedDisplayed);
        }
    }
}
