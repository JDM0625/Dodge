using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMgr3 : MonoBehaviour
{
    static GameMgr3 _init = null;
    public static GameMgr3 m_init
    {
        get
        {
            if(_init == null)
            {
                GameObject go = new GameObject("Singleton GameMgr");
                _init = go.AddComponent<GameMgr3>();
                DontDestroyOnLoad(go);
            }
            return _init;
        }
    }

    public int m_Score = 100;
}

public class SingleTone0 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
