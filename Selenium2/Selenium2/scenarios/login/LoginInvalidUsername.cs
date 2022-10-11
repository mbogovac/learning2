

using NUnit.Framework;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using System;

namespace Selenium2.scenarios.login
{
    public class LoginInvalidUsername
    {
        [OneTimeSetUp]
        public void Initialize()
        {
            ActionsOnPages.InitializeDriver();
        }

        [Test]
        public void InvalidUsername()
        {
            ActionsOnPages.FillLoginForm(Config.Credentials.Invalid.Username,
                                         Config.Credentials.Valid.Password);

            WebDriverWait wait = new WebDriverWait(Driver.driver, TimeSpan.FromSeconds(5));
            IWebElement ErrorMessage = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.CssSelector("#login-form > div.alert.alert-danger.col-md-12")));

            Assert.AreEqual("Incorrect username/password.", ErrorMessage.Text);
        }

        [OneTimeTearDown]
        public void CleanUp()
        {
            Driver.driver.Quit();
        }
    }
}
