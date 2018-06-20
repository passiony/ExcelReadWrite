using UnityEngine;
using System.Collections.Generic;

public class TestRead : MonoBehaviour {

	// Use this for initialization
	void Start () {
        List<FishData> fishs = FishExcel.SelectFishTable();

        foreach (FishData fish in fishs)
        {
            Debug.Log(fish.fname);
        }
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
