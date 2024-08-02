
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereMove : MonoBehaviour
{
    private GameObject target;
    public float speed;

    void Start()
    {
        speed = 0.05f;
        target = GameObject.Find("Cara");
    }

    void Update()
    {
        transform.LookAt(target.transform);
        transform.position += transform.forward * speed;
    }
}