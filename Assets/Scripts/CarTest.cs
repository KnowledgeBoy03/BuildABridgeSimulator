using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarTest : MonoBehaviour
{
    public float speed = 2.5f;
    private Rigidbody rb;
    private Vector3 OGpos;
    public bool testPhase = false;
    public bool successCheck = false;
    public bool failureCheck = false;

    void Start()
    {
        OGpos = transform.position;
        rb = GetComponent<Rigidbody>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "SuccessCheck")
        {
            successCheck = true;
        }
        else if (other.gameObject.name == "FailureCheck")
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

    public void positionReset()
    {
        transform.position = OGpos;
        rb.velocity = Vector3.zero;
        rb.angularVelocity = Vector3.zero;
        testPhase = false;
        successCheck = false;
        failureCheck = false;
        
        GameObject[] bridgeObjects = GameObject.FindGameObjectsWithTag("Bridge");
        for (int i = 0; i < bridgeObjects.Length; i++)
        {
            Destroy(bridgeObjects[i]);
        }
    }
}
