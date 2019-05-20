using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace UnitTestProject3
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            IWebDriver driver = new ChromeDriver(@"C:\Selenium");

            // Open Google Homepage
            driver.Navigate().GoToUrl("https://www.google.com/");

            // Search on google Mitto CH
            driver.FindElement(By.Name("q")).SendKeys("Mitto CH");

            // Wait for 5 seconds after search 
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);

            // Click search
            driver.FindElement(By.Name("btnK")).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);


            var firstLink = driver.FindElement(By.XPath("//cite[text()='https://www.mitto.ch/']")).Text;
            Assert.IsTrue(firstLink == "https://www.mitto.ch/");


            driver.Quit();
        }
    }
}
