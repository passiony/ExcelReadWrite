using UnityEngine;
using System.Collections;
using UnityEditor;
using System.IO;

public class BuildAssertBundle : Editor {

    [MenuItem("Assetbundles/Create Assetbundles")]
    public static void ExcuteBuild()
    {
        
        BookElementHolder holder = ScriptableObject.CreateInstance<BookElementHolder>();

        holder.menus1 = ExcelAccess.SelectMenuTable(1);
        holder.menus2 = ExcelAccess.SelectMenuTable(2);
        holder.menus3 = ExcelAccess.SelectMenuTable(3);
        holder.goods = ExcelAccess.SelectGoodTable();

        AssetDatabase.CreateAsset(holder, HolderPath);
        AssetImporter import = AssetImporter.GetAtPath(HolderPath);
        import.assetBundleName = "booknames";

        BuildPipeline.BuildAssetBundles("Assets/Abs");

        Debug.Log("BuildAsset Success!");
    }

    [MenuItem("Assetbundles/BuildAssetBundles")]
    public static void BuildAssetBundles()
    {
        string outputPath = "Assets/bundles";
        foreach (Object o in Selection.GetFiltered(typeof(Object), SelectionMode.DeepAssets))
        {
            //得到指定资源路径
            string path = AssetDatabase.GetAssetPath(o);
            //得到指定资源的bundle名字
            string abName = AssetImporter.GetAtPath(path).assetBundleName;
            //得到指定资源的依赖资源路径
            string[] depends=AssetDatabase.GetDependencies(path);
            //修改所有依赖的bundle名
            foreach (string dp in depends)
            {
                if (dp.EndsWith(".cs") || dp.EndsWith(".js")) continue;

                AssetImporter ai = AssetImporter.GetAtPath(dp);
                ai.assetBundleName = abName;
            }
        }

        
        //生成bundle包的路径
        if (!Directory.Exists(outputPath))
            Directory.CreateDirectory(outputPath);
        //把已经赋值AssetBundleName的Object全部打包到指定目录中
        BuildPipeline.BuildAssetBundles(outputPath);
        AssetDatabase.Refresh();
        Debug.Log("Build AssetBundle Success");

    }
    public static string HolderPath
    {
        get
        {
             return "Assets/booknames.asset";
        }
    }
}
