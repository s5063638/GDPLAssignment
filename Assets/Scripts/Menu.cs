using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu : MonoBehaviour {

    public GameObject cam;
    public GameObject menuCanvas;

    public void StartGame()
    {
        menuCanvas.SetActive(false);
        cam.GetComponent<Animator>().enabled = true;
    }
}
