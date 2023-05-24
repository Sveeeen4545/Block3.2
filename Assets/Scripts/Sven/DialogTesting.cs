using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

public class DialogTesting : MonoBehaviour
{
    public static DialogTesting Instance;

    //public TextMeshProUGUI textComponent;
    
    [SerializeField] [Range(0f, 1f)] private float textSpeed;
    [SerializeField] private int index;

    [Header("Dialogue Options")]
    //[SerializeField] private GameObject dialoguePanel;
    [SerializeField] private TextMeshProUGUI[] texts;
    [SerializeField] private string[] names;
    [SerializeField] private string[] lines;

    private void Awake()
    {
        Instance = this;
    }

    private void Start()
    {
        for (int i = 0; i < texts.Length; i++)
            texts[i].text = string.Empty;
    }

    public void Update()
    {
        if (Input.GetMouseButtonDown(0) || Input.GetButtonDown("Check"))
        {
            AdvanceDialogue();
      
            /*      
            if(textComponent.text == lines[index])
            {
                NextLine();
            }
            else
            {
                StopAllCoroutines();
                textComponent.text = lines[index];
            }
            */
        }
    }

    private void AdvanceDialogue()
    {
        if (index < lines.Length - 1)
        {
            index++;

            for (int i = 0; i < texts.Length; i++)
            {
                texts[0].text = names[index];
                texts[1].text = lines[index];
            }
        }
        else
        {
            HideDialog();
        }
    }

    public void StartDialog()
    {
        index = 0;
        
        for (int i = 0; i < texts.Length; i++)
        {
            texts[i].transform.parent.gameObject.SetActive(true);
        }

        StartCoroutine(TypeLine());
    }

    public void HideDialog()
    {
        for (int i = 0; i < texts.Length; i++)
        {
            texts[i].transform.parent.gameObject.SetActive(false);
        }
        StopAllCoroutines();
    }

    IEnumerator TypeLine()
    {
        foreach (char c in lines[index].ToCharArray())
        {
            for (int i = 0; i < texts.Length; i++)
            {
                texts[i].text += c;
            }
            yield return new WaitForSeconds(textSpeed);
        }
    }

    void NextLine()
    {
        /*
        if(index < lines.Length - 1)
        {
            index++;
            textComponent.text = string.Empty;
            StartCoroutine(TypeLine());
        }
        else
        {
            gameObject.SetActive(false);
        }
        */
    }
}
