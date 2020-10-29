using FrameFromScratch.Modules;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrameFromScratch.Layouts
{
    public class UserLoginLayout
    {
        private readonly IWebDriver driver;
        public UserLoginLayout(IWebDriver driver)
        {
            this.driver = driver;
        }

        public CreateNewUser CreateNewUser => new CreateNewUser(driver);

        public HomePage HomePage => new HomePage(driver);

        public SignInPage SignInPage => new SignInPage(driver);

    }
}
