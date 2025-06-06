using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Windows;
using Xunit;


namespace Testing
{
    class Program
    {
        public static void Main(string[] args)
        {
            AppiumOptions options = new AppiumOptions();
            
            options.App = "Microsoft.WindowsCalculator_8wekyb3d8bbwe!App";
            options.AddAdditionalAppiumOption("platformName", "Windows");
            options.AutomationName = "Windows";

           
            WindowsDriver driver = new WindowsDriver(new Uri("http://192.168.1.235:4723"), options);
            driver.FindElement(MobileBy.Name("One")).Click();
            Assert.Equal("1", getResult(driver));
            driver.FindElement(MobileBy.Name("Plus")).Click();
            Assert.Equal("1", getResult(driver));
            driver.FindElement(MobileBy.Name("Nine")).Click();
            Assert.Equal("9", getResult(driver));
            driver.FindElement(MobileBy.Name("Equals")).Click();
            Assert.Equal("10", getResult(driver));


        }

        private static String getResult(WindowsDriver driver)
        {
            return driver.FindElement(By.XPath("//Custom/Group/Text[2]")).Text.Replace("Display is", string.Empty).Trim();
        }
	}
}