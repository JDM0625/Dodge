using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEditor.Build.Content;

public class GameScene08 : MonoBehaviour
{
    [SerializeField]
    Button[] m_BtnRoomList = new Button[4];


    private void Start()
    {
        for (int i = 0; i < m_BtnRoomList.Length; i++)
        {
            int idx = i;
            m_BtnRoomList[i].onClick.AddListener(() => OnClickedRoom(idx));
        }
    }
        
    void CheckRoomNum(int roomNum)
    {
        OnClickedRoom(roomNum);
    }

    void OnClickedRoom(int roomNum)
    {
        SceneManager.LoadScene(roomNum);
    }
}
