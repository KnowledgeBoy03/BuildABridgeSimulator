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
    public WoodBeam woodBeam;
    public SteelBeam steelBeam;
    public Road road;
    public Rope rope;
    private int carCap;
    public int weightLim;
    public bool bridgeFailed;

    void Start()
    {
        OGpos = transform.position;
        rb = GetComponent<Rigidbody>();
        carCap = 40;
        bridgeFailed = false;
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
    }

    private void OnCollisionExit(Collision other)
    {
        if (other.gameObject.name == "Road(Clone)")
        {
            if (carCap > weightLim)
            {
                bridgeFailed = true;
            }
        }
    }

    void Update()
    {
        if (testPhase == true)
        {
            Vector3 movement = new Vector3(0.0f, 0.0f, 2f);
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
        bridgeFailed = false;
        
        GameObject[] bridgeObjects = GameObject.FindGameObjectsWithTag("Bridge");
        for (int i = 0; i < bridgeObjects.Length; i++)
        {
            Destroy(bridgeObjects[i]);
        }
        
        woodBeam.count = 20;
        steelBeam.count = 4;
        road.count = 10;
        rope.count = 15;
    }
}
