using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Events : MonoBehaviour
{
    public GameObject Fourth;
    void Start()
    {
        
    }

    void Update()
    {
       
    }

    public void ChooseEvent(string event_name) 
    {
        if (event_name == "add3char") 
        { 
            Debug.Log("add character!");
            GameObject.Find("Character Manager").GetComponent<CharManager>().charCount = 3;
            GameObject.Find("Protagonist Walking (3)").SetActive(false);
            Fourth.SetActive(true);
        }
    }

}
