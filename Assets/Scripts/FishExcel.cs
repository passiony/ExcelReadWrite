using UnityEngine;
using UnityEditor;
using Excel;
using System.Data;
using System.IO;
using System.Collections.Generic;

public class FishExcel
{
    public static string ExcelName = "FishData.xlsx";

    public static List<FishData> SelectFishTable()
    {
        FileStream stream = File.Open(FilePath(ExcelName), FileMode.Open, FileAccess.Read, FileShare.Read);
        IExcelDataReader excelReader = ExcelReaderFactory.CreateOpenXmlReader(stream);
        DataSet result = excelReader.AsDataSet();
        DataRowCollection collect = result.Tables[0].Rows;

        List<FishData> fishArray = new List<FishData>();

        for (int i = 1; i < collect.Count; i++)
        {
            if (collect[i][1].ToString() == "") continue;

            FishData fish = new FishData();
            fish.id = int.Parse(collect[i][0].ToString());
            fish.fname = collect[i][1].ToString();
            fish.odds = int.Parse(collect[i][2].ToString());
            fish.typeIndex = int.Parse(collect[i][3].ToString());
            fish.hitTypeS = collect[i][4].ToString();

            fish.rotateAngleRnd = float.Parse(collect[i][5].ToString());
            fish.rotateInterval = float.Parse(collect[i][6].ToString());
            fish.rotateIntervalRnd = float.Parse(collect[i][7].ToString());

            fish.roundCircleRadius = float.Parse(collect[i][8].ToString());
            fish.speed = float.Parse(collect[i][9].ToString());
            fish.rotateSpeed = float.Parse(collect[i][10].ToString());
            fishArray.Add(fish);
        }
        return fishArray;
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
    public static string FilePath(string name)
    {
        return Application.dataPath+"/" + name;
    }

}

