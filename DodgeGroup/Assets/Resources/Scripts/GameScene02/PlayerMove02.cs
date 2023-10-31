using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove02 : MonoBehaviour
{
   
    
    public float speed = 5f;

    private void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");
        transform.Translate(new Vector3(x, 0, z) * speed * Time.deltaTime);
    }
}
