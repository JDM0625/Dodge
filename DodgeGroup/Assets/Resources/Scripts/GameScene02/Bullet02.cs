using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet02 : MonoBehaviour
{
    Transform transfrom;

    public float speed = 5f;

    private void Update()
    {

        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
    public void Initialize(Transform target)
    {
        target.LookAt(transform);
    }
}
