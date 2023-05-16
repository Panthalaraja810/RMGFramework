using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using System;
using System.Data.Odbc;

namespace RMGFramework.GenericUtilities
{
   
    public class IWebDriverUtilities
    {
        public void ImplicitlyWait(IWebDriver driver, long time)
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(time);
        }

        public void ExplicitWait(IWebDriver driver, long time)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(time));
         var tit =  driver.Title;
            // wait.Until(ExpectedConditions.ElementIsVisible(By.Id("logoutLink")));
            wait.Until(ExpectedConditions.TitleContains(tit));
        }

        public void MaximizeWindow(IWebDriver driver)
        {
            driver.Manage().Window.Maximize();
        }

        public static void ScreenShot(IWebDriver driver)
        {
            ITakesScreenshot takeScreenShot = (ITakesScreenshot)driver;

            Screenshot screenShot = takeScreenShot.GetScreenshot();
            BaseClass.screenShotPath = "C:\\Users\\panth\\source\\repos\\RMGFramework\\RMGFramework\\Screenshots\\screens.png";
            screenShot.SaveAsFile(BaseClass.screenShotPath, ScreenshotImageFormat.Png);
        }

        public OdbcDataReader DatabaseConnection(string query)
        {
            string connectionString = "Driver={MySQL ODBC 8.0 Unicode Driver};Server=localhost:3306;Database=projects;User=root;Password=root;";
            OdbcConnection odbcConnection = new OdbcConnection(connectionString);
            odbcConnection.Open();
         //   string query = "select project_id from project";
            OdbcCommand odbcCommand = new OdbcCommand(query, odbcConnection);
            var response = odbcCommand.ExecuteReader();

            return response;
        }


        public void SelectByValue(string value)
        {
      //      SelectElement s = new SelectElement();

        }
    }
}
