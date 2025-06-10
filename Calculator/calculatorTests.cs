using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Windows;
using Xunit;

namespace Testing
{
    public class CalculatorTests : IDisposable
    {
        private WindowsDriver driver;

        public CalculatorTests()
        {
            var options = new AppiumOptions();
            options.App = "Microsoft.WindowsCalculator_8wekyb3d8bbwe!App";
            options.AddAdditionalAppiumOption("platformName", "Windows");
            options.AutomationName = "Windows";

            driver = new WindowsDriver(new Uri("http://192.168.1.236:4723/"), options);
        }

        public void TestAddition()
        {
            driver.FindElement(MobileBy.Name("One")).Click();
            driver.FindElement(MobileBy.Name("Plus")).Click();
            driver.FindElement(MobileBy.Name("Nine")).Click();
            driver.FindElement(MobileBy.Name("Equals")).Click();
            Assert.Equal("10", GetResult());
        }

        private string GetResult()
        {
            return driver.FindElement(By.XPath("//Custom/Group/Text[2]"))
                         .Text.Replace("Display is", string.Empty).Trim();
        }

        public void Dispose()
        {
            driver?.Quit();
        }
    }
}