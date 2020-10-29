using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrameFromScratch.Utilities
{
    public class Waits
    {
        public bool WaitUntilElementPresent(IWebDriver driver, IWebElement element, int timeSpan = 30)
        {

            var wait = new DefaultWait<IWebDriver>(driver)
            {
                Timeout = TimeSpan.FromSeconds(timeSpan),
                PollingInterval = TimeSpan.FromMilliseconds(250),
            };

            wait.Until(_ =>
            {
                try
                {
                    if (element.Displayed)
                    {
                        return true;
                    }
                    return false;
                }
                catch
                {
                    return false;
                }
            });

            return false;
        }
    }
}
