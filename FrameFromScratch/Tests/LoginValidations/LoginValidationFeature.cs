using FrameFromScratch.DataSettings;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestStack.BDDfy;

namespace FrameFromScratch.Tests.LoginValidations
{
    [TestClass]
    public class LoginValidationFeature : LoginValidationStepFile
    {
        [ClassInitialize]
        public static void ClassInitialize(Microsoft.VisualStudio.TestTools.UnitTesting.TestContext context)
        {
            Settings.Use(context);
        }

        [TestMethod]
        public void I_login_with_valid_credentails_in_web()
        {
            this.Given(_ => _.I_open_Automate_web_url())
                .And(_ => _.I_login_with_valid_credentails())
                .BDDfy();
        }

        [TestMethod]
        public void I_add_a_product_to_the_Cart_from_HomePage()
        {
            this.Given(_ => _.I_open_Automate_web_url())
                .When(_ => _.I_scroll_into_view_of_the_Product_and_click_on_add_to_product())
                .BDDfy();
        }
    }
}
