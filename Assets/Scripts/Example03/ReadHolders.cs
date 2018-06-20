using UnityEngine;
using System.Collections;

/// <summary>
/// 测试读取booknames的scriptObject文件
/// 使用Resources直接读取
/// </summary>
public class ReadHolders : MonoBehaviour {

    string assetName = "booknames";

	void Start ()
    {
        BookElementHolder asset = Resources.Load<BookElementHolder>(assetName);
        foreach (Good gd in asset.goods)
        {
            Debug.Log(gd.m_name);
        }
    }

}
