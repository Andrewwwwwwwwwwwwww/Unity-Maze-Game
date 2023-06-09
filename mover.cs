using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mover : MonoBehaviour
{
    //[SerializeField]float xValue = 0.1f;
    //[SerializeField]float yValue = 0f;
    //[SerializeField]float zValue = 0.0f;
    [SerializeField] float thrust = 0.1f;
    public Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        Jump();
    }

    void Move()
    {
        //float xValue = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        //float zValue = Input.GetAxis("Vertical") * speed * Time.deltaTime;

        //transform.Translate(xValue, 0, zValue);
        if (Input.GetKey(KeyCode.W))
        {
            rb.AddRelativeForce(Vector3.forward * thrust);
        }

        if (Input.GetKey(KeyCode.S))
        {
            rb.AddRelativeForce(Vector3.back * thrust);
        }

        //if (Input.GetKey(KeyCode.A))
        //{
        //    rb.AddRelativeForce(Vector3.left * thrust);

        //}

        //if (Input.GetKey(KeyCode.D))
        //{
        //    rb.AddRelativeForce(Vector3.right * thrust);
        //}

        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(0, -.35f, 0);
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(0, .35f, 0);
        }
        

    }

    void Jump()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddRelativeForce(Vector3.up * thrust * 25);
        }
    }
}
