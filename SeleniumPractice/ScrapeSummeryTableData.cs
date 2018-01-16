using System;
using System.Linq;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace SeleniumPractice
{
    public class ScrapeSummeryTableData
    {
        public static void FirstTrial()
        {
            var driver = Driver.driver;
            var summaryTable = GetSummaryTable.GetTable(driver);
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            var row = summaryTable.FindElement(By.XPath(".//tr[1]"));
            //const string rowXPath = "//tr[@data-index='0']";
            const string rowXPath = "//tr[2]";
            var symbolName= wait.Until(d => row.FindElement(By.XPath(rowXPath+"/td[1]/span/a")).Text);
            var lastPrice = summaryTable.FindElement(By.XPath(rowXPath + "/td[2]/span")).Text;
            var change = row.FindElement(By.XPath(rowXPath + "/td[3]/span")).Text;
            var numberOfRows = summaryTable.FindElements(By.XPath(".//tr")).Count;
            
           
            Console.WriteLine($"Symbol Name: ");
            Console.WriteLine(lastPrice);
            Console.WriteLine(numberOfRows);
        }
    }
}
