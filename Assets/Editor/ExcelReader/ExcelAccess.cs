using UnityEngine;
using UnityEditor;
using Excel;
using System.Data;
using System.IO;
using System.Collections.Generic;
using OfficeOpenXml;

public class ExcelAccess
{
    public static string ExcelName = "Book.xlsx";
    public static string[] SheetNames = { "sheet1", "sheet2", "sheet3", "sheet4" };

    public static List<Menu> SelectMenuTable(int tableId)
    {
        DataRowCollection collect = ExcelAccess.ReadExcel(SheetNames[tableId-1]);
        List<Menu> menuArray = new List<Menu>();

        for (int i = 1; i < collect.Count; i++)
        {
            if (collect[i][1].ToString() == "") continue;

            Menu menu = new Menu();
            menu.m_Id = collect[i][0].ToString();
            menu.m_level = collect[i][1].ToString();
            menu.m_parentId = collect[i][2].ToString();
            menu.m_name = collect[i][3].ToString();
            menuArray.Add(menu);
        }
        return menuArray;
    }

    public static List<Good> SelectGoodTable()
    {
        DataRowCollection collect = ExcelAccess.ReadExcel(SheetNames[3]);
        List<Good> menuArray = new List<Good>();

        for (int i = 1; i < collect.Count; i++)
        {
            if (collect[i][1].ToString() == "") continue;

            Good good = new Good();
            good.m_firstId = collect[i][1].ToString();
            good.m_secondId = collect[i][2].ToString();
            good.m_thirdId = collect[i][3].ToString();
            good.m_key = collect[i][4].ToString();
            good.m_name = collect[i][5].ToString();

            good.m_brand = collect[i][6].ToString();
            good.m_style = collect[i][7].ToString();
            good.m_color = collect[i][8].ToString();
            good.m_material = collect[i][9].ToString();
            good.m_shape = collect[i][10].ToString();
            good.m_price = collect[i][11].ToString();
            menuArray.Add(good);
        }
        return menuArray;
    }

    /// <summary>
    /// 读取 Excel 需要添加 Excel; System.Data;
    /// </summary>
    /// <param name="sheet"></param>
    /// <returns></returns>
    static DataRowCollection ReadExcel(string sheet)
    {
        FileStream stream = File.Open(FilePath(ExcelName), FileMode.Open, FileAccess.Read, FileShare.Read);
        IExcelDataReader excelReader = ExcelReaderFactory.CreateOpenXmlReader(stream);

        DataSet result = excelReader.AsDataSet();
        //int columns = result.Tables[0].Columns.Count;
        //int rows = result.Tables[0].Rows.Count;
        return result.Tables[sheet].Rows;
    }

    /// <summary>
    /// 读取 Excel 需要添加 OfficeOpenXml;
    /// </summary>
    public static void WriteExcel(string outputDir)
    {
        //string outputDir = EditorUtility.SaveFilePanel("Save Excel", "", "New Resource", "xlsx");
        FileInfo newFile = new FileInfo(outputDir);
        if (newFile.Exists)
        {
            newFile.Delete();  // ensures we create a new workbook
            newFile = new FileInfo(outputDir);
        }
        using (ExcelPackage package = new ExcelPackage(newFile))
        {
            // add a new worksheet to the empty workbook
            ExcelWorksheet worksheet = package.Workbook.Worksheets.Add("Sheet1");
            //Add the headers
            worksheet.Cells[1, 1].Value = "ID";
            worksheet.Cells[1, 2].Value = "Product";
            worksheet.Cells[1, 3].Value = "Quantity";
            worksheet.Cells[1, 4].Value = "Price";
            worksheet.Cells[1, 5].Value = "Value";

            //Add some items...
            worksheet.Cells["A2"].Value = 12001;
            worksheet.Cells["B2"].Value = "Nails";
            worksheet.Cells["C2"].Value = 37;
            worksheet.Cells["D2"].Value = 3.99;

            worksheet.Cells["A3"].Value = 12002;
            worksheet.Cells["B3"].Value = "Hammer";
            worksheet.Cells["C3"].Value = 5;
            worksheet.Cells["D3"].Value = 12.10;

            worksheet.Cells["A4"].Value = 12003;
            worksheet.Cells["B4"].Value = "Saw";
            worksheet.Cells["C4"].Value = 12;
            worksheet.Cells["D4"].Value = 15.37;

            //save our new workbook and we are done!
            package.Save();
        }
    }
    public static string FilePath(string name)
    {
        return Application.dataPath+"/" + name;
    }

}

