using FrameFromScratch.AppSessions;
using FrameFromScratch.Layouts;
using FrameFromScratch.Logs;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrameFromScratch.Tests.LoginValidations
{
    public class LoginSteps
    {
        public IWebDriver driver;
        public UserLoginLayout userLoginLayout;

        internal void I_open_Automate_web_url()
        {
            var session = new WebDriverSession();
            driver = session.driver;
            this.userLoginLayout = new UserLoginLayout(session.driver);
            this.userLoginLayout.SignInPage.GotoAutomationURL();
        }

        internal void I_click_on_SignIn_button()
        {
            this.userLoginLayout.SignInPage.ClickOnSignInTab();
        }

        internal void I_quit_chrome_driver_instance()
        {
            this.userLoginLayout.SignInPage.QuitBrowser();
        }

        internal void I_Get_Screenshot_when_test_failed(TestContext testContext)
        {
            Screenshots ss = new Screenshots(driver);
            ss.TakeScreenshotIfFails(testContext);
        }
    }
}
