using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class map : MonoBehaviour {

    public mapData minfo = null;
    // Use this for initialization
    void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		
	}
    enum Tag
    {
        ground,
        box,
        target
    }

    void mapGroud()
    {
        for(int x = 0; x < minfo.maphigh; x++)
        {
            for(int y = 0; y < minfo.mapwidth; y++)
            {
                GameObject ground= Instantiate(minfo.ground, new Vector3Int(x, y,0), Quaternion.identity);
                ground.tag = Tag.ground.ToString();
            }
        }
    }

}


