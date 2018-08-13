using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

[TestFixture]
public class Class1
{
    IWebDriver driver;

    [SetUp]
    public void Initialize()
    {
        Console.WriteLine("SetUP started");
        driver = new ChromeDriver();

        driver.Navigate().GoToUrl("http:www.google.com.ua");
        Console.WriteLine("SetUP finished");
    }

    [Test]
    public void TestOne()
    {
        Console.WriteLine("TestOne started");
        IWebElement searchField = driver.FindElement(By.Name("q"));

        searchField.SendKeys("Severyn Vehera");

        Wait(3);

        searchField.SendKeys(Keys.Enter);

        Wait(3);
        Console.WriteLine("TestOne finished");
    }

    [TearDown]
    public void CleanUp()
    {
        Console.WriteLine("TearDown started");
        driver.Quit();
        Console.WriteLine("TearDown finished");
    }

    public void Wait(int seconds)
    {
        Thread.Sleep(seconds * 1000);
    }
}
