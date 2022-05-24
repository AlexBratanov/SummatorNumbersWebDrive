using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SummatorNumbers
{
    public class TestSumTwoValidNums
    {
        private ChromeDriver driver;

        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
        }

        [Test]
        public void Test1()
        {
            driver.Navigate().GoToUrl("https://sum-numbers.nakov.repl.co");
            driver.FindElement(By.CssSelector("#number1")).SendKeys("5");
            driver.FindElement(By.CssSelector("#number2")).SendKeys("5");
            driver.FindElement(By.CssSelector("#calcButton")).Click();
            var result = driver.FindElement(By.CssSelector("#result")).Text;

            Assert.AreEqual("Sum: 10", result);

        }
        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }
    }
}