using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class GudUI : MonoBehaviour
{
    public Button m_btnStart;
    public Text m_Text;

    int count = 3;
    float countNum = 0f;

    bool m_IsClicked = false;


    private void Start()
    {
        m_btnStart.onClick.AddListener(OnClickedStart);
        m_Text.gameObject.SetActive(false);
    }

    void OnClickedStart()
    {
        m_IsClicked = true;
    }

    private void Update()
    {
        if(m_IsClicked == true)
        {
            m_btnStart.gameObject.SetActive(false);
            m_Text.gameObject.SetActive(true);
            
            countNum += Time.deltaTime;
            if(countNum >= 1f)
            {
                m_Text.text = count.ToString();
                countNum = 0f;
                if (count == 0)
                {
                    m_Text.text = "Start";
                }
                if (count == -1)
                {
                    m_IsClicked = false;
                    m_Text.gameObject.SetActive(false);
                }
                count--;
            }
        }
    }
}
