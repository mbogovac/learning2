

using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;

namespace Selenium2.scenarios.login
{
    public class ValidLogin
    {
        [OneTimeSetUp]
        public void Initialize()
        {
            ActionsOnPages.InitializeDriver();
        }

        [Test]
        public void ValidUsernameAndPass()
        {
            ActionsOnPages.FillLoginForm(Config.Credentials.Valid.Username,
                                         Config.Credentials.Valid.Password);

            WebDriverWait wait = new WebDriverWait(Driver.driver, TimeSpan.FromSeconds(5));
            IWebElement ShopName = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.TagName("h1")));

            Assert.AreEqual("Shop Name", ShopName.Text);
        }

        [OneTimeTearDown]
        public void CleanUp()
        {
            Driver.driver.Quit();
        }
    }
}
