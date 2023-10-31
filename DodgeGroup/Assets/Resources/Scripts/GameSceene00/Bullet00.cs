using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet00 : MonoBehaviour
{
    public Transform m_Target;
    Vector3 addVector = Vector3.forward;
    public float m_Speed = 10f;

    private void Start()
    {
        
    }
    void Update()
    {
        //transform.LookAt(m_Target);
        transform.Translate(addVector * m_Speed * Time.deltaTime);
        // trnasform.positon += transform.forward * Time.deltaTime
    }
    public void Initialize(Transform target)
    {
        m_Target = target;
        transform.LookAt(m_Target);
    }
}
