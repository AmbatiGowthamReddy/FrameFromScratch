using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrameFromScratch.Logs
{
    public class Screenshots
    {
        private readonly IWebDriver driver;
        public Screenshots(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void TakeScreenshotIfFails(TestContext testContex)
        {
            if (testContex.CurrentTestOutcome == UnitTestOutcome.Failed)
            {
                Screenshot screenshot = ((ITakesScreenshot)driver).GetScreenshot();
                screenshot.SaveAsFile(testContex.TestName, ScreenshotImageFormat.Jpeg);
            }

        }

    }
}
