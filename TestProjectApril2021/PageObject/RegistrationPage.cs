using System;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium;
using System.Collections.Generic;
using System.Text;
using TestProjectApril2021.Utilities;

namespace TestProjectApril2021.PageObject
{
    class RegistrationPage
    {
        public RegistrationPage()
        {
            driver = Hooks1.driver;
        }

        IWebDriver driver;

      
        IWebElement signUp => driver.FindElement(By.XPath("(//a[@class='nav-link'])[2]"));

        IWebElement username => driver.FindElement(By.XPath("//input[@type='text']"));

        IWebElement email => driver.FindElement(By.XPath("//input[@placeholder='Email']"));

        IWebElement password => driver.FindElement(By.XPath("//input[@placeholder='Password']"));

        IWebElement signUpButton => driver.FindElement(By.XPath("//button[text()='Sign up']"));

        IWebElement globalFeed => driver.FindElement(By.XPath("(//a[@class='nav-link'])[5]"));



        public void NavigateToWebsite()
        {
            driver.Navigate().GoToUrl("http://angularjs.realworld.io/#/");
        }

        public void ClickOnSignUpButton()
        {
            signUp.Click();
        }

        public void EnterUsername()
        {
            Random randomGenerator = new Random();
            int randomInt = randomGenerator.Next(1000);
            username.SendKeys("felix" + randomInt);
            //username.SendKeys("felixtt24");
        }

     
        public void EnterEmail()
        {
            Random randomGenerator = new Random();
            int randomInt = randomGenerator.Next(1000);
            email.SendKeys("demo" + randomInt + "@gmail.com");
            //email.SendKeys("demo24@example.com");
        }

        public void EnterPassword()
        {
            password.SendKeys("PasswordSecure");
        }

        public void ClickOnSignUp()
        {
            signUpButton.Click();
        }

        public bool IsGlobalFeedDisplayed()
        {
            return globalFeed.Displayed;
        }
    }
}
