using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SeleniumSharp
{
    class Program
    {
        IWebDriver driver;

        static void Main(string[] args)
        {
         
        }

        [SetUp]
        public void Initialize()
        {
            driver = new ChromeDriver();

            driver.Navigate().GoToUrl("http:www.google.com.ua");
        }

        [Test]
        public void TestOne()
        {
            IWebElement searchField = driver.FindElement(By.Name("q"));

            searchField.SendKeys("Severyn Vehera");

            Wait(3);

            searchField.SendKeys(Keys.Enter);

            Wait(3);
        }

        [TearDown]
        public void CleanUp()
        {
            driver.Quit();
        }
                
        public void Wait(int seconds)
        {
            Thread.Sleep(seconds* 1000);
        }
    }
}
