using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu : MonoBehaviour {

    public GameObject cam;
    public GameObject menuCanvas;
    public GameObject startBlock;

    public void StartGame()
    {
        menuCanvas.SetActive(false);
        cam.GetComponent<Animator>().enabled = true;
        cam.GetComponent<Animator>().Play("GameFollow");
        startBlock.SetActive(false);
    }

    public void Quit()
    {
        Debug.Log("Quit");
        Application.Quit();
    }
}
