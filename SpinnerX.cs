using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinnerX : MonoBehaviour
{
    float xAngle = 1.0f;
    float yAngle = 0;
    float zAngle = 0;
    void Start() { }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(xAngle, yAngle, zAngle);
    }
}
