using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;


public class UIStart : MonoBehaviour
{
    public Button m_btnStart;
    string[] Count = new string[4] { "3", "2", "1", "Start"};
    public Text m_Text;

    private void Start()
    {
        m_btnStart.onClick.AddListener(OnClickStart);
        m_Text.enabled = false;
    }

    IEnumerator CountNum()
    {
        m_btnStart.enabled = false;
        m_Text.enabled = true;
        for (int i = 0; i < Count.Length; i++) 
        {
            m_Text.text = Count[i];
            yield return new WaitForSeconds(1);
               
        }
        m_Text.enabled = false;
    }


    void OnClickStart()
    {
        StartCoroutine(CountNum());
    }
}
