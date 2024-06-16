using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchView : MonoBehaviour
{
    public Camera cam1;
    public Camera cam2;
    public Camera cam3;

    int current;
    void Start()
    {
        
    }

    void Update()
    {
        current = GameObject.Find("Character Manager").GetComponent<CharManager>().GetCharacter();
        SwitchMainCamera(current);
    }

    void SwitchMainCamera(int current) 
    {
        cam1.enabled = current == 1;
        cam2.enabled = current == 2;
        cam3.enabled = current == 3;
    }
    

}
