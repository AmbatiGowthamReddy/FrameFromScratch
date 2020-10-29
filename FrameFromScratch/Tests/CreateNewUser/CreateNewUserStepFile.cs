using FrameFromScratch.Tests.LoginValidations;
using Shouldly;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrameFromScratch.Tests.CreateNewUser
{   
    public class  CreateNewUserStepFile: LoginSteps
    {
        internal void I_click_on_create_new_user_button()
        {
            this.userLoginLayout.SignInPage.CreateNewAccount("Seleniukjkkkjjkkj45678912346@gmail.com");
        }

        internal void I_verify_the_Mr_and_Mrs_Radio_button_selection()
        {
            this.userLoginLayout.CreateNewUser.ClickOnMrRadioButton().ShouldBeTrue();
        }
    }
}
