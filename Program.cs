using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;

namespace SeleniumTest2
{
    class Program
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.google.com");

            IWebElement bb = driver.FindElement(By.ClassName("gLFyf"));
            bb.SendKeys("brazil maps");

            IWebElement clk = driver.FindElement(By.ClassName("gLFyf"));
            clk.Submit();

            IWebElement clk2 = driver.FindElement(By.ClassName("BbLFkb"));
            clk2.Click();
        }
    }
}
