using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet01 : MonoBehaviour
{
    public Transform m_Target;
    Vector3 addVector = Vector3.forward;
    public float m_Speed = 10f;
    void Update()
    {
        transform.LookAt(m_Target);
        transform.position += addVector * m_Speed *  Time.deltaTime;
        // trnasform.positon += transform.forward * Time.deltaTime
    }
}
