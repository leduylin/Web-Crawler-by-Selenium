using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

using System;

namespace SeleniumCrawler
{
    class Program
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://batdongsan.com.vn/nha-dat-ban";
            IWebElement element = driver.FindElement(By.XPath("/html/body/div[4]/div/div[1]/h1"));
            Console.WriteLine(element.Text);
        }
    }
}
