using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrameFromScratch.Modules
{
    public class SignInPage
    {
        private readonly IWebDriver driver;

        public SignInPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        IWebElement username => this.driver.FindElement(By.XPath("//input[@id='email']"));
        IWebElement password => this.driver.FindElement(By.XPath("//input[@id='passwd']"));
        IWebElement SignInTab => this.driver.FindElement(By.ClassName("login"));
        IWebElement SigninButton => this.driver.FindElement(By.Name("SubmitLogin"));

        IWebElement EmailAdress => this.driver.FindElement(By.Id("email_create"));

        IWebElement CreateAccountButton => this.driver.FindElement(By.Id("SubmitCreate"));

        public void GotoAutomationURL()
        {
            this.driver.Url = DataSettings.Settings.HostURL;
            this.driver.Manage().Window.Maximize();
        }

        public void QuitBrowser()
        {
            this.driver.Quit();
        }
        public void CreateNewAccount(string emailid)
        {
            SigninButton.Click();
            EmailAdress.Click();
            EmailAdress.Clear();
            EmailAdress.SendKeys(emailid);
            CreateAccountButton.Submit();

        }

        public void ClickOnSignInTab()
        {
            SignInTab.Click();
        }
        public void LoginIntoWebsite()
        {
            ClickOnSignInTab();
            username.SendKeys(DataSettings.Settings.UserName);
            password.SendKeys(DataSettings.Settings.Password);
            SigninButton.Click();
        }
    }
}
