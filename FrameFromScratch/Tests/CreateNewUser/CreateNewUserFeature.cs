using FrameFromScratch.DataSettings;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestContext = Microsoft.VisualStudio.TestTools.UnitTesting.TestContext;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestStack.BDDfy;

namespace FrameFromScratch.Tests.CreateNewUser
{
    [TestClass]
    public class CreateNewUserFeature : CreateNewUserStepFile
    {
        private static TestContext bingoTestContext;

        [ClassInitialize]
        public static void ClassInitialize(TestContext context)
        {
            Settings.Use(context);
            bingoTestContext = context;
        }

        [TestMethod]
        public void I_create_new_user_and_verify_Mr_Mrs_radio_selections()
        {
            this.Given(_ => _.I_open_Automate_web_url())
                .When(_ => _.I_click_on_SignIn_button())
                .Then(_ => _.I_click_on_create_new_user_button())
                .And(_ => _.I_verify_the_Mr_and_Mrs_Radio_button_selection())
                .BDDfy();

        }

        [TestCleanup]
        public void Close_Browser()
        {
            this.Given(_ => _.I_Get_Screenshot_when_test_failed(bingoTestContext))
            .Then(_ => _.I_quit_chrome_driver_instance())
            .BDDfy();
        }
    }
}
