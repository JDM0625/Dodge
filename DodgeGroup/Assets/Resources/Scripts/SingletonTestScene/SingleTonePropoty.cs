using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMgr2
{
    public static GameMgr2 m_GameMgr = null;

    public static GameMgr2 init()
    {
        if(m_GameMgr == null)
        {
            m_GameMgr = new GameMgr2();
        }
        return m_GameMgr;
        
    }
    public int m_Num = 100;

}

public class SingleTonePropoty : MonoBehaviour
{
    private void Initialize()
    {
        GameMgr2.init().m_Num = 200;
        
    }
}
