using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Device2 : MonoBehaviour {

    private GameObject device;
    private bool collided = false;

    private void Start()
    {
        device = GameObject.Find("Pivot");
    }

    public void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Ball")
        {
            Debug.Log("Collided");
            collided = true;
        }
    }

    private void Update()
    {
        if (collided == true)
        {
            device.transform.Rotate(Vector3.forward, 60.0f * Time.deltaTime);
            if(device.transform.eulerAngles.z >= 90.0f)
            {
                collided = false;
            }
        }
    }
}