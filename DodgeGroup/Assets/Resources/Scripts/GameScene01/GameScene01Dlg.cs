using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class GameScene01Dlg : MonoBehaviour
{
    [SerializeField]
    Button m_btnStart;
    [SerializeField]
    public Button m_btnStop;

    [SerializeField]
    Turret01 m_turret01;

    void Start()
    {
        m_btnStart.onClick.AddListener(OnClickedStart);
        m_btnStop.onClick.AddListener(OnClickedStop);
    }

    void OnClickedStart()
    {
        m_turret01.isFire = true;
    }
    void OnClickedStop()
    {
        m_turret01.isFire = false;
    }
   
}
