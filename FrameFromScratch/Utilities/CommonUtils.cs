using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrameFromScratch.Utilities
{
    public class CommonUtils
    {

        public void ScrollToView(IWebDriver driver, IWebElement element)
        {
            // Scroll to the element and it will center it for interaction

            var js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("arguments[0].scrollIntoView({behavior: 'smooth', block: 'center'})", element);
        }

        public void MoveToElement(IWebDriver driver, IWebElement element)
        {
            Actions actions = new Actions(driver);
            actions.MoveToElement(element).Build().Perform();
            
        }

    }
}
