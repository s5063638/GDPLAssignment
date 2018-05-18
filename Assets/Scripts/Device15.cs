using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Device15 : MonoBehaviour {

    private Rigidbody hinge;

    void Start()
    {
        hinge = GameObject.Find("D15Hinge").GetComponent<Rigidbody>();
    }

    public void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Ball")
        {
            hinge.freezeRotation = false;
        }
    }
}
