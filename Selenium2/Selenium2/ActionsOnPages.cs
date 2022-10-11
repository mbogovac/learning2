

using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using Selenium2.pages;

namespace Selenium2
{
    public static class ActionsOnPages
    {
        public static void InitializeDriver()
        {
            Driver.driver = new ChromeDriver();
            Driver.driver.Navigate().GoToUrl(Config.BaseUrl);
        }

        public static void FillLoginForm(string username, string password)
        {
            LoginPage loginPage = new LoginPage();
            loginPage.UsernameField.Clear();
            loginPage.UsernameField.SendKeys(username);
            loginPage.PasswordField.Clear();
            loginPage.PasswordField.SendKeys(password);
            loginPage.TermsCheck.Click();

            SelectElement s = new SelectElement(loginPage.RoledropDown);
            s.SelectByText("Teacher");

            loginPage.SignIn.Click();

        }
    }
}
