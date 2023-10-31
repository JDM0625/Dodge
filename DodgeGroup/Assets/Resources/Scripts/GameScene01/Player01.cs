using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player01 : MonoBehaviour
{
    
    public float speed = 2f;

    [SerializeField]
    ParticleSystem m_ParticalSystem; 

    private void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");
        transform.Translate(new Vector3(x, 0, z) * speed * Time.deltaTime);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if ((collision.collider.gameObject.CompareTag("BULLET")))
        {
            m_ParticalSystem.gameObject.SetActive(true);
            Destroy(collision.collider.gameObject);
        }
    }

}
