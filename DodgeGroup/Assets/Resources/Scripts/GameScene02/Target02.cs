using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target02 : MonoBehaviour
{
    [SerializeField]
    Transform m_Target;
    [SerializeField]
    Transform m_BulletStart;
    [SerializeField]
    GameObject m_PrefabBullet;
    [SerializeField]
    Transform m_TargetBody;
    [SerializeField]
    Transform m_BulletParents;

    Coroutine m_Coroutine;

    private void Update()
    {
        if(m_Coroutine != null)
        {
            m_TargetBody.LookAt(m_Target);
        }
    }   

    public void StartShoot()
    {
        m_Coroutine = StartCoroutine(Shoot());
    }

    public void StopShoot()
    {
        if (m_Coroutine == null) return;
        StopCoroutine(m_Coroutine);
        m_Coroutine = null;
    }

    IEnumerator Shoot()
    {
        while (true)
        {
            MakeBullet();
            yield return new WaitForSeconds(1f);
        }
    }

    void MakeBullet()
    {

        GameObject go = Instantiate(m_PrefabBullet, m_BulletParents);
        go.transform.position = m_BulletStart.position;
        go.GetComponent<Bullet02>().Initialize(m_Target);

    }

}
