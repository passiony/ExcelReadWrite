using UnityEngine;
using System.Collections.Generic;

public class TestRead : MonoBehaviour {

	void Start () {
        List<FishData> fishs = FishExcel.SelectFishTable();

        foreach (FishData fish in fishs)
        {
            Debug.Log(fish.fname);
        }
    }

}
