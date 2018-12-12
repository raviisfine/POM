using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using System.Threading;

namespace PageObjectModel
{
    [TestClass]
    public class TwitterLogin
    {
        IWebDriver driver;

        [TestMethod]
        public void VerifyIETwitterLogin()
        {
            //IWebDriver driver = new ChromeDriver();
            //IWebDriver driver = new FirefoxDriver(@"D:\Firfox driver\geckodriver-v0.23.0-win64");
            var options = new InternetExplorerOptions
            {
                IntroduceInstabilityByIgnoringProtectedModeSettings = true
            };
            driver = new InternetExplorerDriver(@"D:\Chrome Driver\IEDriverServer_Win32_3.14.0", options);
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://twitter.com/login");
            LoginPage login = new LoginPage(driver);
            login.Username();
            login.Password();
            login.SubmitButton();
            Thread.Sleep(3000);
            driver.FindElement(By.XPath("//ul[@class='nav right-actions']/li[@id='user-dropdown']/a[@id='user-dropdown-toggle']")).Click();
            Thread.Sleep(3000);
            driver.FindElement(By.XPath("//ul/li[@id='signout-button']/button[@class='dropdown-link']")).Click();
            Thread.Sleep(3000);
            driver.Quit();
        }
        [TestMethod]
        public void VerifyChromeTwitterLogin()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://twitter.com/login");
            LoginPage login = new LoginPage(driver);
            login.Username();
            login.Password();
            login.SubmitButton();
            Thread.Sleep(3000);
            driver.FindElement(By.XPath("//ul[@class='nav right-actions']/li[@id='user-dropdown']/a[@id='user-dropdown-toggle']")).Click();
            Thread.Sleep(3000);
            driver.FindElement(By.XPath("//ul/li[@id='signout-button']/button[@class='dropdown-link']")).Click();
            Thread.Sleep(3000);
            driver.Quit();
        }
        [TestMethod]
        public void VerifyFirefoxTwitterLogin()
        {
            IWebDriver driver = new FirefoxDriver(@"D:\Firfox driver\geckodriver-v0.23.0-win64");
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://twitter.com/login");
            LoginPage login = new LoginPage(driver);
            login.Username();
            login.Password();
            login.SubmitButton();
            Thread.Sleep(3000);
            driver.FindElement(By.XPath("//ul[@class='nav right-actions']/li[@id='user-dropdown']/a[@id='user-dropdown-toggle']")).Click();
            Thread.Sleep(3000);
            driver.FindElement(By.XPath("//ul/li[@id='signout-button']/button[@class='dropdown-link']")).Click();
            Thread.Sleep(3000);
            driver.Quit();
        }
    }
}
