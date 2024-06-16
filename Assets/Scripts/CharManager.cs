using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharManager : MonoBehaviour
{
    int currChar;
    public int charCount; 
    void Start()
    {
        currChar = 1;
        charCount = 2;
    }

    void Update()
    {
        if (Input.GetMouseButtonUp(0))
        {
            SwitchCharacter();
        }
    }

    public int GetCharacter() 
    {
        return currChar;
    }

    void SwitchCharacter() 
    {
        currChar++;
        if (currChar > charCount) { currChar = 1; }
    }
}
