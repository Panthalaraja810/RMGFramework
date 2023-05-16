using Bytescout.Spreadsheet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMGFramework.GenericUtilities
{
    public class ExcelUtilities
    {

        public string  returnCellValue(string sheetName, int rowNum, int colNum)
        {
            Spreadsheet spreadsheet = new Spreadsheet();

            spreadsheet.LoadFromFile(IPathConstants.excelPath);

            var worksheet = spreadsheet.Workbook.Worksheets[sheetName];
           string value = worksheet.Cell(rowNum, colNum).ToString();

            return value;
        }


        public static IEnumerable<object[]> multiDatas(string sheetName)
        {
            Spreadsheet spreadsheet = new Spreadsheet();
            spreadsheet.LoadFromFile(IPathConstants.excelPath);
            var sheet = spreadsheet.Workbook.Worksheets[sheetName];
            var maxrow = sheet.UsedRangeRowMax;
            var maxcol = sheet.UsedRangeColumnMax;

            for (int i = 1; i <= maxrow; i++)
            {
                string data = sheet.Cell(i, 0).ToString();
                yield return new object[] { data };
            }

        }
    }
}
