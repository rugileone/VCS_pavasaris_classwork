using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VCSPavasaris
{
    class ND1
    {
        [Test]
        public static void TestSum1()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = "https://testpages.herokuapp.com/styled/calculator";

            IWebElement firstInput = driver.FindElement(By.Id("number1"));
            firstInput.Clear();
            firstInput.SendKeys("2");

            IWebElement secondInput = driver.FindElement(By.Id("number2"));
            firstInput.Clear();
            secondInput.SendKeys("2");

            IWebElement submitButton = driver.FindElement(By.Id("calculate"));
            submitButton.Click();

            IWebElement result = driver.FindElement(By.Id("answer"));
            Assert.AreEqual($"4", result.Text, "Name is wrong!");

            driver.Quit();
        }

        [Test]
        public static void TestSum2()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = "https://testpages.herokuapp.com/styled/calculator";

            IWebElement firstInput = driver.FindElement(By.Id("number1"));
            firstInput.SendKeys("-5");

            IWebElement secondInput = driver.FindElement(By.Id("number2"));
            secondInput.SendKeys("3");

            IWebElement submitButton = driver.FindElement(By.Id("calculate"));
            submitButton.Click();

            IWebElement result = driver.FindElement(By.Id("answer"));
            Assert.AreEqual($"-2", result.Text, "Name is wrong!");

            driver.Quit();
        }

        [Test]
        public static void TestSum3()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = "https://testpages.herokuapp.com/styled/calculator";

            IWebElement firstInput = driver.FindElement(By.Id("number1"));
            firstInput.SendKeys("A");

            IWebElement secondInput = driver.FindElement(By.Id("number2"));
            secondInput.SendKeys("B");

            IWebElement submitButton = driver.FindElement(By.Id("calculate"));
            submitButton.Click();

            IWebElement result = driver.FindElement(By.Id("answer"));
            Assert.AreEqual($"ERR", result.Text, "Name is wrong!");

            driver.Quit();
        }

    }
}
