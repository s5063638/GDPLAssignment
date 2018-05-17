using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Device9 : MonoBehaviour {

    public GameObject explosion;
    private GameObject dynamite;
    private GameObject ball;

    void Start()
    {
        ball = GameObject.Find("D9Ball");
        dynamite = GameObject.Find("TNT FBX");
    }

    public void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Button")
        {
            StartCoroutine(Explode());
        }
    }

    IEnumerator Explode()
    {
        yield return new WaitForSeconds(3f);
        explosion.SetActive(true);
        Destroy(dynamite);
        ball.GetComponent<Rigidbody>().AddForce(Vector3.right * 5.0f);
        Destroy(this.gameObject.GetComponent<Device9>());
    }
}
