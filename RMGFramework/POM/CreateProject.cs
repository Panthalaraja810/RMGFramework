using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;
using static System.Net.Mime.MediaTypeNames;

namespace RMGFramework.POM
{
    [TestClass]
    public class CreateProject
    {
        IWebDriver driver;

        [FindsBy(How = How.Name, Using = "projectName")]
        private IWebElement projectName { get; set; }

        [FindsBy(How = How.Name, Using = "teamSize")]
        private IWebElement teamSize { get; set; }

        [FindsBy(How =How.Name, Using = "createdBy")]
        private IWebElement createdBy { get; set; }

        //[FindsBy(How =How.XPath, Using = "//label[text()='Project Manager']/parent::div/following-sibling::div/label[text()='Status']/parent::div/select")]
       // [FindsBy(How =How.Name, Using = "status")]
        [FindsBy(How = How.XPath, Using = "//label[text()='Project Status ']/following-sibling::select[@name='status']")]
        private IWebElement projectStatus { get; set; }

        [FindsBy(How =How.XPath, Using = "//input[@value='Add Project']/preceding-sibling::input[@value='Cancel']")]
        private IWebElement cancel { get; set; }

        [FindsBy(How =How.XPath, Using = "//input[@value='Add Project']")]
        private IWebElement addProject { get; set; }

        public CreateProject(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }

        public void CreateProjectMethod(string ProjectName, string CreatedBy,string text)
        {



            projectName.SendKeys(ProjectName);
           // teamSize.SendKeys(TeamSize);
           createdBy.SendKeys(CreatedBy);
            Thread.Sleep(3000);
           SelectElement select = new SelectElement(projectStatus);
           select.SelectByText(text);





            

           addProject.Submit();












        }

        public void status(string text)
        {
          //  SelectElement select = new SelectElement(projectStatus);
           // select.SelectByText(text);
           // select.SelectByValue(text);
        }
        public void SubmitProject()
        {
            addProject.Submit();
        }


    }
}
