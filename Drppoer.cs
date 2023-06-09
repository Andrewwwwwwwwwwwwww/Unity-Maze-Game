using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drppoer : MonoBehaviour
{

    MeshRenderer renderer;
    Rigidbody rigidbody;

    float timeToWait = 5f;
    void Start()
    {
        //renderer = GetComponent<MeshRenderer>();
        //renderer.enabled = false;
        //rigidbody.useGravity = false;
    }


    void Update()
    {
        if (Time.time > timeToWait)
        {
            //renderer.enabled = true;
            //rigidbody.useGravity = true;
        }
    }
}
