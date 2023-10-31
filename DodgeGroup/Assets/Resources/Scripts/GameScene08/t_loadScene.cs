using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class t_loadScene : MonoBehaviour
{
    [SerializeField]
    Button[] m_btnRoomList = new Button[4];

    private void Start()
    {
        for (int i = 0; i < m_btnRoomList.Length; i++)
        {
            int num = i;
            m_btnRoomList[i].onClick.AddListener(()=>
            { 
                GetRoomNum(i); 
            });
        }
    }

    void GetRoomNum(int RoomList)
    {
         MoveScene(RoomList);
    }

    void MoveScene(int roomNum)
    {
        SceneManager.LoadScene(roomNum);
    }
    private void Update()
    {
        
    }
}
