using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moving : MonoBehaviour
{
  
    private Vector3 finish;
    public float speed = 1.0f;
    void Start()
    {
        transform.position = new Vector3(0.0f, 0.0f, 0.0f);
        finish = new Vector3(0f, 0.0f, 100f);
    }

    void Update()
    {
        var step = speed * Time.deltaTime; 

        transform.position = Vector3.MoveTowards(transform.position, finish, step);
        if (Vector3.Distance(transform.position, finish) < 0.001f)
        {
            Debug.Log("end");

        }
    }
}
