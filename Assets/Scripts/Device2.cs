﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Device2 : MonoBehaviour {

    private GameObject device;
    private bool collided = false;

    private void Start()
    {
        device = GameObject.Find("D2Pivot");
    }

    public void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Ball")
        {
            Debug.Log("Collided");
            collided = true;
            StartCoroutine(DestroyBall(collision.gameObject));
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

    IEnumerator DestroyBall(GameObject _ball)
    {
        yield return new WaitForSeconds(1f);
        Destroy(_ball);
    }
}