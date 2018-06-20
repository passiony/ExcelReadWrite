using UnityEngine;
using System.Collections;
using UnityEditor;
using System.IO;

/// <summary>
/// 利用ScriptableObject创建资源文件
/// </summary>
public class BuildAssertBundle : Editor {

    [MenuItem("BuildAsset/Build Asset")]
    public static void ExcuteBuild()
    {
        BookElementHolder holder = ScriptableObject.CreateInstance<BookElementHolder>();

        //查询excel表中数据，赋值给asset文件
        holder.menus1 = ExcelAccess.SelectMenuTable(1);
        holder.menus2 = ExcelAccess.SelectMenuTable(2);
        holder.menus3 = ExcelAccess.SelectMenuTable(3);
        holder.goods = ExcelAccess.SelectGoodTable();

        string path= "Assets/Resources/booknames.asset";

        AssetDatabase.CreateAsset(holder, path);

        Debug.Log("BuildAsset Success!");
    }

}
