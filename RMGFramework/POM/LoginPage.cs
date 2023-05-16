using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMGFramework.POM
{
    public class LoginPage
    {
        IWebDriver driver;
       
        [FindsBy(How = How.Id, Using = "usernmae")]
        private IWebElement usernameInput { get; set; }

        [FindsBy(How = How.Id, Using = "inputPassword")]
        private IWebElement passwordInput { get; set; }

        [FindsBy(How = How.XPath, Using = "//button[contains(text(),'Sign in')]")]
        private IWebElement signin { get; set; }

        public LoginPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
         
        }

        public void Login(string username, string password)
        {
            usernameInput.SendKeys(username);
            passwordInput.SendKeys(password);
            signin.Submit();
        }



    }
}
