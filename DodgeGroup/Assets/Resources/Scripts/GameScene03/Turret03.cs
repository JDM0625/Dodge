using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turret03 : MonoBehaviour
{
    public Transform m_Target;
    public Transform m_TurretBody;
    public Transform m_BulletStart;
    public GameObject m_PreBullet;
    public Transform m_BulletParents;

    Coroutine m_Coroutine;

    private void Update()
    {
        m_TurretBody.LookAt(m_Target);
    }

    IEnumerator e_Shoot()
    {
        while (true)
        {
            Make();
            yield return new WaitForSeconds(1);
        }
    }

    public  void StartFire03()
    {
        if(m_Coroutine == null)
        {
            m_Coroutine = StartCoroutine(e_Shoot());
        }

        
    }

    public void StopFire03()
    {
        if(m_Coroutine == null)
        {
            return;
        }
        StopCoroutine(m_Coroutine);
        m_Coroutine = null;
    }

    void Make()
    {
        GameObject gameobj = Instantiate(m_PreBullet, m_BulletParents);
        gameobj.transform.position = m_BulletStart.position;
        gameobj.GetComponent<Bullet03>().Initialize(m_Target);
    }
}
