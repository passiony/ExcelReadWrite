using UnityEngine;
using System.Collections;

public class ReadHolders : MonoBehaviour {

    public string assetName = "bonenames";
	// Use this for initialization
	void Start () {
        readAsset();
	}
	
	public void readAsset()
    {
        Object asset = Resources.Load<Object>(assetName);
        BookElementHolder ceh = (BookElementHolder)asset;
        foreach (Good gd in ceh.goods)
        {
            Debug.Log(gd.m_name);
        }
    }

    public string RootPath
    {
        get
        {
            return Application.dataPath;
        }
    }

}
