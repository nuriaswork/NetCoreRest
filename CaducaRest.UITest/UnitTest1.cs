using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace CaducaRest.UITest
{
    public class Tests : IDisposable
    {
        private  IWebDriver _driver;

        [SetUp]
        public void Setup()
        {
          
            _driver = new ChromeDriver(Environment.GetEnvironmentVariable("ChromeWebDriver"));
        }
  
        [Test]
        
        public void Test1()
        {
            _driver.Navigate().GoToUrl("http://www.google.com");
            Assert.AreEqual("Google", _driver.FindElement(By.Id("hplogo")).GetAttribute("alt"));
        }
        
        public void Dispose()
        {
            _driver.Quit();
            _driver.Dispose();
        }
    }
}