using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarTest : MonoBehaviour
{
    public float speed = 2.5f;
    private Rigidbody rb;
    public bool testPhase = false;
    public bool successCheck = false;
    public bool failureCheck = false;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "SuccessCheck")
        {
            successCheck = true;
        }
        else
        {
            failureCheck = true;
        }
        testPhase = false;
    }

    void Update()
    {
        if (testPhase == true)
        {
            Vector3 movement = new Vector3(0.0f, 0.0f, 1f);
            rb.AddForce(movement * speed);
        }
    }
}
