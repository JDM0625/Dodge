using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using Unity.VisualScripting;

public class LoadSceneUI : MonoBehaviour
{
    [SerializeField]
    Button m_BtnList0;
    [SerializeField]
    Button m_BtnList1;
    [SerializeField]
    Button m_BtnList2;
    [SerializeField]
    Button m_BtnList3;

    int count;

    private void Start()
    {
        m_BtnList0.onClick.AddListener(OnClicked0);
        m_BtnList1.onClick.AddListener(OnClicked1);
        m_BtnList2.onClick.AddListener(OnClicked2);
        m_BtnList3.onClick.AddListener(OnClicked3);
    }

    void SceneList()
    {

    }

    void OnClicked0()
    {
        count = 1;
        CheckSceneList(count);
    }
    void OnClicked1()
    {
        count = 2;
        CheckSceneList(count);
    }
    void OnClicked2()
    {
        count = 3;
        CheckSceneList(count);
    }
    void OnClicked3()
    {
        count = 4;
        CheckSceneList(count);
    }

    void CheckSceneList(int num)
    {
        switch (num)
        {
            case 1 :
                SceneManager.LoadScene("GameScene00");
                break;
            case 2:
                SceneManager.LoadScene("GameScene01");
                break;
            case 3:
                SceneManager.LoadScene("GameScene02");
                break;
            case 4:
                SceneManager.LoadScene("GameScene03");
                break;
        }
    }

}
