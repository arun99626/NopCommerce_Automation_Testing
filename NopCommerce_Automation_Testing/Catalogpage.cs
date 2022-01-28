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
    public class Catalogpage : Testbase
    {
        [Test]
        public void _001_Validate_catalog()
        {
            login(ConfigProvider.GetconfigValue(Constants.Username), ConfigProvider.GetconfigValue(Constants.Password));
            IWebElement adminpage = driver.FindElement(By.XPath(Constants.Administrator));
            adminpage.Click();
            Thread.Sleep(2000);
            IWebElement catalogmenu = driver.FindElement(By.XPath(Constants.Catalogmenu));
            catalogmenu.Click();
        }
        [Test]
        public void _002_Validate_productpage()

        {
            login(ConfigProvider.GetconfigValue(Constants.Username), ConfigProvider.GetconfigValue(Constants.Password));
            IWebElement adminpage = driver.FindElement(By.XPath(Constants.Administrator));
            adminpage.Click();
            Thread.Sleep(2000);
            IWebElement catalogmenu = driver.FindElement(By.XPath(Constants.Catalogmenu));
            catalogmenu.Click();
            Thread.Sleep(2000);
            IWebElement products = driver.FindElement(By.XPath(Constants.Products));
            products.Click();
            Thread.Sleep(2000);

        }

        

        [Test]
        public void _003_Validate_Add_New_Product()

        {
            login(ConfigProvider.GetconfigValue(Constants.Username), ConfigProvider.GetconfigValue(Constants.Password));
            IWebElement adminpage = driver.FindElement(By.XPath(Constants.Administrator));
            adminpage.Click();
            Thread.Sleep(2000);
            IWebElement catalogmenu = driver.FindElement(By.XPath(Constants.Catalogmenu));
            catalogmenu.Click();
            Thread.Sleep(2000);
            IWebElement products = driver.FindElement(By.XPath(Constants.Products));
            products.Click();
            Thread.Sleep(2000);
            IWebElement AddnewProduct = driver.FindElement(By.XPath(Constants.AddNewProductBtn));
            AddnewProduct.Click();
            Thread.Sleep(2000);
            IWebElement ProductNametxt = driver.FindElement(By.XPath(Constants.ProductNametxt));
            ProductNametxt.Click();
            ProductNametxt.SendKeys("HCL");
            IWebElement Categoriestxt = driver.FindElement(By.XPath(Constants.Categoriestxt));
            Categoriestxt.Click();
            Thread.Sleep(2000);
            IReadOnlyList<IWebElement> Categorylist = driver.FindElements(By.XPath(Constants.Categorieslist));
            if (Categorylist.Count >= 1)
            {
                foreach (IWebElement list in Categorylist)
                {
                    if (list.Text.Contains("Fashion"))
                    {
                        list.Click();
                    }
                }
            }

            Thread.Sleep(3000);
        }
    }
}
