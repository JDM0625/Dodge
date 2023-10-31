using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerUI : MonoBehaviour
{
    public Button m_BtnStart;
    public Button m_BtnStop;
    public Button m_BtnClear;

    bool isClicked = false;

    public Text m_Text;

    float m_Time = 0;

    private void Start()
    {
        m_BtnStart.onClick.AddListener(OnClickedStart);
        m_BtnStop.onClick.AddListener(OnClickedStop);
        m_BtnClear.onClick.AddListener(OnClickedClear);
    }

    void OnClickedStart()
    {
        isClicked = true;
    }
    void OnClickedStop()
    {
        isClicked = false;
    }
    void OnClickedClear()
    {
        m_Time = 0;
    }

    private void Update()
    {
        if (isClicked)
        {
            m_Time += Time.deltaTime;

            int second = (int)m_Time % 60;
            int minute = (int)m_Time / 60;
            float miliSec = (m_Time * 100) % 100;
            m_Text.text = string.Format("{0:00}:{1:00}:{2:00}", minute, second, miliSec);
        }   
    }
}
