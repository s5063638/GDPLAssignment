using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballSound : MonoBehaviour {

    private AudioSource sound;

	// Use this for initialization
	void Start ()
    {
        sound = GameObject.Find("collide").GetComponent<AudioSource>();
	}

    private void OnCollisionEnter(Collision collision)
    {
        sound.Play();
    }
}
