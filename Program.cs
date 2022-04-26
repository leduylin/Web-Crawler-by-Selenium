using HtmlAgilityPack;
using System.Text;
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
            var html = driver.PageSource;
            HtmlAgilityPack.HtmlDocument htmlDoc = new HtmlDocument();
            htmlDoc.LoadHtml(html);
            var random = htmlDoc.DocumentNode.SelectSingleNode("/html/body/div[4]/div/div[1]/div[3]/div[1]/a/div[2]/div/h3/span").InnerText;
            Console.WriteLine(random);
        }
    }
}
