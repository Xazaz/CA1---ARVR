using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InterfaceManager : MonoBehaviour {
    public GameObject optionsMenu;
    // Use this for initialization
    void Start() {

    }

    // Update is called once per frame
    void Update() {

    }
    public void clickStart() {
        Application.LoadLevel(1);
}
    public void clickOption()
    {
        
        
        if(optionsMenu.activeInHierarchy == true)
        {
            optionsMenu.SetActive(false);
            Debug.Log(false);
        }
        else
        {
            optionsMenu.SetActive(true);
            Debug.Log(true);
        }
    }
}
