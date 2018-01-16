using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace SeleniumPractice
{
    public class GetSummaryTable
    {
        public static IWebElement GetTable(IWebDriver driver)
        {
                var login = new LogIn("nimiko_chan", "DRZ!2#k");
                login.LogUserIn(driver);

                driver.Navigate().GoToUrl("https://finance.yahoo.com/portfolio/p_0/view/v1");

                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
                var summaryTable = wait.Until(d => d.FindElement(By.XPath("//table[@data-test='contentTable']/tbody")));
            
                return summaryTable;
        }
    }
}
