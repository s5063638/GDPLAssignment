using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class End : MonoBehaviour {

    private AudioSource catMeow;

    void Start()
    {
        catMeow = GameObject.Find("cat-meow").GetComponent<AudioSource>();
    }

    public void OnTriggerEnter(Collider collision)
    {
        StartCoroutine(Reset());
    }

    IEnumerator Reset()
    {
        catMeow.Play();
        yield return new WaitForSeconds(3f);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
