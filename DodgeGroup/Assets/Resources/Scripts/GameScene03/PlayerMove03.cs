using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class PlayerMove03 : MonoBehaviour
{

    [SerializeField]
    float speed = 3f;

    public ParticleSystem m_ParticleSystem;


    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        transform.Translate(new Vector3(x, 0, z) * speed * Time.deltaTime);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("BULLET"))
        {
            m_ParticleSystem.Play();
            Destroy(collision.gameObject);
        }
    }
}
