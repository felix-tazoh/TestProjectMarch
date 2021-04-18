using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using TestProjectApril2021.Utilities;

namespace TestProjectApril2021.PageObject
{
    class DataDrivenWithExamplePage
    {
        public DataDrivenWithExamplePage()
        {
            driver = Hooks1.driver;
        }

        IWebDriver driver;

        IWebElement username => driver.FindElement(By.XPath("//input[@type='text']"));

        IWebElement email => driver.FindElement(By.XPath("//input[@placeholder='Email']"));

        IWebElement password => driver.FindElement(By.XPath("//input[@placeholder='Password']"));


        public void EnterUsername(string Username)
        {
            username.SendKeys(Username);
        }

        public void EnterEmail(string Email)
        {
            email.SendKeys(Email);
        }

        public void EnterPassword(string Password)
        {
            password.SendKeys(Password);
        }



















    }
}
