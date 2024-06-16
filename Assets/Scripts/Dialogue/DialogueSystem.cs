using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DialogueSystem : MonoBehaviour
{
    Dialogue[] dialogue;
    public float textSpeed = 0.3f;
    
    public TextMeshProUGUI first_char_line;
    public TextMeshProUGUI first_char_name;

    public TextMeshProUGUI third_char_line;
    public TextMeshProUGUI third_char_name;

    public GameObject first_textbox;
    public GameObject third_textbox;

    public int index;
    private int current;

    bool pause = false;

    void Start()
    {
        dialogue = GameObject.Find("Dialogue Manager").GetComponent<DialogueScript>().GetDialogScript();
        while (dialogue.Length == 0) 
        {
            dialogue = GameObject.Find("Dialogue Manager").GetComponent<DialogueScript>().GetDialogScript();
        }

        index = 0;
        StartDialogue();
    }

    void Update()
    {
        if (!pause) 
        {
            CheckTextBox();

            if (Input.GetMouseButtonUp(1))
            {
                if (first_char_line.text == dialogue[index].line)
                {
                    NextLine();
                }
                else 
                {
                    StopAllCoroutines();
                    first_char_line.text = dialogue[index].line;
                    third_char_line.text = dialogue[index].line;
                }
            } 
        }
    }

    void StartDialogue() 
    {
        first_char_line.text = string.Empty;
        third_char_line.text = string.Empty;
        
        first_char_name.text = dialogue[index].char_name;
        third_char_name.text = dialogue[index].char_name;

        StartCoroutine(TypeLine());
    }

    IEnumerator TypeLine() 
    {
        foreach (char c in dialogue[index].line.ToCharArray())  
        {
            first_char_line.text += c;
            third_char_line.text += c;

            yield return new WaitForSeconds(textSpeed);

        }
    }
    void NextLine() 
    {
        if (index < dialogue.Length - 1)
        {
            if (dialogue[index].event_type != null)
            {
                RunEvent(dialogue[index].event_type);
            }

            index++;
            StartDialogue();
        }
        else  
        {
            pause = true;
        }
    }
    void RunEvent(string event_name) 
    {
        if (event_name == "pause")
        {
            StartCoroutine(PauseDialogue());
        }
        else
        {
            GameObject.Find("Event Manager").GetComponent<Events>().ChooseEvent(event_name);
        }
    }

    IEnumerator PauseDialogue() 
    {
        pause = true;

        first_textbox.SetActive(false);
        third_textbox.SetActive(false);
        yield return new WaitForSeconds(5);

        pause = false;

        StartDialogue();
    }

    void CheckTextBox() 
    {
        current = GameObject.Find("Character Manager").GetComponent<CharManager>().GetCharacter();
        bool first_person_view = (dialogue[index].char_name == "1" && current == 1) || (dialogue[index].char_name == "2" && current == 2) || (dialogue[index].char_name == "4" && current == 3);
        first_textbox.SetActive(first_person_view);
        third_textbox.SetActive(!first_person_view);
    }



}
