using Bytescout.Spreadsheet;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RMGFramework.GenericUtilities;
using System;
using System.Data.Odbc;

namespace RMGFramework.TestScripts
{
    [TestClass]
    public class UnitTest2
    {
        [TestMethod]
        [TestCategory("Storing the Projectid in the excel sheet")]
        public void ProjectId()
        {
            Spreadsheet spreadsheet = new Spreadsheet();
            string excelpath = IPathConstants.excelPath;
            spreadsheet.LoadFromFile(excelpath);
            var sheet = spreadsheet.Workbook.Worksheets["PROJECTID"];
            string connectionString = "Driver={MySQL ODBC 8.0 Unicode Driver};Server=localhost:3306;Database=projects;User=root;Password=root;";
            OdbcConnection odbcConnection = new OdbcConnection(connectionString);
            odbcConnection.Open();
            string query = "select project_id from project";
            OdbcCommand odbcCommand = new OdbcCommand(query, odbcConnection);
            var response = odbcCommand.ExecuteReader();
            int i = 1;
            while (response.Read())
            {
                Console.WriteLine(response[0]);
                sheet.Cell(i, 0).Value = response[0].ToString();
                i++;
                spreadsheet.SaveAs(excelpath);

            }
            spreadsheet.Close();
        }
    }
}
