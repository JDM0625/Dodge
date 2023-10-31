using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemText : MonoBehaviour
{
    public Button m_btn;
    public Text m_name;
    public delegate void Del(ItemText item, bool isSelect);
    public Del onSelect = null;

    private void Start()
    {
        m_btn.onClick.AddListener(OnClickEnter);
    }
    public void OnClickEnter()
    {
        if (onSelect != null)
        {
            onSelect(this, true);
        }
    }

    public void AddLinstener(Del del)
    {
        onSelect = new Del(del);
    }
}
