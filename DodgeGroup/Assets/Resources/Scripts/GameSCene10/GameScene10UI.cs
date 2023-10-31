using System;
using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;


public class GameScene10UI : MonoBehaviour
{
    [SerializeField] ItemText[] m_itemText;
    [SerializeField] Text m_text;
    private void Start()
    {
        for (int i = 0; i < m_itemText.Length; i++)
        {
            m_itemText[i].AddLinstener(OnClick_TextItem);
        }
        
    }
    private void Initialize()
    {
        
    }

    public void OnClick_TextItem(ItemText item, bool isSelect)
    {
        ClearColor();
        item.m_name.color = Color.red;

    }

    void ClearColor()
    {
        for (int i = 0; i < m_itemText.Length; i++)
        {
            m_itemText[i].m_name.color = Color.black;
        }

    }
}
