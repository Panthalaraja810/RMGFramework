using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace RMGFramework.GenericUtilities
{
    [TestClass]
    public class BaseClass
    {

        public static IWebDriver driver;
        public static ExtentReports extentReports;
        public static ExtentHtmlReporter extentHtmlReporter;
        public static string testResultPath = "C:\\Users\\panth\\source\\repos\\RMGFramework\\RMGFramework\\Reports\\";
        public static string screenShotPath; //= "C:\\Users\\panth\\source\\repos\\RMGFramework\\RMGFramework\\Screenshots\\";

        public ExtentTest extentTest;
        public TestContext TestContext { get; set; }



         [AssemblyInitialize]
         public static void AssemblyInitMethod(TestContext context)
         {
            extentReports =new ExtentReports();
            extentHtmlReporter = new ExtentHtmlReporter(testResultPath);
            extentHtmlReporter.Start();
            extentReports.AttachReporter(extentHtmlReporter);
         }

        [AssemblyCleanup]
        public static void AssemblyCleanupMethod()
        {
            extentReports.Flush();
            extentHtmlReporter.Stop();
        }


        [TestInitialize]
        public void InitializeTest()
        {
            driver = new ChromeDriver();

        }

        [TestCleanup]
        public void CleanupTest()
        {
            driver.Quit();
            driver.Dispose();
        }
     
  

    }
}
