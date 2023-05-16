using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMGFramework.POM
{
    public class HomePage
    {

        [FindsBy(How = How.LinkText, Using = "Menu")]
        private IWebElement menu { get; set; }

        [FindsBy(How =How.LinkText, Using = "Home")]
        private IWebElement home { get; set; }

        [FindsBy(How =How.LinkText, Using = "Projects")]
        private IWebElement projects { get; set; }

        [FindsBy(How =How.LinkText, Using = "Users")]
        private IWebElement users { get; set; }

        [FindsBy(How =How.LinkText, Using = "Settings")]
        private IWebElement settings { get; set; }

        [FindsBy(How =How.LinkText, Using = "Logout")]
        private IWebElement logout { get; set; }
        

        public HomePage(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }

        public void ProjectsModule()
        {
            projects.Click();
        }

        public void Logout()
        {
            logout.Click();
        }


    }
}
