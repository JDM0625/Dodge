using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameScene03 : MonoBehaviour
{
    public Turret03[] m_Turret = new Turret03[5];

    public Button btn_Start;
    public Button btn_Stop;

    private void Start()
    {
        btn_Start.onClick.AddListener(OnClickedStart);
        btn_Stop.onClick.AddListener(OnClickedStop);
    }

    void OnClickedStart()
    {
        for (int i = 0; i < m_Turret.Length; i++)
        {
            m_Turret[i].StartFire03();
        }
    }
    void OnClickedStop()
    {
        for (int i = 0; i < m_Turret.Length; i++)
        {
            m_Turret[i].StopFire03();
        }
    }
}
