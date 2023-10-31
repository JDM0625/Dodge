using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet03 : MonoBehaviour
{
    public Transform m_Target;
    public float m_Speed = 3f;

    public void Initialize(Transform tar)
    {
        m_Target = tar;
        transform.LookAt(m_Target);
       
    }

    private void Update()
    {
        transform.Translate(Vector3.forward * m_Speed * Time.deltaTime, Space.Self);
    }
}
