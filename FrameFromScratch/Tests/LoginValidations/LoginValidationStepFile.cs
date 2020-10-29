using FrameFromScratch.AppSessions;
using FrameFromScratch.Layouts;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrameFromScratch.Tests.LoginValidations
{
    public class LoginValidationStepFile:LoginSteps
    {
        internal void I_login_with_valid_credentails()
        {
            this.userLoginLayout.SignInPage.LoginIntoWebsite();
        }

        internal void I_scroll_into_view_of_the_Product_and_click_on_add_to_product()
        {
            this.userLoginLayout.HomePage.SelectAProductAndClickOnAddCart(DataSettings.Settings.ProductName);
        }
    }
}
