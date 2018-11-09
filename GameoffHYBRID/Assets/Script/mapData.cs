using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mapData : ScriptableObject {

	public mapData() {

        GameobjetList = new GameObject[mapwidth, maphigh];

    }

    public int mapwidth;
    public int maphigh;
    public GameObject ground;
    public GameObject Button;
    public GameObject[,] GameobjetList;
    public int pushdistance;
    public GameObject MapParent;
    public GameObject BoxParent;
    public GameObject TargetParent;
    public GameObject ButtonParent;

}
