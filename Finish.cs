using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Finish : MonoBehaviour
{
    float yPos = 0;
    float sPos = 0; //start position!!!!!!!!!!!

    // Start is called before the first frame update
    void Start()
    {
        sPos = this.transform.position.y;
    }

    // Update is called once per frame
    private void OnCollisionStay(Collision other)
    {
        if (yPos < 10)
        {
            transform.Translate(0, 0.1f, 0);
            yPos += 0.1f;
        }


    }
    private void OnCollisonExit(Collision other)
    {
        Debug.Log(yPos);
        transform.Translate(0, -sPos, 0);
        yPos = 0;
    }
}
