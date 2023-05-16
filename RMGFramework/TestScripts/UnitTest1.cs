using AventStack.ExtentReports;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Support.UI;
using RMGFramework.GenericUtilities;
using RMGFramework.POM;
using System;
using System.Net.PeerToPeer;
using System.Threading;

namespace RMGFramework.TestScripts
{
    [TestClass]
    public class UnitTest1 : BaseClass
    {
       
       IWebDriverUtilities webD =new IWebDriverUtilities();
        ExcelUtilities excelUtilities = new ExcelUtilities();
       CSharpUtilities c =new CSharpUtilities();

        [TestMethod]
        public void TestMethod1()
        {
            try
            {
                HomePage homePage = new HomePage(driver);
                LoginPage login = new LoginPage(driver);
                CreateProject createProject = new CreateProject(driver);
                ProjectsPage projectsPage = new ProjectsPage(driver);
                //  var url = TestContext.Properties["Url"].ToString();

                var Username = excelUtilities.returnCellValue("Login", 0, 0);
                var Password = excelUtilities.returnCellValue("Login", 0, 1);
                string name = TestContext.TestName;
                extentTest = extentReports.CreateTest(name + "Test");

                driver.Url = "http://localhost:8084/";
                extentTest.Info("Url opened");
                webD.ImplicitlyWait(driver, 10);

                extentTest.Info(name + "Test created ");

                login.Login(Username, Password);
                extentTest.Info("Login done");
                homePage.ProjectsModule();
                projectsPage.clickCreateProject();
                Assert.Fail();
                var projectName = excelUtilities.returnCellValue("CreateProject", 1, 0).ToString() + c.RandomThreeNum();
                var createdBy = excelUtilities.returnCellValue("CreateProject", 1, 2).ToString();
                createProject.CreateProjectMethod(projectName, createdBy, "On Goging");
                extentTest.Info("Projetct created");

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
                IWebDriverUtilities.ScreenShot(driver);
                extentTest.AddScreenCaptureFromPath(screenShotPath);
            }
        }



       




    }
}
