using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Events : MonoBehaviour
{
    public GameObject Fourth;
    public GameObject Group;

    public float speed = 0.001f;
    void Start()
    {
        StartCoroutine(GroupStartMoving());
    }

    void Update()
    {

    }

    public void RunEvent(string event_name)
    { 
        switch (event_name)
        {
            case "add3char":
                AddCharCamera();
                break;
            case "stopmove":
                GroupStopMoving();
                break;
            case "startmove":
                StartCoroutine(GroupStartMoving());
                break;
            case "end":
                Debug.Log("END");
                EndGameMenu();
                break;
        }

    }

    public void StartGame() { }
    public void EndGame() { }    
    

    IEnumerator GroupStartMoving() 
    {
        GameObject.Find("1 Char Model").GetComponent<Animator>().Play("1 walking");
        GameObject.Find("2 Char Model").GetComponent<Animator>().Play("2 walking");

        GameObject.Find("1 steps").GetComponent<AudioSource>().mute = false;
        GameObject.Find("2 steps").GetComponent<AudioSource>().mute = false;

        if (GameObject.Find("4 Char Model")) 
        { 
            GameObject.Find("4 Char Model").GetComponent<Animator>().Play("4 walking");
            GameObject.Find("4 steps").GetComponent<AudioSource>().mute = false;
        }
            
        while (true)
        {
            Group.transform.Translate(0,0,0.01f);
            yield return new WaitForSeconds(0.01f);
        }
        
    }
    public void GroupStopMoving() 
    {
        StopAllCoroutines();

        GameObject.Find("1 Char Model").GetComponent<Animator>().Play("1 standing");
        GameObject.Find("2 Char Model").GetComponent<Animator>().Play("2 standing");

        GameObject.Find("1 steps").GetComponent<AudioSource>().mute = true;
        GameObject.Find("2 steps").GetComponent<AudioSource>().mute = true;
    }
    
    public void AddCharCamera() 
    {
        GameObject.Find("Character Manager").GetComponent<CharManager>().charCount = 3;
        GameObject.Find("4 Standing").SetActive(false);
        Fourth.SetActive(true); 
    }

    public void EndGameMenu() 
    {
        
        SceneManager.LoadScene("EndMenu");
    }
}

