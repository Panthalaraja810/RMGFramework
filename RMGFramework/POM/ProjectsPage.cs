using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMGFramework.POM
{
    public class ProjectsPage
    {
        [FindsBy(How = How.XPath, Using = "//span[contains(text(),'Create Project')]")]
        private IWebElement createProject { get; set; }

        public ProjectsPage(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }

        public void clickCreateProject()
        {
            createProject.Click();
        }

    }
}
