using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Device4 : MonoBehaviour {

    private GameObject floor;
	// Use this for initialization
	void Start ()
    {
        floor = GameObject.Find("D4Floor");
	}

    public void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Ball")
        {
            floor.GetComponent<Animator>().enabled = true;
        }
    }
}
