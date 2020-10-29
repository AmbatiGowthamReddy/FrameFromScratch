using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using FrameFromScratch.Utilities;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace FrameFromScratch.Modules
{
    public class HomePage
    {
        private readonly IWebDriver driver;
        CommonUtils commonUtils;
        Waits wait;

        public HomePage(IWebDriver driver)
        {
            this.driver = driver;
            commonUtils = new CommonUtils();
            wait = new Waits();
        }

        public IList<IWebElement> HomeFeatureElements => this.driver.FindElements(By.Id("homefeatured"));

        public void SelectAProductAndClickOnAddCart(string productName)
        {
            wait.WaitUntilElementPresent(driver, HomeFeatureElements[0]);
             IWebElement element = null;

            foreach (var item in HomeFeatureElements)
            {
                string GetTextOfProduct = item.Text.Split('\n')[0].TrimEnd('\r');

                if (GetTextOfProduct.Equals(productName))
                {
                    element = item;
                    Console.WriteLine(item.Text);
                    break;
                }

            }

            if (element != null)
            {
                //string xpath = "//div[@class='product-image-container']//parent::div";
                //IWebElement productLi = this.driver
                IWebElement productLi = this.driver.FindElement(By.XPath("//li[@class='ajax_block_product col-xs-12 col-sm-4 col-md-3 first-in-line first-item-of-tablet-line first-item-of-mobile-line']"));
                commonUtils.ScrollToView(driver, element);
                commonUtils.MoveToElement(driver, productLi);
                IWebElement AddToCart = driver.FindElement(By.XPath("//a[@class='button ajax_add_to_cart_button btn btn-default']/span"));
                AddToCart.Click();
            }


        }

    }
}
