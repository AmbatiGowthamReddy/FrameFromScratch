using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrameFromScratch.Modules
{
    public class CreateNewUser
    {
        private readonly IWebDriver driver;
        public CreateNewUser(IWebDriver driver)
        {
            this.driver = driver;
        }

        public IWebElement Your_per_info => this.driver.FindElement(By.XPath("//h3[contains(text(),'Your personal information')]"));

        public IWebElement Mr_Button => this.driver.FindElement(By.CssSelector("#id_gender1"));

        public IWebElement Mrs_Button => this.driver.FindElement(By.CssSelector("#id_gender2"));

        public IWebElement FirstName => this.driver.FindElement(By.XPath("//input[@id='customer_firstname']"));

        public IWebElement LastName => this.driver.FindElement(By.XPath("//input[@id='customer_lastname']"));

        public IWebElement Email => this.driver.FindElement(By.XPath("//input[@id='email']"));

        public IWebElement Password => this.driver.FindElement(By.XPath("//input[@id='passwd']"));

        public IWebElement Dob_Days => this.driver.FindElement(By.XPath("//select[@id='days']"));

        public IWebElement Dob_Month => this.driver.FindElement(By.XPath("//select[@id='months']"));

        public IWebElement Dob_Year => this.driver.FindElement(By.XPath("//select[@id='years']"));

        public IWebElement Check_SignUp => this.driver.FindElement(By.XPath("//input[@id='newsletter']"));

        public IWebElement Check_Receive => this.driver.FindElement(By.XPath("//input[@id='optin']"));

        public IWebElement Addr_FirstName => this.driver.FindElement(By.XPath("//input[@id='firstname']"));

        public IWebElement Addr_LastName => this.driver.FindElement(By.XPath("//input[@id='lastname']"));

        public IWebElement Company => this.driver.FindElement(By.XPath("//input[@id='company']"));

        public IWebElement Address_Line1 => this.driver.FindElement(By.CssSelector("#address1"));

        public IWebElement Address_Line2 => this.driver.FindElement(By.CssSelector("#address2"));

        public IWebElement City => this.driver.FindElement(By.XPath("//input[@id='city']"));

        public IWebElement State => this.driver.FindElement(By.XPath("//select[@id='id_state']"));

        public IWebElement ZipCode => this.driver.FindElement(By.XPath("//input[@id='postcode']"));

        public IWebElement Country => this.driver.FindElement(By.XPath("//select[@id='id_country']"));

        public IWebElement Add_Info => this.driver.FindElement(By.XPath("//textarea[@id='other']"));

        public IWebElement HomePhone => this.driver.FindElement(By.XPath("//input[@id='phone']"));

        public IWebElement MobilePhone => this.driver.FindElement(By.XPath("////input[@id='phone_mobile']"));

        public IWebElement Addr_Alias => this.driver.FindElement(By.XPath("//input[@id='alias']"));

        public IWebElement Button_Register => this.driver.FindElement(By.XPath("//button[@id='submitAccount']"));

        public IWebElement News_email => this.driver.FindElement(By.XPath("//input[@id='newsletter-input']"));

        public IWebElement News_submit => this.driver.FindElement(By.XPath("//button[@name='submitNewsletter']"));

        public bool ClickOnMrRadioButton()
        {
            if (Mr_Button.Displayed && Mrs_Button.Displayed)
            {
                Mr_Button.Click();
                if (Mr_Button.Selected && !Mrs_Button.Selected)
                {
                    return true;
                }
            }

            return false;
        }


    }
}
