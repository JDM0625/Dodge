using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    const float DEFAULT_SPEED = 10;
    [SerializeField]
    float speed = 1f;


    private void FixedUpdate()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        float xD = x * Time.deltaTime * speed * DEFAULT_SPEED;
        float zD = z * Time.deltaTime * speed * DEFAULT_SPEED;

        //transform.position += new Vector3(x, 0, z) * speed * Time.deltaTime;

        transform.Translate(xD, 0,zD, Space.World);
        
    }
}
