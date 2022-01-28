using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;


namespace NopCommerce_Automation_Testing
{
    [TestFixture]
    public class Testbase
    {
        public static IWebDriver driver;
        public WebDriverWait wait;

        [SetUp]
        public void Initialize()
        {
            Datadriven data = new Datadriven();
            data.ExcelToDataTable(@"D:\NopCommerce_Automation\NopCommerce_Automation_Testing\Data.xlsx");
            driver = new ChromeDriver();
            string baseurl = "http://192.168.0.13:8080/";
            driver.Navigate().GoToUrl(baseurl);
            driver.Manage().Window.Maximize();
            Thread.Sleep(3000);
        }
        
        public void login(string username, string password)
        {    
            IWebElement login = driver.FindElement(By.XPath(Constants.Login));
            login.Click();
            Thread.Sleep(3000);         
            IWebElement Email = driver.FindElement(By.XPath(Constants.Emailtxt));
            Email.Click();
            Email.SendKeys(username);
            Thread.Sleep(2000);
            IWebElement Password = driver.FindElement(By.XPath(Constants.passwordtxt));
            Password.Click();
            Password.SendKeys(password);
            IWebElement LoginBtn = driver.FindElement(By.XPath(Constants.Loginbtn));
            LoginBtn.Click();
            Thread.Sleep(3000);
        }
        [TearDown]
        public void Close()
        {
            driver.Close(); ;
            driver.Quit();
        }

    }
}
