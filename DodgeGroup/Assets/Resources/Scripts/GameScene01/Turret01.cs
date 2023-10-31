using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turret01 : MonoBehaviour
{
    [SerializeField]
    GameObject m_bullet;
    [SerializeField]
    Transform m_bulletPos;
    [SerializeField]
    Transform m_bulletParents;

    [SerializeField]
    Transform m_Head;
    [SerializeField]
    Transform m_Target;

    float m_Time;

    public bool isFire = false;
    
    
    private void Initialize()
    {
        
    }

    // Coroutine m_Coru = null;
    
    void Shoot()
    {
        Make();
    }

    public void StartEnum()
    {
       //m_Coru =  StartCoroutine(EnumFireUpdate());
    }

    IEnumerator EnumFireUpdate()
    {
        while (isFire)
        {

            yield return new WaitForSeconds(1.0f);
        }
    }

    void Make()
    {
        GameObject go = Instantiate(m_bullet, m_bulletParents);
        Bullet01 bullet01 = go.GetComponent<Bullet01>();
        bullet01.Initialize(m_Target);
        go.transform.position = m_bulletPos.position;

        Destroy(bullet01, 5);
        
    }
    // Update is called once per frame
    void Update()
    {
        if (isFire)
        {
            m_Time += Time.deltaTime;
            if (m_Time >= 1)
            {
                Shoot();
                m_Time = 0;
            }
            m_Head.LookAt(m_Target);
        }
       
    }

}
