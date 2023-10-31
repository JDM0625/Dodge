using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class Bullet01 : MonoBehaviour
{
    [SerializeField]
    float speed = 10f;
    Vector3 fire = Vector3.forward;
    Transform m_Target;

    private void Update()
    {
        transform.Translate(fire * speed * Time.deltaTime);
    }

    public void Initialize(Transform m_T)
    {
        m_Target = m_T;
       transform.LookAt(m_Target);

    }
}
