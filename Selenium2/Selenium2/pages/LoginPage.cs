

using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace Selenium2.pages
{
    public class LoginPage
    {
        public LoginPage()
        {
            PageFactory.InitElements(Driver.driver, this);
        }

        [FindsBy(How = How.Id, Using = "username")]
        public IWebElement UsernameField { get; set; }

        [FindsBy(How = How.Id, Using = "password")]
        public IWebElement PasswordField { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#login-form > div:nth-child(5) > select")]
        public IWebElement RoledropDown { get; set; }

        [FindsBy(How = How.Id, Using = "terms")]
        public IWebElement TermsCheck { get; set; }

        [FindsBy(How = How.Id, Using = "signInBtn")]
        public IWebElement SignIn { get; set; }
    }
}
