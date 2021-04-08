using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{

    public float speed = 10f;
    private float yaw = 0.0f;
    private float pitch = 0.0f;

    // Update is called once per frame
    void Update()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Vector3 pos = transform.position;
        
        if (Input.GetKey("w"))
        {
            pos += transform.forward * (speed * Time.deltaTime);
        }
        if (Input.GetKey("a"))
        {
            pos -= transform.right * (speed * Time.deltaTime);
        }
        if (Input.GetKey("s"))
        {
            pos -= transform.forward * (speed * Time.deltaTime);
        }
        if (Input.GetKey("d"))
        {
            pos += transform.right * (speed * Time.deltaTime);
        }
        if (Input.GetKey("space"))
        {
            if (pos.y < 10f)
            {
                pos.y += speed * Time.deltaTime;
            }
        }
        if (Input.GetKey("left ctrl"))
        {
            if (pos.y > 0f)
            {
                pos.y -= speed * Time.deltaTime;
            }
        }

        yaw += speed * Input.GetAxis("Mouse X");
        pitch -= speed * Input.GetAxis("Mouse Y");
        
        transform.position = pos;
        transform.eulerAngles = new Vector3(pitch, yaw, 0.0f);
    }
}
