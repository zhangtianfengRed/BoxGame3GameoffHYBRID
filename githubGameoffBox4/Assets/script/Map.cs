using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Map : MonoBehaviour {
    public int high;
    public int width;
    public GameObject ground;
	// Use this for initialization
	void Start () {
        mapStart();

    }
	
	// Update is called once per frame
	void Update () {
		
	}
    #region 加载关卡
    public interface load
    {
        void loadlevel(int level);
    }

    class levelload : load
    {

        public void loadlevel(int level)
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene(level+1);
        }
    }
    public interface level
    {
        void Done();
    }
    public class Level:level
    {
        public GameObject mylevel { get; set; }
        private load Load;
        public int _level { get; set; }

        public Level(load _load)
        {
            this.Load = _load;
        }

        public void Done()
        {
            Load.loadlevel(_level);
        }
    }
    #endregion

    void mapStart()
    {
        for (int x = 0; x < high; x++) {
            for(int y = 0; y < width; y++)
            {
                Instantiate(ground, new Vector3Int(x, y, 0), Quaternion.identity);
            }
        }

    }
}
