using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using System.IO;

[CustomEditor(typeof(map))]
public class MapDataEditor:Editor  {
    map mmap;

    void OnEnable()
    {
        mmap = target as map;
        if (mmap.minfo == null)
        {
            mmap.minfo = new mapData();
        }
    }
}
