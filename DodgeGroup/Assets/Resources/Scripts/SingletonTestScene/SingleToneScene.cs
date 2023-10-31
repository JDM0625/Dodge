using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// No MonoBehaviour
public class GameMgr
{
    static GameMgr m_inst = null;
    public static GameMgr Inst()
    {
        if(m_inst == null)
        {
            m_inst = new GameMgr();
        }
        return m_inst;
    }

    public int m_Score = 100;
}

// with MonoBehaviour
public class SingleToneScene : MonoBehaviour
{
    public void Initalize()
    {
        GameMgr.Inst().m_Score = 200;
        Debug.Log(GameMgr.Inst().m_Score);
    }
}
