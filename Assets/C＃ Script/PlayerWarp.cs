using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeWarp : MonoBehaviour
{
    void Update()
    {

    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.name == "GoalPrefab")
        {
            this.transform.position = new Vector3(310f, 2.1f, 62f);
        }
    }
}