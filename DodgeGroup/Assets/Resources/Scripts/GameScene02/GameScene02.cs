using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameScene02 : MonoBehaviour
{
    public Button btn_Start;
    public Button btm_Stop;
    public Target02 m_Tar;

    private void Start()
    {
        btn_Start.onClick.AddListener(OnClickedStart);
        btn_Start.onClick.AddListener(OnClickedStop);
    }

    void OnClickedStart()
    {
        Target02 target = GetComponent<Target02>();
        m_Tar.StartShoot();
    }
    void OnClickedStop()
    {
        Target02 target = GetComponent<Target02>();
        m_Tar.StopShoot();
    }
}
