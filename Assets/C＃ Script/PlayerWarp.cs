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
        if (other.gameObject.name == "GoalPrefab1")
        {
            this.transform.position = new Vector3(310f, 2.1f, 62f);
        }

        if (other.gameObject.name == "GoalPrefab2")
        {
            this.transform.position = new Vector3(314f, 2.1f, 195f);
        }

        if (other.gameObject.name == "GoalPrefab3")
        {
            this.transform.position = new Vector3(259.5f, 0.9f, 280f);
        }
        if (other.gameObject.name == "GoalPrefab4")
        {
            this.transform.position = new Vector3(345f, 1.35f, 471.5f);
        }





    }
}