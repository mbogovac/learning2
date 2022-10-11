

using NUnit.Framework;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using System;

namespace Selenium2.scenarios.login
{
    public class LoginEmptyFields
    {
        [OneTimeSetUp]
        public void Initialize()
        {
            ActionsOnPages.InitializeDriver();
        }

        [Test]
        public void EmptyUsernameAndPass()
        {
            ActionsOnPages.FillLoginForm(Config.Credentials.Invalid.Empty,
                                         Config.Credentials.Invalid.Empty);

            WebDriverWait wait = new WebDriverWait(Driver.driver, TimeSpan.FromSeconds(5));
            IWebElement ErrorMessage = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.CssSelector("#login-form > div.alert.alert-danger.col-md-12")));

            Assert.AreEqual("Empty username/password.", ErrorMessage.Text);
        }

        [Test]
        public void EmptyUsername()
        {
            ActionsOnPages.FillLoginForm(Config.Credentials.Invalid.Empty,
                                         Config.Credentials.Valid.Password);

            WebDriverWait wait = new WebDriverWait(Driver.driver, TimeSpan.FromSeconds(5));
            IWebElement ErrorMessage = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.CssSelector("#login-form > div.alert.alert-danger.col-md-12")));

            Assert.AreEqual("Empty username/password.", ErrorMessage.Text);
        }

        [Test]
        public void EmptyPassword()
        {
            ActionsOnPages.FillLoginForm(Config.Credentials.Valid.Username,
                                         Config.Credentials.Invalid.Empty);

            WebDriverWait wait = new WebDriverWait(Driver.driver, TimeSpan.FromSeconds(5));
            IWebElement ErrorMessage = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.CssSelector("#login-form > div.alert.alert-danger.col-md-12")));

            Assert.AreEqual("Empty username/password.", ErrorMessage.Text);
        }

        [OneTimeTearDown]
        public void CleanUp()
        {
            Driver.driver.Quit();
        }
    }
}
