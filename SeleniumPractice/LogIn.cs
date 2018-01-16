using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace SeleniumPractice
{
    public class LogIn
    {
        private readonly string _username;
        private readonly string _password;

        public LogIn(string username, string password)
        {
            _username = username;
            _password = password;
        }

        public void LogUserIn(IWebDriver driver)
        {

                driver.Navigate()
                    .GoToUrl("https://login.yahoo.com/config/login?.intl=us&.lang=en-US&.src=finance&.done=https%3A%2F%2Ffinance.yahoo.com%2F");

                var userNameField = driver.FindElement(By.Id("login-username"));
                var nextButton = driver.FindElement(By.Id("login-signin"));

                userNameField.SendKeys(_username);
                nextButton.Click();

                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));

                var passwordField = wait.Until(d => d.FindElement(By.Id("login-passwd")));
                var signInButton = driver.FindElement(By.Id("login-signin"));

                passwordField.SendKeys(_password);
                signInButton.Click();


        }



    }
}
