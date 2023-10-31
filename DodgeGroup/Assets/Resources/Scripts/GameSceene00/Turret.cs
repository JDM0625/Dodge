using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turret : MonoBehaviour
{
    [SerializeField]
    Transform m_Head = null;
    [SerializeField]
    Transform m_BulletPos = null;
    [SerializeField]
    GameObject m_PrefabBullet = null;
    [SerializeField]
    Transform m_Target = null;
    [SerializeField]
    Transform m_BulletParent;

    private void Start()
    {
        Initialize();
    }

    public void Initialize()
    {
       
    }

    void Fire()
    {
        CreatBullet();
    }

    void CreatBullet()
    {
        GameObject go = Instantiate(m_PrefabBullet, m_BulletParent);
        Bullet00 kBullet = go.GetComponent<Bullet00>();
        go.transform.position = m_BulletPos.position;

        kBullet.Initialize(m_Target);
        Destroy(go, 5);
    }

    private void Update()
    {
        m_Head.LookAt(m_Target);
        if (Input.GetMouseButtonDown(0))
        {
            Fire();
        }
    }
}
