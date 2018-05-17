using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Device3 : MonoBehaviour {

    private GameObject hingeBlock;

    void Start()
    {
        hingeBlock = GameObject.Find("HingeBlock");
    }

    public void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Button")
        {
            Destroy(hingeBlock.gameObject);
        }
    }

}
