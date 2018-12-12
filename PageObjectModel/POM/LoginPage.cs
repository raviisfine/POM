using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PageObjectModel
{
    public class LoginPage
    {
        IWebDriver driver;
        readonly By username = By.XPath("//input[@class='js-username-field email-input js-initial-focus']");
        readonly By password = By.ClassName("js-password-field");
        readonly By submit = By.XPath("//button[@class='submit EdgeButton EdgeButton--primary EdgeButtom--medium']");
        public LoginPage(IWebDriver driver)
        {
            this.driver = driver;
        }
        public void Username()
        {
            driver.FindElement(username).SendKeys("raviisfine@gmail.com");
        }
        public void Password()
        {
            driver.FindElement(password).SendKeys("ravinandhu");
        }
        public void SubmitButton()
        {
            driver.FindElement(submit).Click();
        }
    }
}
